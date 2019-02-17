using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cynobroad
{
    public partial class Login : Form
    {
        private string username = "";
        private string serverIP = "";
        private bool isSelfHost = false;
        private bool verifiedAccept = false;

        private bool mouseDown;
        private Point lastLocation;

        public string Username
        { get { return username; } }

        public string ServerIP
        { get { return serverIP; } }

        public bool IsSelfHost
        { get { return isSelfHost; } }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Rectangle screenRes = Screen.PrimaryScreen.Bounds;
            float scaleFactor = Height / screenRes.Height * 1080;
            SizeF scale = new SizeF(scaleFactor, scaleFactor);
            Scale(scale);
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
                this.Location = new Point((Location.X - lastLocation.X) + e.X,
                                          (Location.Y - lastLocation.Y) + e.Y);
                this.Update();
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
            username = Input_Username.Text.Trim();
            serverIP = Input_ServerIP.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username must be up to 24 characters and cannot be null.");
                return;
            }
            if (username.Contains(">"))
            {
                MessageBox.Show("'>' is forbidden within the username.");
                return;
            }
            if ((string.IsNullOrEmpty(serverIP) || !serverIP.Contains(".")) && !isSelfHost)
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
                username = "";
        }

        private void Window_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HostServerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (HostServerCheck.Checked)
            {
                isSelfHost = true;
                Input_ServerIP.ReadOnly = true;
                Input_ServerIP.Text = "";
            }
            else
            {
                isSelfHost = false;
                Input_ServerIP.ReadOnly = false;
            }
        }
    }
}
