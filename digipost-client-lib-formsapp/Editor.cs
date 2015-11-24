using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digipost_client_lib_formsapp
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void btn_editor_ok_Click(object sender, EventArgs e)
        {
            
            Close();
        }

       
    }
}
