namespace digipost_client_lib_formsapp
{
    partial class BatchForm
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
            this.fileDialogBatch = new System.Windows.Forms.OpenFileDialog();
            this.txt_send_file = new System.Windows.Forms.TextBox();
            this.lbl_send_file = new System.Windows.Forms.Label();
            this.btn_send_selectFile = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.pnlMapping = new System.Windows.Forms.FlowLayoutPanel();
            this.cbHeader = new System.Windows.Forms.CheckBox();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.rbFullNameAndAddress = new System.Windows.Forms.RadioButton();
            this.gbIdentifyBy = new System.Windows.Forms.GroupBox();
            this.rbSSN = new System.Windows.Forms.RadioButton();
            this.rbDigipostAddress = new System.Windows.Forms.RadioButton();
            this.pnlSplitt = new System.Windows.Forms.Panel();
            this.lblSplittCell = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ddlSplittcolumn = new System.Windows.Forms.ComboBox();
            this.btnSplitt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbIdentifyBy.SuspendLayout();
            this.pnlSplitt.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileDialogBatch
            // 
            this.fileDialogBatch.FileName = "openFileDialog1";
            // 
            // txt_send_file
            // 
            this.txt_send_file.Location = new System.Drawing.Point(64, 18);
            this.txt_send_file.Name = "txt_send_file";
            this.txt_send_file.ReadOnly = true;
            this.txt_send_file.Size = new System.Drawing.Size(175, 20);
            this.txt_send_file.TabIndex = 10;
            // 
            // lbl_send_file
            // 
            this.lbl_send_file.AutoSize = true;
            this.lbl_send_file.Location = new System.Drawing.Point(5, 21);
            this.lbl_send_file.Name = "lbl_send_file";
            this.lbl_send_file.Size = new System.Drawing.Size(23, 13);
            this.lbl_send_file.TabIndex = 9;
            this.lbl_send_file.Text = "File";
            // 
            // btn_send_selectFile
            // 
            this.btn_send_selectFile.Location = new System.Drawing.Point(344, 18);
            this.btn_send_selectFile.Name = "btn_send_selectFile";
            this.btn_send_selectFile.Size = new System.Drawing.Size(126, 23);
            this.btn_send_selectFile.TabIndex = 8;
            this.btn_send_selectFile.Text = "Select data file";
            this.btn_send_selectFile.UseVisualStyleBackColor = true;
            this.btn_send_selectFile.Click += new System.EventHandler(this.btn_send_selectFile_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 266);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1148, 150);
            this.dgv.TabIndex = 11;
            // 
            // txtSeparator
            // 
            this.txtSeparator.Location = new System.Drawing.Point(64, 47);
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(18, 20);
            this.txtSeparator.TabIndex = 12;
            this.txtSeparator.Text = ";";
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(5, 54);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(53, 13);
            this.lblSeparator.TabIndex = 13;
            this.lblSeparator.Text = "Separator";
            // 
            // pnlMapping
            // 
            this.pnlMapping.Location = new System.Drawing.Point(13, 136);
            this.pnlMapping.Name = "pnlMapping";
            this.pnlMapping.Size = new System.Drawing.Size(1147, 124);
            this.pnlMapping.TabIndex = 14;
            // 
            // cbHeader
            // 
            this.cbHeader.AutoSize = true;
            this.cbHeader.Checked = true;
            this.cbHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHeader.Location = new System.Drawing.Point(246, 20);
            this.cbHeader.Name = "cbHeader";
            this.cbHeader.Size = new System.Drawing.Size(81, 17);
            this.cbHeader.TabIndex = 15;
            this.cbHeader.Text = "Has header";
            this.cbHeader.UseVisualStyleBackColor = true;
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(13, 423);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(75, 23);
            this.btnIdentify.TabIndex = 17;
            this.btnIdentify.Text = "Identify all";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // rbFullNameAndAddress
            // 
            this.rbFullNameAndAddress.AutoSize = true;
            this.rbFullNameAndAddress.Location = new System.Drawing.Point(9, 19);
            this.rbFullNameAndAddress.Name = "rbFullNameAndAddress";
            this.rbFullNameAndAddress.Size = new System.Drawing.Size(131, 17);
            this.rbFullNameAndAddress.TabIndex = 18;
            this.rbFullNameAndAddress.TabStop = true;
            this.rbFullNameAndAddress.Text = "Full name and address";
            this.rbFullNameAndAddress.UseVisualStyleBackColor = true;
            this.rbFullNameAndAddress.CheckedChanged += new System.EventHandler(this.rbFullNameAndAddress_CheckedChanged);
            // 
            // gbIdentifyBy
            // 
            this.gbIdentifyBy.Controls.Add(this.rbDigipostAddress);
            this.gbIdentifyBy.Controls.Add(this.rbSSN);
            this.gbIdentifyBy.Controls.Add(this.rbFullNameAndAddress);
            this.gbIdentifyBy.Location = new System.Drawing.Point(13, 84);
            this.gbIdentifyBy.Name = "gbIdentifyBy";
            this.gbIdentifyBy.Size = new System.Drawing.Size(407, 46);
            this.gbIdentifyBy.TabIndex = 19;
            this.gbIdentifyBy.TabStop = false;
            this.gbIdentifyBy.Text = "Identify by";
            // 
            // rbSSN
            // 
            this.rbSSN.AutoSize = true;
            this.rbSSN.Location = new System.Drawing.Point(146, 19);
            this.rbSSN.Name = "rbSSN";
            this.rbSSN.Size = new System.Drawing.Size(131, 17);
            this.rbSSN.TabIndex = 19;
            this.rbSSN.TabStop = true;
            this.rbSSN.Text = "Social security number";
            this.rbSSN.UseVisualStyleBackColor = true;
            this.rbSSN.CheckedChanged += new System.EventHandler(this.rbSSN_CheckedChanged);
            // 
            // rbDigipostAddress
            // 
            this.rbDigipostAddress.AutoSize = true;
            this.rbDigipostAddress.Location = new System.Drawing.Point(279, 19);
            this.rbDigipostAddress.Name = "rbDigipostAddress";
            this.rbDigipostAddress.Size = new System.Drawing.Size(103, 17);
            this.rbDigipostAddress.TabIndex = 20;
            this.rbDigipostAddress.TabStop = true;
            this.rbDigipostAddress.Text = "Digipost address";
            this.rbDigipostAddress.UseVisualStyleBackColor = true;
            this.rbDigipostAddress.CheckedChanged += new System.EventHandler(this.rbDigipostAddress_CheckedChanged);
            // 
            // pnlSplitt
            // 
            this.pnlSplitt.Controls.Add(this.btnSplitt);
            this.pnlSplitt.Controls.Add(this.ddlSplittcolumn);
            this.pnlSplitt.Controls.Add(this.textBox1);
            this.pnlSplitt.Controls.Add(this.lblSplittCell);
            this.pnlSplitt.Location = new System.Drawing.Point(610, 36);
            this.pnlSplitt.Name = "pnlSplitt";
            this.pnlSplitt.Size = new System.Drawing.Size(394, 48);
            this.pnlSplitt.TabIndex = 20;
            // 
            // lblSplittCell
            // 
            this.lblSplittCell.AutoSize = true;
            this.lblSplittCell.Location = new System.Drawing.Point(4, 24);
            this.lblSplittCell.Name = "lblSplittCell";
            this.lblSplittCell.Size = new System.Drawing.Size(49, 13);
            this.lblSplittCell.TabIndex = 0;
            this.lblSplittCell.Text = "Splitt cell";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ddlSplittcolumn
            // 
            this.ddlSplittcolumn.FormattingEnabled = true;
            this.ddlSplittcolumn.Location = new System.Drawing.Point(162, 21);
            this.ddlSplittcolumn.Name = "ddlSplittcolumn";
            this.ddlSplittcolumn.Size = new System.Drawing.Size(121, 21);
            this.ddlSplittcolumn.TabIndex = 2;
            // 
            // btnSplitt
            // 
            this.btnSplitt.Location = new System.Drawing.Point(289, 21);
            this.btnSplitt.Name = "btnSplitt";
            this.btnSplitt.Size = new System.Drawing.Size(75, 23);
            this.btnSplitt.TabIndex = 3;
            this.btnSplitt.Text = "Splitt";
            this.btnSplitt.UseVisualStyleBackColor = true;
            this.btnSplitt.Click += new System.EventHandler(this.btnSplitt_Click);
            // 
            // BatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 487);
            this.Controls.Add(this.pnlSplitt);
            this.Controls.Add(this.gbIdentifyBy);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.cbHeader);
            this.Controls.Add(this.pnlMapping);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.txtSeparator);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txt_send_file);
            this.Controls.Add(this.lbl_send_file);
            this.Controls.Add(this.btn_send_selectFile);
            this.Name = "BatchForm";
            this.Text = "BatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbIdentifyBy.ResumeLayout(false);
            this.gbIdentifyBy.PerformLayout();
            this.pnlSplitt.ResumeLayout(false);
            this.pnlSplitt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileDialogBatch;
        private System.Windows.Forms.TextBox txt_send_file;
        private System.Windows.Forms.Label lbl_send_file;
        private System.Windows.Forms.Button btn_send_selectFile;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.FlowLayoutPanel pnlMapping;
        private System.Windows.Forms.CheckBox cbHeader;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.RadioButton rbFullNameAndAddress;
        private System.Windows.Forms.GroupBox gbIdentifyBy;
        private System.Windows.Forms.RadioButton rbDigipostAddress;
        private System.Windows.Forms.RadioButton rbSSN;
        private System.Windows.Forms.Panel pnlSplitt;
        private System.Windows.Forms.Button btnSplitt;
        private System.Windows.Forms.ComboBox ddlSplittcolumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSplittCell;
    }
}