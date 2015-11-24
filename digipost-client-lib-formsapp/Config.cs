using System;
using System.Windows.Forms;

namespace digipost_client_lib_formsapp
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void btn_config_update_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
