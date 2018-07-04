using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cynobroad
{
    public partial class Client : Form
    {
        const int port = 42069;
        const string broadcastAddress = "255.255.255.255";

        UdpClient receivingClient;
        UdpClient sendingClient;

        Thread receivingThread;

        delegate void AddMsg(string msg);

        string username;

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            Hide();

            using (Login login = new Login())
            {
                login.ShowDialog();

                if (login.Username == "")
                {
                    this.Close();
                }
                else
                {
                    username = login.Username;
                    this.Show();
                }

                SendMsgBox.Focus();

                InitializeSender();
                InitializeReceiver();
            }
        }

        private void InitializeSender()
        {
            sendingClient = new UdpClient(broadcastAddress, port)
            {
                EnableBroadcast = true
            };
        }

        private void InitializeReceiver()
        {
            receivingClient = new UdpClient(port);

            ThreadStart start = new ThreadStart(Receiver);
            receivingThread = new Thread(start)
            {
                IsBackground = true
            };
            receivingThread.Start();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            SendMsgBox.Text = SendMsgBox.Text.TrimEnd();

            if (!string.IsNullOrEmpty(SendMsgBox.Text))
            {
                string toSend = username + ":\n" + SendMsgBox.Text;
                byte[] data = Encoding.ASCII.GetBytes(toSend);
                sendingClient.Send(data, data.Length);
                SendMsgBox.Text = "";
            }

            SendMsgBox.Focus();
        }

        private void Receiver()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
            AddMsg msgDelegate = MessageReceived;

            while (true)
            {
                byte[] data = receivingClient.Receive(ref endPoint);
                string msg = Encoding.ASCII.GetString(data);
                Invoke(msgDelegate, msg);
            }
        }

        private void MessageReceived(string msg)
        {
            ChatDisplay.Text += msg + "\n";
        }
    }
}
