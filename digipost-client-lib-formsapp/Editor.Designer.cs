namespace digipost_client_lib_formsapp
{
    partial class Editor
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
            this.rtb_editor_input = new System.Windows.Forms.RichTextBox();
            this.btn_editor_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_editor_input
            // 
            this.rtb_editor_input.Location = new System.Drawing.Point(12, 12);
            this.rtb_editor_input.Name = "rtb_editor_input";
            this.rtb_editor_input.Size = new System.Drawing.Size(260, 205);
            this.rtb_editor_input.TabIndex = 0;
            this.rtb_editor_input.Text = "";
            // 
            // btn_editor_ok
            // 
            this.btn_editor_ok.Location = new System.Drawing.Point(100, 223);
            this.btn_editor_ok.Name = "btn_editor_ok";
            this.btn_editor_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_editor_ok.TabIndex = 1;
            this.btn_editor_ok.Text = "Done!";
            this.btn_editor_ok.UseVisualStyleBackColor = true;
            this.btn_editor_ok.Click += new System.EventHandler(this.btn_editor_ok_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_editor_ok);
            this.Controls.Add(this.rtb_editor_input);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editor";
            this.Text = "Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_editor_input;
        private System.Windows.Forms.Button btn_editor_ok;
    }
}