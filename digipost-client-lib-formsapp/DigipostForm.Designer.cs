namespace digipost_client_lib_formsapp
{
    partial class DigipostForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtf_response_text = new System.Windows.Forms.RichTextBox();
            this.lbl_response_info = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TP_Send = new System.Windows.Forms.TabPage();
            this.gbSendPrint = new System.Windows.Forms.GroupBox();
            this.lblSendPrintFrom = new System.Windows.Forms.Label();
            this.lblSendPrintTO = new System.Windows.Forms.Label();
            this.lblSendPrintCity_Ret = new System.Windows.Forms.Label();
            this.lblSendPrintPostalCode_Ret = new System.Windows.Forms.Label();
            this.lblSendPrintAddress_Ret = new System.Windows.Forms.Label();
            this.txtSendPrintCity_Ret = new System.Windows.Forms.TextBox();
            this.txtSendPrintPostalCode_Ret = new System.Windows.Forms.TextBox();
            this.txtSendPrintAddress_Ret = new System.Windows.Forms.TextBox();
            this.txtSendPrintFullName_ret = new System.Windows.Forms.TextBox();
            this.lblSendPrintFullName_Ret = new System.Windows.Forms.Label();
            this.lblSendPrintCity = new System.Windows.Forms.Label();
            this.lblSendPrintPostalCode = new System.Windows.Forms.Label();
            this.lblSendPrint_Address = new System.Windows.Forms.Label();
            this.txtSendPrintCity = new System.Windows.Forms.TextBox();
            this.txtSendPrintPostalCode = new System.Windows.Forms.TextBox();
            this.txtSendPrintAddress = new System.Windows.Forms.TextBox();
            this.txtSendPrintFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboId = new System.Windows.Forms.ComboBox();
            this.btn_send_createDocument = new System.Windows.Forms.Button();
            this.txt_send_file = new System.Windows.Forms.TextBox();
            this.txt_send_subject = new System.Windows.Forms.TextBox();
            this.txt_send_digipostAddress = new System.Windows.Forms.TextBox();
            this.lbl_send_file = new System.Windows.Forms.Label();
            this.lbl_send_subject = new System.Windows.Forms.Label();
            this.btn_send_send = new System.Windows.Forms.Button();
            this.btn_send_selectFile = new System.Windows.Forms.Button();
            this.cbSendPrint = new System.Windows.Forms.CheckBox();
            this.TP_Search = new System.Windows.Forms.TabPage();
            this.btn_search_sendTo = new System.Windows.Forms.Button();
            this.btn_search_moreInfo = new System.Windows.Forms.Button();
            this.lbox_search_result = new System.Windows.Forms.ListBox();
            this.txt_Search_searchString = new System.Windows.Forms.TextBox();
            this.lbl_Search_searchString = new System.Windows.Forms.Label();
            this.TabPanel = new System.Windows.Forms.TabControl();
            this.TP_Identify = new System.Windows.Forms.TabPage();
            this.comboBoxIdentify = new System.Windows.Forms.ComboBox();
            this.lbl_Identify_ssn = new System.Windows.Forms.Label();
            this.txt_identify_ssn = new System.Windows.Forms.TextBox();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TP_Send.SuspendLayout();
            this.gbSendPrint.SuspendLayout();
            this.TP_Search.SuspendLayout();
            this.TabPanel.SuspendLayout();
            this.TP_Identify.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtf_response_text);
            this.panel1.Controls.Add(this.lbl_response_info);
            this.panel1.Location = new System.Drawing.Point(6, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 149);
            this.panel1.TabIndex = 4;
            // 
            // rtf_response_text
            // 
            this.rtf_response_text.Location = new System.Drawing.Point(70, 23);
            this.rtf_response_text.Name = "rtf_response_text";
            this.rtf_response_text.ReadOnly = true;
            this.rtf_response_text.Size = new System.Drawing.Size(539, 115);
            this.rtf_response_text.TabIndex = 1;
            this.rtf_response_text.Text = "";
            // 
            // lbl_response_info
            // 
            this.lbl_response_info.AutoSize = true;
            this.lbl_response_info.Location = new System.Drawing.Point(9, 73);
            this.lbl_response_info.Name = "lbl_response_info";
            this.lbl_response_info.Size = new System.Drawing.Size(55, 13);
            this.lbl_response_info.TabIndex = 0;
            this.lbl_response_info.Text = "Response";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // TP_Send
            // 
            this.TP_Send.Controls.Add(this.cbSendPrint);
            this.TP_Send.Controls.Add(this.gbSendPrint);
            this.TP_Send.Controls.Add(this.comboId);
            this.TP_Send.Controls.Add(this.btn_send_createDocument);
            this.TP_Send.Controls.Add(this.txt_send_file);
            this.TP_Send.Controls.Add(this.txt_send_subject);
            this.TP_Send.Controls.Add(this.txt_send_digipostAddress);
            this.TP_Send.Controls.Add(this.lbl_send_file);
            this.TP_Send.Controls.Add(this.lbl_send_subject);
            this.TP_Send.Controls.Add(this.btn_send_send);
            this.TP_Send.Controls.Add(this.btn_send_selectFile);
            this.TP_Send.Location = new System.Drawing.Point(4, 22);
            this.TP_Send.Name = "TP_Send";
            this.TP_Send.Size = new System.Drawing.Size(673, 259);
            this.TP_Send.TabIndex = 2;
            this.TP_Send.Text = "Send";
            this.TP_Send.UseVisualStyleBackColor = true;
            // 
            // gbSendPrint
            // 
            this.gbSendPrint.Controls.Add(this.lblSendPrintFrom);
            this.gbSendPrint.Controls.Add(this.lblSendPrintTO);
            this.gbSendPrint.Controls.Add(this.lblSendPrintCity_Ret);
            this.gbSendPrint.Controls.Add(this.lblSendPrintPostalCode_Ret);
            this.gbSendPrint.Controls.Add(this.lblSendPrintAddress_Ret);
            this.gbSendPrint.Controls.Add(this.txtSendPrintCity_Ret);
            this.gbSendPrint.Controls.Add(this.txtSendPrintPostalCode_Ret);
            this.gbSendPrint.Controls.Add(this.txtSendPrintAddress_Ret);
            this.gbSendPrint.Controls.Add(this.txtSendPrintFullName_ret);
            this.gbSendPrint.Controls.Add(this.lblSendPrintFullName_Ret);
            this.gbSendPrint.Controls.Add(this.lblSendPrintCity);
            this.gbSendPrint.Controls.Add(this.lblSendPrintPostalCode);
            this.gbSendPrint.Controls.Add(this.lblSendPrint_Address);
            this.gbSendPrint.Controls.Add(this.txtSendPrintCity);
            this.gbSendPrint.Controls.Add(this.txtSendPrintPostalCode);
            this.gbSendPrint.Controls.Add(this.txtSendPrintAddress);
            this.gbSendPrint.Controls.Add(this.txtSendPrintFullName);
            this.gbSendPrint.Controls.Add(this.label1);
            this.gbSendPrint.Enabled = false;
            this.gbSendPrint.Location = new System.Drawing.Point(15, 87);
            this.gbSendPrint.Name = "gbSendPrint";
            this.gbSendPrint.Size = new System.Drawing.Size(527, 169);
            this.gbSendPrint.TabIndex = 10;
            this.gbSendPrint.TabStop = false;
            this.gbSendPrint.Text = "        Print";
            // 
            // lblSendPrintFrom
            // 
            this.lblSendPrintFrom.AutoSize = true;
            this.lblSendPrintFrom.Location = new System.Drawing.Point(345, 20);
            this.lblSendPrintFrom.Name = "lblSendPrintFrom";
            this.lblSendPrintFrom.Size = new System.Drawing.Size(33, 13);
            this.lblSendPrintFrom.TabIndex = 17;
            this.lblSendPrintFrom.Text = "From:";
            // 
            // lblSendPrintTO
            // 
            this.lblSendPrintTO.AutoSize = true;
            this.lblSendPrintTO.Location = new System.Drawing.Point(16, 20);
            this.lblSendPrintTO.Name = "lblSendPrintTO";
            this.lblSendPrintTO.Size = new System.Drawing.Size(23, 13);
            this.lblSendPrintTO.TabIndex = 16;
            this.lblSendPrintTO.Text = "To:";
            // 
            // lblSendPrintCity_Ret
            // 
            this.lblSendPrintCity_Ret.AutoSize = true;
            this.lblSendPrintCity_Ret.Location = new System.Drawing.Point(342, 126);
            this.lblSendPrintCity_Ret.Name = "lblSendPrintCity_Ret";
            this.lblSendPrintCity_Ret.Size = new System.Drawing.Size(24, 13);
            this.lblSendPrintCity_Ret.TabIndex = 15;
            this.lblSendPrintCity_Ret.Text = "City";
            // 
            // lblSendPrintPostalCode_Ret
            // 
            this.lblSendPrintPostalCode_Ret.AutoSize = true;
            this.lblSendPrintPostalCode_Ret.Location = new System.Drawing.Point(342, 100);
            this.lblSendPrintPostalCode_Ret.Name = "lblSendPrintPostalCode_Ret";
            this.lblSendPrintPostalCode_Ret.Size = new System.Drawing.Size(63, 13);
            this.lblSendPrintPostalCode_Ret.TabIndex = 14;
            this.lblSendPrintPostalCode_Ret.Text = "Postal code";
            // 
            // lblSendPrintAddress_Ret
            // 
            this.lblSendPrintAddress_Ret.AutoSize = true;
            this.lblSendPrintAddress_Ret.Location = new System.Drawing.Point(342, 74);
            this.lblSendPrintAddress_Ret.Name = "lblSendPrintAddress_Ret";
            this.lblSendPrintAddress_Ret.Size = new System.Drawing.Size(45, 13);
            this.lblSendPrintAddress_Ret.TabIndex = 13;
            this.lblSendPrintAddress_Ret.Text = "Address";
            // 
            // txtSendPrintCity_Ret
            // 
            this.txtSendPrintCity_Ret.Location = new System.Drawing.Point(408, 119);
            this.txtSendPrintCity_Ret.Name = "txtSendPrintCity_Ret";
            this.txtSendPrintCity_Ret.Size = new System.Drawing.Size(100, 20);
            this.txtSendPrintCity_Ret.TabIndex = 12;
            // 
            // txtSendPrintPostalCode_Ret
            // 
            this.txtSendPrintPostalCode_Ret.Location = new System.Drawing.Point(408, 93);
            this.txtSendPrintPostalCode_Ret.Name = "txtSendPrintPostalCode_Ret";
            this.txtSendPrintPostalCode_Ret.Size = new System.Drawing.Size(100, 20);
            this.txtSendPrintPostalCode_Ret.TabIndex = 11;
            // 
            // txtSendPrintAddress_Ret
            // 
            this.txtSendPrintAddress_Ret.Location = new System.Drawing.Point(408, 67);
            this.txtSendPrintAddress_Ret.Name = "txtSendPrintAddress_Ret";
            this.txtSendPrintAddress_Ret.Size = new System.Drawing.Size(100, 20);
            this.txtSendPrintAddress_Ret.TabIndex = 10;
            // 
            // txtSendPrintFullName_ret
            // 
            this.txtSendPrintFullName_ret.Location = new System.Drawing.Point(408, 41);
            this.txtSendPrintFullName_ret.Name = "txtSendPrintFullName_ret";
            this.txtSendPrintFullName_ret.Size = new System.Drawing.Size(100, 20);
            this.txtSendPrintFullName_ret.TabIndex = 9;
            // 
            // lblSendPrintFullName_Ret
            // 
            this.lblSendPrintFullName_Ret.AutoSize = true;
            this.lblSendPrintFullName_Ret.Location = new System.Drawing.Point(342, 48);
            this.lblSendPrintFullName_Ret.Name = "lblSendPrintFullName_Ret";
            this.lblSendPrintFullName_Ret.Size = new System.Drawing.Size(52, 13);
            this.lblSendPrintFullName_Ret.TabIndex = 8;
            this.lblSendPrintFullName_Ret.Text = "Full name";
            // 
            // lblSendPrintCity
            // 
            this.lblSendPrintCity.AutoSize = true;
            this.lblSendPrintCity.Location = new System.Drawing.Point(13, 126);
            this.lblSendPrintCity.Name = "lblSendPrintCity";
            this.lblSendPrintCity.Size = new System.Drawing.Size(24, 13);
            this.lblSendPrintCity.TabIndex = 7;
            this.lblSendPrintCity.Text = "City";
            // 
            // lblSendPrintPostalCode
            // 
            this.lblSendPrintPostalCode.AutoSize = true;
            this.lblSendPrintPostalCode.Location = new System.Drawing.Point(13, 100);
            this.lblSendPrintPostalCode.Name = "lblSendPrintPostalCode";
            this.lblSendPrintPostalCode.Size = new System.Drawing.Size(63, 13);
            this.lblSendPrintPostalCode.TabIndex = 6;
            this.lblSendPrintPostalCode.Text = "Postal code";
            // 
            // lblSendPrint_Address
            // 
            this.lblSendPrint_Address.AutoSize = true;
            this.lblSendPrint_Address.Location = new System.Drawing.Point(13, 74);
            this.lblSendPrint_Address.Name = "lblSendPrint_Address";
            this.lblSendPrint_Address.Size = new System.Drawing.Size(45, 13);
            this.lblSendPrint_Address.TabIndex = 5;
            this.lblSendPrint_Address.Text = "Address";
            // 
            // txtSendPrintCity
            // 
            this.txtSendPrintCity.Location = new System.Drawing.Point(79, 119);
            this.txtSendPrintCity.Name = "txtSendPrintCity";
            this.txtSendPrintCity.Size = new System.Drawing.Size(100, 20);
            this.txtSendPrintCity.TabIndex = 4;
            // 
            // txtSendPrintPostalCode
            // 
            this.txtSendPrintPostalCode.Location = new System.Drawing.Point(79, 93);
            this.txtSendPrintPostalCode.Name = "txtSendPrintPostalCode";
            this.txtSendPrintPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtSendPrintPostalCode.TabIndex = 3;
            // 
            // txtSendPrintAddress
            // 
            this.txtSendPrintAddress.Location = new System.Drawing.Point(79, 67);
            this.txtSendPrintAddress.Name = "txtSendPrintAddress";
            this.txtSendPrintAddress.Size = new System.Drawing.Size(100, 20);
            this.txtSendPrintAddress.TabIndex = 2;
            // 
            // txtSendPrintFullName
            // 
            this.txtSendPrintFullName.Location = new System.Drawing.Point(79, 41);
            this.txtSendPrintFullName.Name = "txtSendPrintFullName";
            this.txtSendPrintFullName.Size = new System.Drawing.Size(100, 20);
            this.txtSendPrintFullName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name";
            // 
            // comboId
            // 
            this.comboId.FormattingEnabled = true;
            this.comboId.Location = new System.Drawing.Point(3, 9);
            this.comboId.Name = "comboId";
            this.comboId.Size = new System.Drawing.Size(121, 21);
            this.comboId.TabIndex = 9;
            // 
            // btn_send_createDocument
            // 
            this.btn_send_createDocument.Location = new System.Drawing.Point(357, 58);
            this.btn_send_createDocument.Name = "btn_send_createDocument";
            this.btn_send_createDocument.Size = new System.Drawing.Size(97, 23);
            this.btn_send_createDocument.TabIndex = 8;
            this.btn_send_createDocument.Text = "Create document";
            this.btn_send_createDocument.UseVisualStyleBackColor = true;
            this.btn_send_createDocument.Click += new System.EventHandler(this.btn_send_createDocument_Click);
            // 
            // txt_send_file
            // 
            this.txt_send_file.Location = new System.Drawing.Point(130, 62);
            this.txt_send_file.Name = "txt_send_file";
            this.txt_send_file.ReadOnly = true;
            this.txt_send_file.Size = new System.Drawing.Size(76, 20);
            this.txt_send_file.TabIndex = 7;
            this.txt_send_file.TextChanged += new System.EventHandler(this.txt_send_file_TextChanged);
            // 
            // txt_send_subject
            // 
            this.txt_send_subject.Location = new System.Drawing.Point(130, 36);
            this.txt_send_subject.Name = "txt_send_subject";
            this.txt_send_subject.Size = new System.Drawing.Size(208, 20);
            this.txt_send_subject.TabIndex = 5;
            // 
            // txt_send_digipostAddress
            // 
            this.txt_send_digipostAddress.Location = new System.Drawing.Point(130, 10);
            this.txt_send_digipostAddress.Name = "txt_send_digipostAddress";
            this.txt_send_digipostAddress.Size = new System.Drawing.Size(185, 20);
            this.txt_send_digipostAddress.TabIndex = 1;
            this.txt_send_digipostAddress.TextChanged += new System.EventHandler(this.txt_send_digipostAddress_TextChanged);
            // 
            // lbl_send_file
            // 
            this.lbl_send_file.AutoSize = true;
            this.lbl_send_file.Location = new System.Drawing.Point(101, 68);
            this.lbl_send_file.Name = "lbl_send_file";
            this.lbl_send_file.Size = new System.Drawing.Size(23, 13);
            this.lbl_send_file.TabIndex = 6;
            this.lbl_send_file.Text = "File";
            // 
            // lbl_send_subject
            // 
            this.lbl_send_subject.AutoSize = true;
            this.lbl_send_subject.Location = new System.Drawing.Point(81, 43);
            this.lbl_send_subject.Name = "lbl_send_subject";
            this.lbl_send_subject.Size = new System.Drawing.Size(43, 13);
            this.lbl_send_subject.TabIndex = 4;
            this.lbl_send_subject.Text = "Subject";
            // 
            // btn_send_send
            // 
            this.btn_send_send.Enabled = false;
            this.btn_send_send.Location = new System.Drawing.Point(591, 211);
            this.btn_send_send.Name = "btn_send_send";
            this.btn_send_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send_send.TabIndex = 3;
            this.btn_send_send.Text = "Send";
            this.btn_send_send.UseVisualStyleBackColor = true;
            this.btn_send_send.Click += new System.EventHandler(this.btn_send_send_Click);
            // 
            // btn_send_selectFile
            // 
            this.btn_send_selectFile.Location = new System.Drawing.Point(225, 59);
            this.btn_send_selectFile.Name = "btn_send_selectFile";
            this.btn_send_selectFile.Size = new System.Drawing.Size(126, 23);
            this.btn_send_selectFile.TabIndex = 2;
            this.btn_send_selectFile.Text = "Select file to send";
            this.btn_send_selectFile.UseVisualStyleBackColor = true;
            this.btn_send_selectFile.Click += new System.EventHandler(this.btn_send_selectFile_Click);
            // 
            // cbSendPrint
            // 
            this.cbSendPrint.AutoSize = true;
            this.cbSendPrint.Location = new System.Drawing.Point(31, 87);
            this.cbSendPrint.Name = "cbSendPrint";
            this.cbSendPrint.Size = new System.Drawing.Size(15, 14);
            this.cbSendPrint.TabIndex = 18;
            this.cbSendPrint.UseVisualStyleBackColor = true;
            this.cbSendPrint.CheckedChanged += new System.EventHandler(this.cbSendPrint_CheckedChanged);
            // 
            // TP_Search
            // 
            this.TP_Search.Controls.Add(this.btn_search_sendTo);
            this.TP_Search.Controls.Add(this.btn_search_moreInfo);
            this.TP_Search.Controls.Add(this.lbox_search_result);
            this.TP_Search.Controls.Add(this.txt_Search_searchString);
            this.TP_Search.Controls.Add(this.lbl_Search_searchString);
            this.TP_Search.Location = new System.Drawing.Point(4, 22);
            this.TP_Search.Name = "TP_Search";
            this.TP_Search.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Search.Size = new System.Drawing.Size(673, 259);
            this.TP_Search.TabIndex = 1;
            this.TP_Search.Text = "Search";
            this.TP_Search.UseVisualStyleBackColor = true;
            // 
            // btn_search_sendTo
            // 
            this.btn_search_sendTo.Enabled = false;
            this.btn_search_sendTo.Location = new System.Drawing.Point(94, 178);
            this.btn_search_sendTo.Name = "btn_search_sendTo";
            this.btn_search_sendTo.Size = new System.Drawing.Size(75, 23);
            this.btn_search_sendTo.TabIndex = 4;
            this.btn_search_sendTo.Text = "Send to";
            this.btn_search_sendTo.UseVisualStyleBackColor = true;
            this.btn_search_sendTo.Click += new System.EventHandler(this.btn_search_sendTo_Click);
            // 
            // btn_search_moreInfo
            // 
            this.btn_search_moreInfo.Enabled = false;
            this.btn_search_moreInfo.Location = new System.Drawing.Point(12, 178);
            this.btn_search_moreInfo.Name = "btn_search_moreInfo";
            this.btn_search_moreInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_search_moreInfo.TabIndex = 3;
            this.btn_search_moreInfo.Text = "More info";
            this.btn_search_moreInfo.UseVisualStyleBackColor = true;
            this.btn_search_moreInfo.Click += new System.EventHandler(this.btn_search_moreInfo_Click);
            // 
            // lbox_search_result
            // 
            this.lbox_search_result.FormattingEnabled = true;
            this.lbox_search_result.Location = new System.Drawing.Point(10, 67);
            this.lbox_search_result.Name = "lbox_search_result";
            this.lbox_search_result.Size = new System.Drawing.Size(656, 95);
            this.lbox_search_result.TabIndex = 2;
            this.lbox_search_result.SelectedIndexChanged += new System.EventHandler(this.lbox_search_result_SelectedIndexChanged);
            // 
            // txt_Search_searchString
            // 
            this.txt_Search_searchString.Location = new System.Drawing.Point(83, 14);
            this.txt_Search_searchString.Name = "txt_Search_searchString";
            this.txt_Search_searchString.Size = new System.Drawing.Size(247, 20);
            this.txt_Search_searchString.TabIndex = 1;
            this.txt_Search_searchString.TextChanged += new System.EventHandler(this.txt_Search_searchString_TextChanged);
            // 
            // lbl_Search_searchString
            // 
            this.lbl_Search_searchString.AutoSize = true;
            this.lbl_Search_searchString.Location = new System.Drawing.Point(7, 17);
            this.lbl_Search_searchString.Name = "lbl_Search_searchString";
            this.lbl_Search_searchString.Size = new System.Drawing.Size(70, 13);
            this.lbl_Search_searchString.TabIndex = 0;
            this.lbl_Search_searchString.Text = "Search query";
            // 
            // TabPanel
            // 
            this.TabPanel.Controls.Add(this.TP_Identify);
            this.TabPanel.Controls.Add(this.TP_Search);
            this.TabPanel.Controls.Add(this.TP_Send);
            this.TabPanel.Location = new System.Drawing.Point(2, 0);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.SelectedIndex = 0;
            this.TabPanel.Size = new System.Drawing.Size(681, 285);
            this.TabPanel.TabIndex = 3;
            // 
            // TP_Identify
            // 
            this.TP_Identify.Controls.Add(this.comboBoxIdentify);
            this.TP_Identify.Controls.Add(this.lbl_Identify_ssn);
            this.TP_Identify.Controls.Add(this.txt_identify_ssn);
            this.TP_Identify.Controls.Add(this.btnIdentify);
            this.TP_Identify.Location = new System.Drawing.Point(4, 22);
            this.TP_Identify.Name = "TP_Identify";
            this.TP_Identify.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Identify.Size = new System.Drawing.Size(673, 259);
            this.TP_Identify.TabIndex = 0;
            this.TP_Identify.Text = "Identify";
            this.TP_Identify.UseVisualStyleBackColor = true;
            // 
            // comboBoxIdentify
            // 
            this.comboBoxIdentify.FormattingEnabled = true;
            this.comboBoxIdentify.Location = new System.Drawing.Point(12, 17);
            this.comboBoxIdentify.Name = "comboBoxIdentify";
            this.comboBoxIdentify.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdentify.TabIndex = 3;
            // 
            // lbl_Identify_ssn
            // 
            this.lbl_Identify_ssn.AutoSize = true;
            this.lbl_Identify_ssn.Location = new System.Drawing.Point(6, 19);
            this.lbl_Identify_ssn.Name = "lbl_Identify_ssn";
            this.lbl_Identify_ssn.Size = new System.Drawing.Size(0, 13);
            this.lbl_Identify_ssn.TabIndex = 0;
            // 
            // txt_identify_ssn
            // 
            this.txt_identify_ssn.Location = new System.Drawing.Point(139, 18);
            this.txt_identify_ssn.Name = "txt_identify_ssn";
            this.txt_identify_ssn.Size = new System.Drawing.Size(100, 20);
            this.txt_identify_ssn.TabIndex = 1;
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(245, 17);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(75, 23);
            this.btnIdentify.TabIndex = 2;
            this.btnIdentify.Text = "Identify";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(635, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(48, 23);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // DigipostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabPanel);
            this.Name = "DigipostForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DigipostForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TP_Send.ResumeLayout(false);
            this.TP_Send.PerformLayout();
            this.gbSendPrint.ResumeLayout(false);
            this.gbSendPrint.PerformLayout();
            this.TP_Search.ResumeLayout(false);
            this.TP_Search.PerformLayout();
            this.TabPanel.ResumeLayout(false);
            this.TP_Identify.ResumeLayout(false);
            this.TP_Identify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_response_info;
        private System.Windows.Forms.RichTextBox rtf_response_text;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabPage TP_Send;
        private System.Windows.Forms.ComboBox comboId;
        private System.Windows.Forms.Button btn_send_createDocument;
        private System.Windows.Forms.TextBox txt_send_file;
        private System.Windows.Forms.TextBox txt_send_subject;
        private System.Windows.Forms.TextBox txt_send_digipostAddress;
        private System.Windows.Forms.Label lbl_send_file;
        private System.Windows.Forms.Label lbl_send_subject;
        private System.Windows.Forms.Button btn_send_send;
        private System.Windows.Forms.Button btn_send_selectFile;
        private System.Windows.Forms.TabPage TP_Search;
        private System.Windows.Forms.Button btn_search_sendTo;
        private System.Windows.Forms.Button btn_search_moreInfo;
        private System.Windows.Forms.ListBox lbox_search_result;
        private System.Windows.Forms.TextBox txt_Search_searchString;
        private System.Windows.Forms.Label lbl_Search_searchString;
        private System.Windows.Forms.TabControl TabPanel;
        private System.Windows.Forms.TabPage TP_Identify;
        private System.Windows.Forms.Label lbl_Identify_ssn;
        private System.Windows.Forms.TextBox txt_identify_ssn;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.ComboBox comboBoxIdentify;
        private System.Windows.Forms.GroupBox gbSendPrint;
        private System.Windows.Forms.CheckBox cbSendPrint;
        private System.Windows.Forms.Label lblSendPrintFrom;
        private System.Windows.Forms.Label lblSendPrintTO;
        private System.Windows.Forms.Label lblSendPrintCity_Ret;
        private System.Windows.Forms.Label lblSendPrintPostalCode_Ret;
        private System.Windows.Forms.Label lblSendPrintAddress_Ret;
        private System.Windows.Forms.TextBox txtSendPrintCity_Ret;
        private System.Windows.Forms.TextBox txtSendPrintPostalCode_Ret;
        private System.Windows.Forms.TextBox txtSendPrintAddress_Ret;
        private System.Windows.Forms.TextBox txtSendPrintFullName_ret;
        private System.Windows.Forms.Label lblSendPrintFullName_Ret;
        private System.Windows.Forms.Label lblSendPrintCity;
        private System.Windows.Forms.Label lblSendPrintPostalCode;
        private System.Windows.Forms.Label lblSendPrint_Address;
        private System.Windows.Forms.TextBox txtSendPrintCity;
        private System.Windows.Forms.TextBox txtSendPrintPostalCode;
        private System.Windows.Forms.TextBox txtSendPrintAddress;
        private System.Windows.Forms.TextBox txtSendPrintFullName;
        private System.Windows.Forms.Label label1;
    }
}