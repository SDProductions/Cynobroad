using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cynobroad
{
    public partial class Login : Form
    {
        internal string Username = "";
        internal string ServerIP = "";
        internal bool IsSelfHost = false;
        private bool verifiedAccept = false;

        private bool mouseDown;
        private Point lastLocation;

        public Login()
        {
            InitializeComponent();
        }

        private void ControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ControlBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void ControlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X,
                                     (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            obj.BackColor = Color.FromArgb(69, 77, 117);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Control obj = (Control)sender;
            obj.BackColor = Color.FromArgb(52, 57, 83);
        }

        private void Input_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Input_ServerIP.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Input_ServerIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Accept_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            Username = Input_Username.Text.Trim();
            ServerIP = Input_ServerIP.Text.Trim();

            if (string.IsNullOrEmpty(Username))
            {
                MessageBox.Show("Username must be up to 24 characters and cannot be null.");
                return;
            }
            if (Username.Contains(">"))
            {
                MessageBox.Show("'>' is forbidden within the username.");
                return;
            }
            if ((string.IsNullOrEmpty(ServerIP) || !ServerIP.Contains(".")) && !IsSelfHost)
            {
                MessageBox.Show("Please specify an IPv4 server address.");
                return;
            }

            verifiedAccept = true;
            Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!verifiedAccept)
                Username = "";
        }

        private void Window_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HostServerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HostServerCheck.Checked)
            {
                IsSelfHost = true;
                Input_ServerIP.ReadOnly = true;
                Input_ServerIP.Text = "";
            }
            else
            {
                IsSelfHost = false;
                Input_ServerIP.ReadOnly = false;
            }
        }
    }
}
