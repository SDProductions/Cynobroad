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
        private string serverIP = "";
        private bool verifiedAccept = false;

        public string Username
        {
            get { return username; }
        }

        public string ServerIP
        {
            get { return serverIP; }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            username = Input_Username.Text.Trim();
            serverIP = Input_ServerIP.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username must be up to 32 characters and cannot be null.");
                return;
            }

            verifiedAccept = true;
            Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!verifiedAccept)
                username = "";
        }

        private void Window_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
