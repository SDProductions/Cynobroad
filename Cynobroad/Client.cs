﻿using System;
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
        private TcpClient _client;
        private StreamReader _sReader;
        private StreamWriter _sWriter;

        private bool isConnected = false;

        private List<string> connectedUsers = new List<string>();
        private ConcurrentQueue<string> messageQueue = new ConcurrentQueue<string>();
        public ConcurrentQueue<string> MessageQueue
        {
            get { return messageQueue; }
        }

        private bool mouseDown;
        private Point lastLocation;

        delegate void AddMsg(string msg);
        delegate void AddUserBlock(ConnectedUserBlock userBlock);
        delegate void RemoveUserBlock(ConnectedUserBlock userBlock);

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            Hide();

            Rectangle screenRes = Screen.PrimaryScreen.Bounds;
            float scaleFactor = Height / screenRes.Height * 1080;
            SizeF scale = new SizeF(scaleFactor, scaleFactor);
            Scale(scale);

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

                    User_UsernameLabel.Text = username;
                    User_ConnectedServer.Text = serverIP;
                    this.Show();

                    try
                    {
                        _client = new TcpClient();
                        InitializeConnection();
                        isConnected = true;
                    }
                    catch
                    {
                        isConnected = false;
                    }

                    SendMsgBox.Focus();
                }
            }

            if (!isConnected)
            {
                User_ConnectionStatus.BackColor = Color.OrangeRed;
            }
            else
            {
                User_ConnectionStatus.BackColor = Color.LawnGreen;
            }
        }

        private void InitializeConnection()
        {
            _client.Connect(serverIP, port);
            _sWriter = new StreamWriter(_client.GetStream(), Encoding.ASCII);
            _sReader = new StreamReader(_client.GetStream(), Encoding.ASCII);

            messageQueue = new ConcurrentQueue<string>();

            ThreadStart startReceiver = new ThreadStart(HandleReceiver);
            receivingThread = new Thread(startReceiver)
            {
                IsBackground = true
            };
            receivingThread.Start();

            ThreadStart startSender = new ThreadStart(HandleSender);
            sendingThread = new Thread(startSender)
            {
                IsBackground = true
            };
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
                if (readString.StartsWith("post://"))
                {
                    readString = readString.Substring(7);
                }
                else
                {
                    Invoke(addMsg, readString);
                }
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

        private void AddUser(ConnectedUserBlock userBlock)
        {
            Panel_ConnectedUsersList.Controls.Add(userBlock);
        }

        private void RemoveUser(ConnectedUserBlock userBlock)
        {
            Panel_ConnectedUsersList.Controls.Remove(userBlock);
        }

        private void Window_ControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Window_ControlBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Window_ControlBar_MouseMove(object sender, MouseEventArgs e)
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
            Control button = (Control)sender;
            button.BackColor = Color.FromArgb(40, 45, 55);
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

        private void Button_SignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            messageQueue.Enqueue("close://" + username);
            Thread.Sleep(10);
            _client.Close();

            Client_Load(sender, e);
        }

        private void Button_Reconnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                InitializeConnection();
                isConnected = true;
            }
            catch
            {
                isConnected = false;
            }

            for (int i = 0; i < 3; i++)
            {
                User_ConnectionStatus.BackColor = Color.Gold;
                Update();
                Thread.Sleep(500);
                User_ConnectionStatus.BackColor = Color.FromArgb(224, 224, 244);
                Update();
                Thread.Sleep(500);
            }

            if (!isConnected)
            {
                User_ConnectionStatus.BackColor = Color.OrangeRed;
            }
            else
            {
                User_ConnectionStatus.BackColor = Color.LawnGreen;
            }
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
