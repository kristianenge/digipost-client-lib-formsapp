﻿namespace digipost_client_lib_formsapp
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
            this.comboId = new System.Windows.Forms.ComboBox();
            this.btn_send_createDocument = new System.Windows.Forms.Button();
            this.txt_send_file = new System.Windows.Forms.TextBox();
            this.txt_send_subject = new System.Windows.Forms.TextBox();
            this.txt_send_digipostAddress = new System.Windows.Forms.TextBox();
            this.lbl_send_file = new System.Windows.Forms.Label();
            this.lbl_send_subject = new System.Windows.Forms.Label();
            this.btn_send_send = new System.Windows.Forms.Button();
            this.btn_send_selectFile = new System.Windows.Forms.Button();
            this.TP_Search = new System.Windows.Forms.TabPage();
            this.btn_search_sendTo = new System.Windows.Forms.Button();
            this.btn_search_moreInfo = new System.Windows.Forms.Button();
            this.lbox_search_result = new System.Windows.Forms.ListBox();
            this.txt_Search_searchString = new System.Windows.Forms.TextBox();
            this.lbl_Search_searchString = new System.Windows.Forms.Label();
            this.TabPanel = new System.Windows.Forms.TabControl();
            this.TP_Identify = new System.Windows.Forms.TabPage();
            this.lbl_Identify_ssn = new System.Windows.Forms.Label();
            this.txt_identify_ssn = new System.Windows.Forms.TextBox();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.TP_Send.SuspendLayout();
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
            this.TP_Send.Size = new System.Drawing.Size(673, 237);
            this.TP_Send.TabIndex = 2;
            this.TP_Send.Text = "Send";
            this.TP_Send.UseVisualStyleBackColor = true;
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
            this.btn_send_createDocument.Location = new System.Drawing.Point(333, 97);
            this.btn_send_createDocument.Name = "btn_send_createDocument";
            this.btn_send_createDocument.Size = new System.Drawing.Size(97, 23);
            this.btn_send_createDocument.TabIndex = 8;
            this.btn_send_createDocument.Text = "Create document";
            this.btn_send_createDocument.UseVisualStyleBackColor = true;
            this.btn_send_createDocument.Click += new System.EventHandler(this.btn_send_createDocument_Click);
            // 
            // txt_send_file
            // 
            this.txt_send_file.Location = new System.Drawing.Point(107, 101);
            this.txt_send_file.Name = "txt_send_file";
            this.txt_send_file.ReadOnly = true;
            this.txt_send_file.Size = new System.Drawing.Size(76, 20);
            this.txt_send_file.TabIndex = 7;
            this.txt_send_file.TextChanged += new System.EventHandler(this.txt_send_file_TextChanged);
            // 
            // txt_send_subject
            // 
            this.txt_send_subject.Location = new System.Drawing.Point(107, 38);
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
            this.lbl_send_file.Location = new System.Drawing.Point(15, 107);
            this.lbl_send_file.Name = "lbl_send_file";
            this.lbl_send_file.Size = new System.Drawing.Size(23, 13);
            this.lbl_send_file.TabIndex = 6;
            this.lbl_send_file.Text = "File";
            // 
            // lbl_send_subject
            // 
            this.lbl_send_subject.AutoSize = true;
            this.lbl_send_subject.Location = new System.Drawing.Point(12, 38);
            this.lbl_send_subject.Name = "lbl_send_subject";
            this.lbl_send_subject.Size = new System.Drawing.Size(43, 13);
            this.lbl_send_subject.TabIndex = 4;
            this.lbl_send_subject.Text = "Subject";
            // 
            // btn_send_send
            // 
            this.btn_send_send.Enabled = false;
            this.btn_send_send.Location = new System.Drawing.Point(15, 137);
            this.btn_send_send.Name = "btn_send_send";
            this.btn_send_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send_send.TabIndex = 3;
            this.btn_send_send.Text = "Send";
            this.btn_send_send.UseVisualStyleBackColor = true;
            this.btn_send_send.Click += new System.EventHandler(this.btn_send_send_Click);
            // 
            // btn_send_selectFile
            // 
            this.btn_send_selectFile.Location = new System.Drawing.Point(201, 98);
            this.btn_send_selectFile.Name = "btn_send_selectFile";
            this.btn_send_selectFile.Size = new System.Drawing.Size(126, 23);
            this.btn_send_selectFile.TabIndex = 2;
            this.btn_send_selectFile.Text = "Select file to send";
            this.btn_send_selectFile.UseVisualStyleBackColor = true;
            this.btn_send_selectFile.Click += new System.EventHandler(this.btn_send_selectFile_Click);
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
            this.TP_Search.Size = new System.Drawing.Size(673, 237);
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
            this.TabPanel.Size = new System.Drawing.Size(681, 263);
            this.TabPanel.TabIndex = 3;
            // 
            // TP_Identify
            // 
            this.TP_Identify.Controls.Add(this.lbl_Identify_ssn);
            this.TP_Identify.Controls.Add(this.txt_identify_ssn);
            this.TP_Identify.Controls.Add(this.btnIdentify);
            this.TP_Identify.Location = new System.Drawing.Point(4, 22);
            this.TP_Identify.Name = "TP_Identify";
            this.TP_Identify.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Identify.Size = new System.Drawing.Size(673, 237);
            this.TP_Identify.TabIndex = 0;
            this.TP_Identify.Text = "Identify";
            this.TP_Identify.UseVisualStyleBackColor = true;
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
            this.txt_identify_ssn.Location = new System.Drawing.Point(12, 16);
            this.txt_identify_ssn.Name = "txt_identify_ssn";
            this.txt_identify_ssn.Size = new System.Drawing.Size(100, 20);
            this.txt_identify_ssn.TabIndex = 1;
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(158, 16);
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
    }
}