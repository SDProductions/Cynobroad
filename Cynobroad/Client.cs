using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string username;
        private int port = 42069;
        private string serverIP = "";

        private Thread receivingThread;
        private Thread sendingThread;
        private TcpClient _client = new TcpClient();
        private StreamReader _sReader;
        private StreamWriter _sWriter;

        private ConcurrentQueue<string> messageQueue = new ConcurrentQueue<string>();
        public ConcurrentQueue<string> MessageQueue
        {
            get { return messageQueue; }
        }

        delegate void AddMsg(string msg);

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

                if (string.IsNullOrEmpty(login.Username) || string.IsNullOrEmpty(login.ServerIP))
                {
                    this.Close();
                }
                else
                {
                    username = login.Username;
                    serverIP = login.ServerIP;
                    this.Show();

                    InitializeConnection();

                    SendMsgBox.Focus();
                }
            }
        }

        private void InitializeConnection()
        {
            _client.Connect(serverIP, port);
            _sWriter = new StreamWriter(_client.GetStream(), Encoding.ASCII);
            _sReader = new StreamReader(_client.GetStream(), Encoding.ASCII);

            messageQueue = new ConcurrentQueue<string>();

            ThreadStart startReceiver = new ThreadStart(HandleReceiver);
            receivingThread = new Thread(startReceiver);
            receivingThread.IsBackground = true;
            receivingThread.Start();

            ThreadStart startSender = new ThreadStart(HandleSender);
            sendingThread = new Thread(startSender);
            sendingThread.IsBackground = true;
            sendingThread.Start();
        }

        private void HandleReceiver()
        {
            AddMsg addMsg = MessageReceived;

            _sWriter.WriteLine($"join://{username}");
            _sWriter.Flush();

            while (true)
            {
                string readString = _sReader.ReadLine();
                Invoke(addMsg, readString);
            }
        }

        private void HandleSender()
        {
            while (true)
            {
                if (!MessageQueue.IsEmpty)
                {
                    foreach (string msg in MessageQueue)
                    {
                        MessageQueue.TryDequeue(out string str);
                        _sWriter.WriteLine(msg);
                        _sWriter.Flush();
                    }
                }
            }
        }

        private void MessageReceived(string msg)
        {
            ChatDisplay.Text += msg + "\n";
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Control button = (Control)sender;
            button.BackColor = Color.FromArgb(30, 35, 45);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Control button = (Control)sender;
            button.BackColor = Color.FromArgb(20, 25, 35);
        }

        private void Window_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Window_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            messageQueue.Enqueue("close://" + username);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            SendMsgBox.Text = SendMsgBox.Text.TrimEnd();

            messageQueue.Enqueue($"send://{username}: {SendMsgBox.Text}");

            SendMsgBox.Text = "";
            SendMsgBox.Focus();
        }
    }
}
