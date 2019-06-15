using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Cynobroad
{
    public partial class Client : Form
    {
        //Connection info
        private string username;
        private int port = 42069;
        private string serverIP = "";

        //Connection handlers
        private Thread receivingThread;
        private Thread sendingThread;
        private TcpClient _client;
        private StreamReader _sReader;
        private StreamWriter _sWriter;
        private bool isConnected = false;
        
        private List<string> connectedUsers = new List<string>();

        //Messages to send
        private ConcurrentQueue<string> MessageQueue = new ConcurrentQueue<string>();

        //Window tools
        private bool mouseDown;
        private Point lastLocation;

        //Threadsafe calls
        delegate void AddRichMsg(Tuple<string, string> nameAndMessage);
        delegate void AddUserBlock(string username);
        delegate void DelUserBlock(string username);

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            Hide();

            //Get login info and try connecting
            using (Login login = new Login())
            {
                login.ShowDialog();

                //if no username or server specified, and not self host, close window
                //if parameters are met, start self hoster if applicable or connect to server with username
                if (string.IsNullOrEmpty(login.Username) && string.IsNullOrEmpty(login.ServerIP))
                    Close();
                else if (login.IsSelfHost)
                {
                    SelfHoster.RunWorkerAsync();
                    serverIP = Array.Find(Dns.GetHostEntry(string.Empty).AddressList,
                                          a => a.AddressFamily == AddressFamily.InterNetwork).ToString();
                    Window_Title.Text = $"Cynobroad Client - Local Server Running at {serverIP}";
                    
                }
                else
                    serverIP = login.ServerIP;

                username = login.Username;
                User_UsernameLabel.Text = username;
                User_ConnectedServer.Text = serverIP;

                try
                {
                    _client = new TcpClient();
                    isConnected = true;
                    InitializeConnection();
                    
                    //show main form and close login dialog
                    Show();
                    SendMsgBox.Focus();
                }
                catch
                {
                    isConnected = false;
                }
            }

            //if connection failed set status to red, else green
            if (!isConnected)
                User_ConnectionStatus.BackColor = Color.FromArgb(224, 102, 102);
            else
                User_ConnectionStatus.BackColor = Color.FromArgb(147, 196, 125);
        }

        private void SelfHoster_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            TCPServer server = new TCPServer(42069);
        }

        private void CreateAndSendPacket(string type, string message = null)
        {
            PacketStruct packetStruct = new PacketStruct
            {
                Type = type,
                User = username,
                Message = message
            };

            MessageQueue.Enqueue(JsonConvert.SerializeObject(packetStruct));
        }

        private void InitializeConnection()
        {
            //connect to server ip on port 42069
            _client.Connect(serverIP, port);
            _sWriter = new StreamWriter(_client.GetStream(), Encoding.ASCII);
            _sReader = new StreamReader(_client.GetStream(), Encoding.ASCII);
            
            //start a background task handling incoming messages
            ThreadStart startReceiver = new ThreadStart(HandleReceiver);
            receivingThread = new Thread(startReceiver)
            { IsBackground = true };
            receivingThread.Start();

            //start a background task handling outgoing messages
            ThreadStart startSender = new ThreadStart(HandleSender);
            sendingThread = new Thread(startSender)
            { IsBackground = true };
            sendingThread.Start();
        }

        private void HandleReceiver()
        {
            //set delegates
            AddRichMsg addRichMsg = RichMessageReceived;
            AddUserBlock addUser = AddConnectedUser;
            DelUserBlock delUser = RemoveConnectedUser;

            //send to server join message
            PacketStruct packetStruct = new PacketStruct
            {
                Type = "join",
                User = username
            };
            _sWriter.WriteLine(JsonConvert.SerializeObject(packetStruct));
            _sWriter.Flush();

            //while connected, recieve messages and process them
            PacketStruct packet = new PacketStruct();
            while (isConnected)
            {
                //Deserialize packet from StreamReader
                try   { packet = JsonConvert.DeserializeObject<PacketStruct>(_sReader.ReadLine()); }
                catch { packet = new PacketStruct(); }
                
                switch (packet.Type)
                {
                    case "rcu":
                        Invoke(delUser, packet.User);
                        break;
                    case "acu":
                        Invoke(addUser, packet.User);
                        break;
                    case "ucu":
                        if (packet.User == username)
                        {
                            List<string> usersList = JsonConvert.DeserializeObject<List<string>>(packet.Message);

                            foreach (string user in usersList)
                            { Invoke(addUser, user); }
                        }
                        break;
                    case "statchange":
                        ConnectedUserBlock selectedUser = (ConnectedUserBlock)Panel_ConnectedUsersList.Controls.Find(packet.User, false)[0];

                        switch (packet.Message)
                        {
                            case "0":
                                selectedUser.User_OnlineStatus.BackColor = Color.FromArgb(147, 196, 125);
                                break;
                            case "1":
                                selectedUser.User_OnlineStatus.BackColor = Color.FromArgb(255, 217, 102);
                                break;
                            case "2":
                                selectedUser.User_OnlineStatus.BackColor = Color.FromArgb(224, 102, 102);
                                break;
                            case "3":
                                selectedUser.User_OnlineStatus.BackColor = Color.FromArgb(153, 153, 153);
                                break;
                        }
                        break;
                    default:
                        try { Invoke(addRichMsg, new Tuple<string, string>(packet.User, packet.Message)); }
                        catch { break; }
                        break;
                }
            }
        }

        private void HandleSender()
        {
            //while connected, if there are messages to send, send them
            while (isConnected)
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
                Thread.Sleep(10);
            }
        }

        private void RichMessageReceived(Tuple<string,string> nameAndMessage)
        {
            string username = nameAndMessage.Item1;
            string msg = nameAndMessage.Item2;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(msg))
                return;

            //if the previous message was this user
            if (Panel_Messages.Controls.Count > 1 &&
               ((Panel_Messages.Controls[Panel_Messages.Controls.Count - 1].GetType() == typeof(MessageBlock) &&
               ((MessageBlock)Panel_Messages.Controls[Panel_Messages.Controls.Count - 1]).Block_User.Text == username) ||
               Panel_Messages.Controls[Panel_Messages.Controls.Count - 1].GetType() == typeof(MessageBlockExtender) &&
               ((MessageBlockExtender)Panel_Messages.Controls[Panel_Messages.Controls.Count - 1]).username == username))
            {
                //create new message extender with username and text
                var newMSGExtender = new MessageBlockExtender();
                newMSGExtender.Block_Message.Text = msg;
                newMSGExtender.username = username;

                //move previous messages up
                Control lastMSG = Panel_Messages.Controls[Panel_Messages.Controls.Count - 1];
                int nextYPos = lastMSG.Location.Y + lastMSG.Height;
                newMSGExtender.Location = new Point(0, nextYPos);

                //add the new message, and scroll down
                Panel_Messages.Controls.Add(newMSGExtender);
                Panel_Messages.VerticalScroll.Value = Panel_Messages.VerticalScroll.Maximum;
                Update();
            }
            else
            {
                //create new regular message block
                var newMSGBlock = new MessageBlock();
                newMSGBlock.Block_User.Text = username;
                newMSGBlock.Block_Message.Text = msg;

                //if no messages, set pos
                if (Panel_Messages.Controls.Count == 0)
                    newMSGBlock.Location = new Point(0, 0);
                //else, move previous messages up
                else
                {
                    Control lastMSG = Panel_Messages.Controls[Panel_Messages.Controls.Count - 1];
                    int nextYPos = lastMSG.Location.Y + lastMSG.Height;
                    newMSGBlock.Location = new Point(0, nextYPos);
                }

                //add, update panel, and scroll down
                Panel_Messages.Controls.Add(newMSGBlock);
                Panel_Messages.VerticalScroll.Value = Panel_Messages.VerticalScroll.Maximum;
                Update();
            }
        }

        private void RemoveConnectedUser(string username)
        {
            connectedUsers.Remove(username);
            connectedUsers.Sort();

            Panel_ConnectedUsersList.Controls.RemoveByKey(username);

            foreach (Control control in Panel_ConnectedUsersList.Controls)
            {
                control.Location = new Point(0, 5 + (connectedUsers.IndexOf(control.Name) * 25));
            }
            Update();
        }

        private void AddConnectedUser(string username)
        {
            connectedUsers.Add(username);
            connectedUsers.Sort();

            ConnectedUserBlock newUserBlock = new ConnectedUserBlock
            {
                Name = username,
                Location = new Point(0, 5)
            };
            newUserBlock.User_Username.Text = username;
            Panel_ConnectedUsersList.Controls.Add(newUserBlock);

            foreach (Control control in Panel_ConnectedUsersList.Controls)
            {
                control.Location = new Point(0, 5 + (connectedUsers.IndexOf(control.Name) * 25));
            }
            Update();
        }

        #region Basic Window Functions
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
                Location = new Point((Location.X - lastLocation.X) + e.X,
                                     (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Control button = (Control)sender;
            button.BackColor = Color.FromArgb(69, 77, 117);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Control button = (Control)sender;
            button.BackColor = Color.FromArgb(52, 57, 83);
        }

        private void Window_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Window_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConnected)
                CreateAndSendPacket("close");
        }

        private void Button_SignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //send closing request and reset variables
            CreateAndSendPacket("close");
            Thread.Sleep(10);
            isConnected = false;
            _client.Close();
            SelfHoster.Dispose();
            
            //rerun launch method to sign in again
            Client_Load(sender, e);
        }

        private void Button_Reconnect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //try reconnection and set connection bool
            try
            {
                InitializeConnection();
                isConnected = true;
            }
            catch (SocketException) { }
            catch { isConnected = false; }

            if (_client.Connected)
                isConnected = true;
            else
                isConnected = false;

            //useless visual effect
            for (int i = 0; i < 3; i++)
            {
                User_ConnectionStatus.BackColor = Color.FromArgb(255, 217, 102);
                Update();
                Thread.Sleep(500);
                User_ConnectionStatus.BackColor = Color.FromArgb(183, 183, 183);
                Update();
                Thread.Sleep(500);
            }

            //update connection status indicator
            if (!isConnected)
                User_ConnectionStatus.BackColor = Color.FromArgb(224, 102, 102);
            else
                User_ConnectionStatus.BackColor = Color.FromArgb(147, 196, 125);
        }

        private void SendMsgBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if enter pressed on msg box, don't play windows alert sound and send msg
            if (e.KeyValue == 13)
            {
                Send_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            //remove whitespace
            SendMsgBox.Text = SendMsgBox.Text.TrimEnd();

            //check requirements
            if (SendMsgBox.Text.Length > 1024)
            {
                MessageBox.Show("Woah woah woah! Our stingy network hamsters simply don't want to deal with all your bytes. " +
                                "We've limited each message to 1024 characters. Like Twitter, but not as bad.");
                return;
            }
            if (string.IsNullOrEmpty(SendMsgBox.Text))
                return;

            //add msg to queue and clear msg box
            CreateAndSendPacket("send", SendMsgBox.Text);
            SendMsgBox.Text = "";
            SendMsgBox.Focus();
        }

        private void StatusChanger_Online_Click(object sender, EventArgs e)
        {
            CreateAndSendPacket("statchange", "0");
            User_NotificationStatus.Text = "Online";
            NotificationStatusSlider.Location = new Point(80, 50);
        }

        private void StatusChanger_Idle_Click(object sender, EventArgs e)
        {
            CreateAndSendPacket("statchange", "1");
            User_NotificationStatus.Text = "Away";
            NotificationStatusSlider.Location = new Point(102, 50);
        }

        private void StatusChanger_DND_Click(object sender, EventArgs e)
        {
            CreateAndSendPacket("statchange", "2");
            User_NotificationStatus.Text = "Busy";
            NotificationStatusSlider.Location = new Point(124, 50);
        }

        private void StatusChanger_Invisible_Click(object sender, EventArgs e)
        {
            CreateAndSendPacket("statchange", "3");
            User_NotificationStatus.Text = "Invisible";
            NotificationStatusSlider.Location = new Point(146, 50);
        }
    }
}
