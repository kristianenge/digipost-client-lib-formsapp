using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace digipost_client_lib_formsapp
{
    public partial class StartView : Form
    {
        public StartView()
        {
            InitializeComponent();
        }

        private void btnSendOne_Click(object sender, EventArgs e)
        {
            var digipostForm = new DigipostForm();
            digipostForm.Closing += ChildFormClosing;
            digipostForm.Show();
            this.Hide();
        }


        private void btnSendMany_Click(object sender, EventArgs e)
        {
            var batchForm = new BatchForm();
            batchForm.Closing += ChildFormClosing;
            batchForm.Show();
            this.Hide();
        }


        private void ChildFormClosing(object sender, CancelEventArgs e)
        {
            this.Show();
        }
    }
}
