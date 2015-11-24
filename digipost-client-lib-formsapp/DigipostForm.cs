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
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digipost_client_lib_formsapp
{
    public partial class DigipostForm : Form
    {
        private string _technicalId;
        private string _thumbprint;
        private string _url;

        private DigipostService _digipostService;
        public DigipostForm()
        {
            InitializeComponent();
            InitDigipostService();
            InitDropDownlists();
            InitConfig();
        }
        private void InitConfig()
        {
            var config = new Config();
            config.Closing += ExtractConfigFromForm;
            config.Show();
            config.Close();
        }
        private void InitDropDownlists()
        {
            foreach (var id in Enum.GetValues(typeof(IdentificationType)))
            {
                comboId.Items.Add(id);
            }
        }
        private void InitDigipostService()
        {
            var timeout = Settings.Default.timeoutInMs;
            _digipostService = new DigipostService(_technicalId, _thumbprint,
                _url, timeout);
        }
        private void AppendResponse(string text)
        {
            rtf_response_text.AppendText(text + Environment.NewLine);
            rtf_response_text.ScrollToCaret();
        }
        private void DigipostForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        #region Config
      

        private void btnConfig_Click(object sender, EventArgs e)
        {
            var config = new Config();
            config.Closing += ExtractConfigFromForm;
            config.Show();
        }

        private void ExtractConfigFromForm(object sender, CancelEventArgs e)
        {
            var configForm = (Form)sender;
            foreach (var texBoxController in configForm.Controls.Cast<object>().Where(control => control.GetType() == typeof (TextBox)).Cast<TextBox>())
            {
                switch (texBoxController.Name)
                {
                    case "txt_config_technicalID":
                        _technicalId = texBoxController.Text;
                        break;
                    case "txt_config_thumbprint":
                        _thumbprint = texBoxController.Text;
                        break;
                    case "txt_config_url":
                        _url = texBoxController.Text;
                        break;
                }
            }
            InitDigipostService();
        }

        #endregion

        #region Identify
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

        #endregion

        #region Search


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

        private void lbox_search_result_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            var selectedItem = (SearchDetails)listBox.SelectedItem;

            btn_search_sendTo.Enabled = btn_search_moreInfo.Enabled = selectedItem != null;
        }

        private void btn_search_moreInfo_Click(object sender, EventArgs e)
        {
            var selectedItem = lbox_search_result.SelectedItem;
            MessageBox.Show(selectedItem.ToString());
        }

        private void btn_search_sendTo_Click(object sender, EventArgs e)
        {
            var selectedItem = (SearchDetails)lbox_search_result.SelectedItem;
            txt_send_digipostAddress.Text = selectedItem.DigipostAddress;
            comboId.SelectedItem = IdentificationType.DigipostAddress;
            TabPanel.SelectTab(2);
        }


        #endregion

        #region Send
        public string ExtractedHtmlContent { get; set; }

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
            await SendMessage(txt_send_subject.Text, (IdentificationType)comboId.SelectedItem, txt_send_digipostAddress.Text, txt_send_file.Text);
        }

        private async Task SendMessage(string subject, IdentificationType identification, string identificationValue, string filePath)
        {
            byte[] file = null;
            var fileType = "";

            if (openFileDialog.FileName != null && !string.IsNullOrEmpty(filePath))
            {
                file = File.ReadAllBytes(openFileDialog.FileName);
                fileType = openFileDialog.FileName.Split('.')[1];
            }
            else if (!string.IsNullOrEmpty(ExtractedHtmlContent))
            {
                file = Encoding.UTF8.GetBytes(ExtractedHtmlContent);
                fileType = "html";
            }

            try
            {
                var response = await _digipostService.Send(file, fileType, subject, identification, identificationValue);
                AppendResponse("Send: Status: " + response.Status + ", DeliveryMethod: " + response.DeliveryMethod);
                ResetSendView();
            }
            catch (ClientResponseException cre)
            {
                var message = cre.InnerException?.Message ?? cre.Error.ToString();
                AppendResponse("Send: Status:" + message);
            }
        }

        private void ResetSendView()
        {
            ExtractedHtmlContent = null;
            txt_send_file.Text = null;
            ActivateSendButton();
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
            btn_send_send.Enabled = (!string.IsNullOrEmpty(txt_send_digipostAddress.Text)) &&
                                    !string.IsNullOrEmpty(txt_send_file.Text) || !string.IsNullOrEmpty(ExtractedHtmlContent);
        }
        
        private void btn_send_createDocument_Click(object sender, EventArgs e)
        {
            var editor = new Editor();
            editor.Closing += ExtractTextFromEditorForm;
            editor.Show();
        }

        private void ExtractTextFromEditorForm(object sender, CancelEventArgs args)
        {
            var editorForm = (Form)sender;
            foreach (var simpleHtml in (from object control in editorForm.Controls select control as Control into c where c.GetType() == typeof(RichTextBox) select c.Text).Select(text => text.Replace("\n", "<br/>")).Select(content => $"<html><body>{content}</body></html>"))
            {
                ExtractedHtmlContent = simpleHtml;
            }
            ActivateSendButton();
        }

        #endregion

        
    }
}