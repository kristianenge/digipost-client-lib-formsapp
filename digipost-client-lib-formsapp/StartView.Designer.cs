namespace digipost_client_lib_formsapp
{
    partial class StartView
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
            this.btnSendOne = new System.Windows.Forms.Button();
            this.btnSendMany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendOne
            // 
            this.btnSendOne.Location = new System.Drawing.Point(13, 12);
            this.btnSendOne.Name = "btnSendOne";
            this.btnSendOne.Size = new System.Drawing.Size(259, 24);
            this.btnSendOne.TabIndex = 0;
            this.btnSendOne.Text = "Send to one person";
            this.btnSendOne.UseVisualStyleBackColor = true;
            this.btnSendOne.Click += new System.EventHandler(this.btnSendOne_Click);
            // 
            // btnSendMany
            // 
            this.btnSendMany.Location = new System.Drawing.Point(13, 52);
            this.btnSendMany.Name = "btnSendMany";
            this.btnSendMany.Size = new System.Drawing.Size(259, 24);
            this.btnSendMany.TabIndex = 1;
            this.btnSendMany.Text = "Send to many";
            this.btnSendMany.UseVisualStyleBackColor = true;
            this.btnSendMany.Click += new System.EventHandler(this.btnSendMany_Click);
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSendMany);
            this.Controls.Add(this.btnSendOne);
            this.Name = "StartView";
            this.Text = "StartView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendOne;
        private System.Windows.Forms.Button btnSendMany;
    }
}