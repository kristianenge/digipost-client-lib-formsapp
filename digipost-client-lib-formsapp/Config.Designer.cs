namespace digipost_client_lib_formsapp
{
    partial class Config
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
            this.btn_config_update = new System.Windows.Forms.Button();
            this.txt_config_thumbprint = new System.Windows.Forms.TextBox();
            this.lbl_config_thumbrint = new System.Windows.Forms.Label();
            this.txt_config_url = new System.Windows.Forms.TextBox();
            this.lbl_config_url = new System.Windows.Forms.Label();
            this.txt_config_technicalID = new System.Windows.Forms.TextBox();
            this.lbl_conf_technicalID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_config_update
            // 
            this.btn_config_update.Location = new System.Drawing.Point(195, 177);
            this.btn_config_update.Name = "btn_config_update";
            this.btn_config_update.Size = new System.Drawing.Size(75, 23);
            this.btn_config_update.TabIndex = 13;
            this.btn_config_update.Text = "Update";
            this.btn_config_update.UseVisualStyleBackColor = true;
            this.btn_config_update.Click += new System.EventHandler(this.btn_config_update_Click);
            // 
            // txt_config_thumbprint
            // 
            this.txt_config_thumbprint.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::digipost_client_lib_formsapp.Properties.Settings.Default, "thumbprint", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_config_thumbprint.Location = new System.Drawing.Point(119, 59);
            this.txt_config_thumbprint.Name = "txt_config_thumbprint";
            this.txt_config_thumbprint.Size = new System.Drawing.Size(100, 20);
            this.txt_config_thumbprint.TabIndex = 12;
            this.txt_config_thumbprint.Text = global::digipost_client_lib_formsapp.Properties.Settings.Default.thumbprint;
            // 
            // lbl_config_thumbrint
            // 
            this.lbl_config_thumbrint.AutoSize = true;
            this.lbl_config_thumbrint.Location = new System.Drawing.Point(12, 66);
            this.lbl_config_thumbrint.Name = "lbl_config_thumbrint";
            this.lbl_config_thumbrint.Size = new System.Drawing.Size(60, 13);
            this.lbl_config_thumbrint.TabIndex = 11;
            this.lbl_config_thumbrint.Text = "Thumbprint";
            // 
            // txt_config_url
            // 
            this.txt_config_url.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::digipost_client_lib_formsapp.Properties.Settings.Default, "url", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_config_url.Location = new System.Drawing.Point(119, 33);
            this.txt_config_url.Name = "txt_config_url";
            this.txt_config_url.Size = new System.Drawing.Size(151, 20);
            this.txt_config_url.TabIndex = 10;
            this.txt_config_url.Text = global::digipost_client_lib_formsapp.Properties.Settings.Default.url;
            // 
            // lbl_config_url
            // 
            this.lbl_config_url.AutoSize = true;
            this.lbl_config_url.Location = new System.Drawing.Point(12, 40);
            this.lbl_config_url.Name = "lbl_config_url";
            this.lbl_config_url.Size = new System.Drawing.Size(20, 13);
            this.lbl_config_url.TabIndex = 9;
            this.lbl_config_url.Text = "Url";
            // 
            // txt_config_technicalID
            // 
            this.txt_config_technicalID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::digipost_client_lib_formsapp.Properties.Settings.Default, "technicalID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_config_technicalID.Location = new System.Drawing.Point(119, 8);
            this.txt_config_technicalID.Name = "txt_config_technicalID";
            this.txt_config_technicalID.Size = new System.Drawing.Size(100, 20);
            this.txt_config_technicalID.TabIndex = 8;
            this.txt_config_technicalID.Text = global::digipost_client_lib_formsapp.Properties.Settings.Default.technicalID;
            // 
            // lbl_conf_technicalID
            // 
            this.lbl_conf_technicalID.AutoSize = true;
            this.lbl_conf_technicalID.Location = new System.Drawing.Point(12, 9);
            this.lbl_conf_technicalID.Name = "lbl_conf_technicalID";
            this.lbl_conf_technicalID.Size = new System.Drawing.Size(101, 13);
            this.lbl_conf_technicalID.TabIndex = 7;
            this.lbl_conf_technicalID.Text = "Technical sender Id";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 222);
            this.Controls.Add(this.btn_config_update);
            this.Controls.Add(this.txt_config_thumbprint);
            this.Controls.Add(this.lbl_config_thumbrint);
            this.Controls.Add(this.txt_config_url);
            this.Controls.Add(this.lbl_config_url);
            this.Controls.Add(this.txt_config_technicalID);
            this.Controls.Add(this.lbl_conf_technicalID);
            this.Name = "Config";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_config_update;
        private System.Windows.Forms.TextBox txt_config_thumbprint;
        private System.Windows.Forms.Label lbl_config_thumbrint;
        private System.Windows.Forms.TextBox txt_config_url;
        private System.Windows.Forms.Label lbl_config_url;
        private System.Windows.Forms.TextBox txt_config_technicalID;
        private System.Windows.Forms.Label lbl_conf_technicalID;
    }
}