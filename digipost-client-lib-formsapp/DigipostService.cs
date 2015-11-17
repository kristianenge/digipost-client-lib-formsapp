﻿using System.Threading.Tasks;
using Digipost.Api.Client;
using Digipost.Api.Client.Api;
using Digipost.Api.Client.Domain.Enums;
using Digipost.Api.Client.Domain.Identify;
using Digipost.Api.Client.Domain.Search;
using Digipost.Api.Client.Domain.SendMessage;

namespace digipost_client_lib_formsapp
{
    public class DigipostService
    {
        private static DigipostClient _digipostClient;
        private readonly string _senderId;
        private readonly string _thumbprint;
        private readonly int _timeout;
        private readonly string _url;

        public DigipostService(string senderId, string thumbprint, string url, int timeout)
        {
            _senderId = senderId;
            _thumbprint = thumbprint;
            _url = url;
            _timeout = timeout;
        }

        public virtual async Task<IIdentificationResult> Identify(Identification identification)
        {
            return await GetClient().IdentifyAsync(identification);
        }

        public virtual async Task<ISearchDetailsResult> Search(string searchText)
        {
            return await GetClient().SearchAsync(searchText);
        }

        public virtual async Task<IMessageDeliveryResult> Send(byte[] fileContent, string filetype, string subject,
            string digipostAddress, SensitivityLevel sensitivity = SensitivityLevel.Normal,
            AuthenticationLevel authentication = AuthenticationLevel.Password, SmsNotification smsNotification = null)
        {
            var recipient = new RecipientById(IdentificationType.DigipostAddress, digipostAddress);

            var primaryDocument = new Document(subject, filetype, fileContent)
            {
                SensitivityLevel = sensitivity,
                AuthenticationLevel = authentication
            };
            if (smsNotification != null)
                primaryDocument.SmsNotification = smsNotification;

            var m = new Message(recipient, primaryDocument);

            return await GetClient().SendMessageAsync(m);
        }

        private DigipostClient GetClient()
        {
            return _digipostClient ?? InitClient();
        }

        private DigipostClient InitClient()
        {
            var config = new ClientConfig(_senderId, _url, _timeout, false)
            {
                Logger = (severity, traceId, metode, message) =>
                {
                    //no logging
                }
            };
            _digipostClient = new DigipostClient(config, _thumbprint);

            return _digipostClient;
        }
    }
}