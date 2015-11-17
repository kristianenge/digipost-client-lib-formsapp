using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using digipost_client_lib_formsapp.Properties;
using Digipost.Api.Client.Domain.Enums;
using Digipost.Api.Client.Domain.Exceptions;
using Digipost.Api.Client.Domain.Identify;
using Digipost.Api.Client.Domain.Search;
using Digipost.Api.Client.Domain.SendMessage;

namespace digipost_client_lib_formsapp
{
    public partial class DigipostForm : Form
    {
        
        private DigipostService _digipostService;

        public DigipostForm()
        {
            InitializeComponent();
            InitDigipostService();
        }

        private void InitDigipostService()
        {
            int timeout;
            int.TryParse(Settings.Default.timeout, out timeout);
            _digipostService = new DigipostService(txt_config_technicalID.Text, txt_config_thumbprint.Text,
                txt_config_url.Text, timeout);
        }

        private async void btnIdentify_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await _digipostService.Identify(
                    new Identification(new RecipientById(IdentificationType.PersonalIdentificationNumber,
                        txt_identify_ssn.Text)));
                AppendResponse("Identify: Data: " + result.Data + ", ResultType: " + result.ResultType + ", Error: " +
                               result.Error);
            }
            catch (ClientResponseException cre)
            {
                var message = cre.InnerException?.Message ?? cre.Error.ToString();
                AppendResponse("Identify: Status:" + message);
            }
            catch (XmlException xe)
            {
                var message = xe.InnerException?.Message ?? xe.Message;
                AppendResponse("Identify: Status:" + message);
            }
        }

        private void btn_config_update_Click(object sender, EventArgs e)
        {
            InitDigipostService();
        }

        private async void txt_Search_searchString_TextChanged(object sender, EventArgs e)
        {
            lbox_search_result.Items.Clear();
            try
            {
                var result = await _digipostService.Search(txt_Search_searchString.Text);
                AppendResponse("Search[" + txt_Search_searchString.Text + "]: count[" + result.PersonDetails.Count + "]");
                lbox_search_result.Items.AddRange(result.PersonDetails.ToArray());
            }
            catch (ClientResponseException cre)
            {
                var message = cre.InnerException?.Message ?? cre.Error.ToString();
                AppendResponse("Search[" + txt_Search_searchString.Text + "]: " + message);
            }
        }

        private void AppendResponse(string text)
        {
            rtf_response_text.AppendText(text + Environment.NewLine);
            rtf_response_text.ScrollToCaret();
        }

        private void lbox_search_result_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox) sender;
            var selectedItem = (SearchDetails) listBox.SelectedItem;

            btn_search_sendTo.Enabled = btn_search_moreInfo.Enabled = selectedItem != null;
        }

        private void btn_search_moreInfo_Click(object sender, EventArgs e)
        {
            var selectedItem = lbox_search_result.SelectedItem;
            MessageBox.Show(selectedItem.ToString());
        }

        private void btn_search_sendTo_Click(object sender, EventArgs e)
        {
            var selectedItem = (SearchDetails) lbox_search_result.SelectedItem;
            txt_send_digipostAddress.Text = selectedItem.DigipostAddress;
            TabPanel.SelectTab(2);
        }

        private void btn_send_selectFile_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                txt_send_file.Text = file;
            }
        }

        private async void btn_send_send_Click(object sender, EventArgs e)
        {
            byte[] file = null;
            var fileType = "";

            if (openFileDialog.FileName != null && !string.IsNullOrEmpty(txt_send_file.Text))
            {
                file = File.ReadAllBytes(openFileDialog.FileName);
                fileType = openFileDialog.FileName.Split('.')[1];
            }
            var subject = txt_send_subject.Text;
            var digipostAddress = txt_send_digipostAddress.Text;
            try
            {
                var response = await _digipostService.Send(file, fileType, subject, digipostAddress);
                AppendResponse("Send: Status: " + response.Status + ", DeliveryMethod: " + response.DeliveryMethod);
            }
            catch (ClientResponseException cre)
            {
                var message = cre.InnerException?.Message ?? cre.Error.ToString();
                AppendResponse("Send: Status:" + message);
            }
        }

        private void txt_send_digipostAddress_TextChanged(object sender, EventArgs e)
        {
            ActivateSendButton();
        }

        private void txt_send_file_TextChanged(object sender, EventArgs e)
        {
            ActivateSendButton();
        }

        private void ActivateSendButton()
        {
            btn_send_send.Enabled = !string.IsNullOrEmpty(txt_send_digipostAddress.Text) &&
                                    !string.IsNullOrEmpty(txt_send_file.Text);
        }

        private void DigipostForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}