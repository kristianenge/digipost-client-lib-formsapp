using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using digipost_client_lib_formsapp.Properties;
using Digipost.Api.Client.Domain.Enums;
using Digipost.Api.Client.Domain.Identify;
using Digipost.Api.Client.Domain.SendMessage;

namespace digipost_client_lib_formsapp
{
    public partial class BatchForm : Form
    {
        List<MappingObject> MappingObjects = new List<MappingObject>();
        private DigipostService _digipostService;
        private string _technicalId;
        private string _thumbprint;
        private string _url;
        public BatchForm()
        {
            InitializeComponent();
            InitConfig();
        }
        
        #region Config

        private void InitConfig()
        {
            var config = new Config();
            config.Closing += ExtractConfigFromForm;
            config.Show();
            config.Close();
        }
        private void ExtractConfigFromForm(object sender, CancelEventArgs e)
        {
            var configForm = (Form)sender;
            foreach (
                var texBoxController in
                    configForm.Controls.Cast<object>()
                        .Where(control => control.GetType() == typeof(TextBox))
                        .Cast<TextBox>())
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
        private void InitDigipostService()
        {
            var timeout = Settings.Default.timeoutInMs;
            _digipostService = new DigipostService(_technicalId, _thumbprint,
                _url, timeout);
        }
        #endregion

        #region processFile

        private void btn_send_selectFile_Click(object sender, EventArgs e)
        {
            var result = fileDialogBatch.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK)
            {
                var file = fileDialogBatch.FileName;
                txt_send_file.Text = file;
            }

            ProcessFile(cbHeader.Checked);

        }

        private void ProcessFile(bool header)
        {
            var seperator = txtSeparator.Text.ToCharArray()[0];
            var rows = File.ReadAllLines(txt_send_file.Text, Encoding.UTF8).Select(x => x.Split(seperator)).ToList();
            var dt = new DataTable();
            if (header)
            {
                foreach (var column in rows[0])
                {
                    dt.Columns.Add(column);
                }
                for (var i = 1; i < rows.Count; i++)
                {
                    dt.Rows.Add(rows[i]);
                }
            }
            else
            {
                rows.ForEach(x =>
                {
                    dt.Rows.Add(x);
                });
            }
            dgv.DataSource = dt;
            dgv.ReadOnly = true;

            ddlSplittcolumn.Items.AddRange(GetHeaderColumnList());
        }

        private string[] GetHeaderColumnList()
        {
            var columList = new List<string>(dgv.ColumnCount);
            columList.AddRange(from DataGridViewTextBoxColumn column in dgv.Columns select column.Name);

            return columList.ToArray();
        }
        #endregion
        
        #region identify

        private async void btnIdentify_Click(object sender, EventArgs e)
        {
            var countOk = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (rbDigipostAddress.Checked)
                {
                    foreach (var mappingObject in MappingObjects)
                    {
                        var value = row.Cells[mappingObject.ColumnIndex].Value;
                        var identification = new Identification(new RecipientById(IdentificationType.DigipostAddress, (string)value));
                        var result = await _digipostService.Identify(identification);
                        if (result.ResultType == IdentificationResultType.DigipostAddress)
                            countOk++;
                    }

                }
                else if (rbFullNameAndAddress.Checked)
                {
                    var fullName = "";
                    var address = "";
                    var postalCode = "";
                    var city = "";
                    foreach (var mappingObject in MappingObjects)
                    {
                        switch (mappingObject.DigipostValue)
                        {
                            case "Full name":
                                fullName = (string)row.Cells[mappingObject.ColumnIndex].Value;
                                break;
                            case "Address":
                                address = (string)row.Cells[mappingObject.ColumnIndex].Value;
                                break;
                            case "Postal code":
                                postalCode = (string)row.Cells[mappingObject.ColumnIndex].Value;
                                break;
                            case "City":
                                city = (string)row.Cells[mappingObject.ColumnIndex].Value;
                                break;
                        }
                    }
                    var recipientByNameAndAddress = new RecipientByNameAndAddress(fullName, address, postalCode, city);
                    var identification = new Identification(recipientByNameAndAddress);
                    var result = await _digipostService.Identify(identification);
                    if (result.ResultType == IdentificationResultType.DigipostAddress)
                        countOk++;

                }
                else if (rbSSN.Checked)
                {
                    var m = MappingObjects[0];
                    var value = row.Cells[m.ColumnIndex].Value;
                    var identification = new Identification(new RecipientById(IdentificationType.PersonalIdentificationNumber, (string)value));
                    var result = await _digipostService.Identify(identification);
                    if (result.ResultType == IdentificationResultType.DigipostAddress)
                        countOk++;
                }

            }
            MessageBox.Show("Count: " + countOk);
        }

        #endregion

        #region mapping



        private void AddValueMappingToPanel(string name, Color color)
        {
            var panel = new FlowLayoutPanel();
            var txtfield = new TextBox
            {
                Text = name,
                Name = "txt" + name.Trim(),
                BackColor = color,
                ForeColor = Color.Black,
                Enabled = false
            };

            var ddl = new ComboBox { Name = "ddl" + name.Trim() };
            ddl.SelectedIndexChanged += MappingValueChanged;
            ddl.Items.AddRange(GetHeaderColumnList());
            MappingObjects.Add(new MappingObject(name, color, ddl.Name));
            panel.Controls.Add(txtfield);
            panel.Controls.Add(ddl);
            pnlMapping.Controls.Add(panel);
        }

        private void MappingValueChanged(object sender, EventArgs e)
        {
            var combobox = (ComboBox)sender;
            var selectdItem = combobox.SelectedItem;

            foreach (DataGridViewTextBoxColumn column in dgv.Columns)
            {
                if (column.Name == selectdItem)
                {
                    foreach (var mappingObject in MappingObjects)
                    {
                        if (mappingObject.DDLValueName == combobox.Name)
                        {
                            column.DefaultCellStyle.BackColor = mappingObject.BgColor;
                            mappingObject.ColumnIndex = column.Index;
                        }
                    }
                }
            }
        }


        public class MappingObject
        {

            public string DDLValueName { get; }
            public string DigipostValue { get; set; }


            public MappingObject(string digipostValue, Color color, string ddlValueName)
            {
                DDLValueName = ddlValueName;
                BgColor = color;
                DigipostValue = digipostValue;
            }
            public Color BgColor { get; set; }
            public int ColumnIndex { get; set; }
        }

        private void rbFullNameAndAddress_CheckedChanged(object sender, EventArgs e)
        {
            ResetMappingView();
            AddValueMappingToPanel("Full name", Color.YellowGreen);
            AddValueMappingToPanel("Address", Color.Aqua);
            AddValueMappingToPanel("City", Color.Blue);
            AddValueMappingToPanel("Postal code", Color.Brown);
        }


        private void ResetMappingView()
        {
            pnlMapping.Controls.Clear();
            MappingObjects.Clear();
            dgv.DataSource = null;
            ProcessFile(cbHeader.Checked);
        }

        private void rbSSN_CheckedChanged(object sender, EventArgs e)
        {
            ResetMappingView();
            AddValueMappingToPanel("Sosial security number", Color.Coral);
        }

        private void rbDigipostAddress_CheckedChanged(object sender, EventArgs e)
        {
            ResetMappingView();
            AddValueMappingToPanel("Digipost address", Color.DarkTurquoise);
        }
        #endregion

        #region splitt
        private void btnSplitt_Click(object sender, EventArgs e)
        {

        }
        #endregion
        
    }
}
