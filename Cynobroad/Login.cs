using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cynobroad
{
    public partial class Login : Form
    {
        private string username = "";

        public string Username
        {
            get { return username; }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            username = Input_Username.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username must be up to 32 characters and cannot be null.");
                return;
            }

            Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            username = "";
        }
    }
}
