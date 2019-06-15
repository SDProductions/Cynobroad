namespace Cynobroad
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.Window_ControlBar = new System.Windows.Forms.Panel();
            this.Window_Minimize = new System.Windows.Forms.PictureBox();
            this.Window_Close = new System.Windows.Forms.PictureBox();
            this.Window_Title = new System.Windows.Forms.Label();
            this.SendMsgBox = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Label_SignedInAs = new System.Windows.Forms.Label();
            this.User_UsernameLabel = new System.Windows.Forms.Label();
            this.Button_SignOut = new System.Windows.Forms.LinkLabel();
            this.Button_Reconnect = new System.Windows.Forms.LinkLabel();
            this.Panel_InfoSummary = new System.Windows.Forms.Panel();
            this.NotificationStatusSlider = new System.Windows.Forms.PictureBox();
            this.User_NotificationStatus = new System.Windows.Forms.Label();
            this.StatusChanger_Invisible = new System.Windows.Forms.PictureBox();
            this.StatusChanger_DND = new System.Windows.Forms.PictureBox();
            this.StatusChanger_Idle = new System.Windows.Forms.PictureBox();
            this.StatusChanger_Online = new System.Windows.Forms.PictureBox();
            this.Label_ConnectedUsers = new System.Windows.Forms.Label();
            this.Separator = new System.Windows.Forms.PictureBox();
            this.User_ConnectedServer = new System.Windows.Forms.Label();
            this.User_ConnectionStatus = new System.Windows.Forms.PictureBox();
            this.Panel_ConnectedUsersList = new System.Windows.Forms.Panel();
            this.Panel_Messages = new System.Windows.Forms.Panel();
            this.SelfHoster = new System.ComponentModel.BackgroundWorker();
            this.Window_ControlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Close)).BeginInit();
            this.Panel_InfoSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationStatusSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusChanger_Invisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusChanger_DND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusChanger_Idle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusChanger_Online)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_ConnectionStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // Window_ControlBar
            // 
            this.Window_ControlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Window_ControlBar.Controls.Add(this.Window_Minimize);
            this.Window_ControlBar.Controls.Add(this.Window_Close);
            this.Window_ControlBar.Controls.Add(this.Window_Title);
            this.Window_ControlBar.Location = new System.Drawing.Point(275, 0);
            this.Window_ControlBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Window_ControlBar.Name = "Window_ControlBar";
            this.Window_ControlBar.Size = new System.Drawing.Size(925, 50);
            this.Window_ControlBar.TabIndex = 0;
            this.Window_ControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_ControlBar_MouseDown);
            this.Window_ControlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Window_ControlBar_MouseMove);
            this.Window_ControlBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Window_ControlBar_MouseUp);
            // 
            // Window_Minimize
            // 
            this.Window_Minimize.BackgroundImage = global::Cynobroad.Properties.Resources.minimize;
            this.Window_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Window_Minimize.Location = new System.Drawing.Point(838, 7);
            this.Window_Minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Window_Minimize.Name = "Window_Minimize";
            this.Window_Minimize.Size = new System.Drawing.Size(33, 31);
            this.Window_Minimize.TabIndex = 3;
            this.Window_Minimize.TabStop = false;
            this.Window_Minimize.Click += new System.EventHandler(this.Window_Minimize_Click);
            this.Window_Minimize.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Window_Minimize.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Window_Close
            // 
            this.Window_Close.BackgroundImage = global::Cynobroad.Properties.Resources.close;
            this.Window_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Window_Close.Location = new System.Drawing.Point(879, 7);
            this.Window_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Window_Close.Name = "Window_Close";
            this.Window_Close.Size = new System.Drawing.Size(33, 31);
            this.Window_Close.TabIndex = 2;
            this.Window_Close.TabStop = false;
            this.Window_Close.Click += new System.EventHandler(this.Window_Close_Click);
            this.Window_Close.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Window_Close.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Window_Title
            // 
            this.Window_Title.AutoSize = true;
            this.Window_Title.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Window_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Window_Title.Location = new System.Drawing.Point(8, 15);
            this.Window_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Window_Title.Name = "Window_Title";
            this.Window_Title.Size = new System.Drawing.Size(147, 23);
            this.Window_Title.TabIndex = 1;
            this.Window_Title.Text = "Cynobroad Client";
            // 
            // SendMsgBox
            // 
            this.SendMsgBox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMsgBox.Location = new System.Drawing.Point(279, 573);
            this.SendMsgBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendMsgBox.Name = "SendMsgBox";
            this.SendMsgBox.Size = new System.Drawing.Size(815, 29);
            this.SendMsgBox.TabIndex = 2;
            this.SendMsgBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendMsgBox_KeyDown);
            // 
            // Send
            // 
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send.Location = new System.Drawing.Point(1102, 571);
            this.Send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(85, 31);
            this.Send.TabIndex = 3;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Label_SignedInAs
            // 
            this.Label_SignedInAs.AutoSize = true;
            this.Label_SignedInAs.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SignedInAs.Location = new System.Drawing.Point(4, 7);
            this.Label_SignedInAs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SignedInAs.Name = "Label_SignedInAs";
            this.Label_SignedInAs.Size = new System.Drawing.Size(76, 17);
            this.Label_SignedInAs.TabIndex = 7;
            this.Label_SignedInAs.Text = "signed in as:";
            // 
            // User_UsernameLabel
            // 
            this.User_UsernameLabel.AutoSize = true;
            this.User_UsernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_UsernameLabel.Location = new System.Drawing.Point(4, 23);
            this.User_UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_UsernameLabel.Name = "User_UsernameLabel";
            this.User_UsernameLabel.Size = new System.Drawing.Size(217, 24);
            this.User_UsernameLabel.TabIndex = 6;
            this.User_UsernameLabel.Text = "SDProductions TestClient";
            // 
            // Button_SignOut
            // 
            this.Button_SignOut.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_SignOut.AutoSize = true;
            this.Button_SignOut.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SignOut.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_SignOut.Location = new System.Drawing.Point(199, 64);
            this.Button_SignOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Button_SignOut.Name = "Button_SignOut";
            this.Button_SignOut.Size = new System.Drawing.Size(52, 18);
            this.Button_SignOut.TabIndex = 9;
            this.Button_SignOut.TabStop = true;
            this.Button_SignOut.Text = "sign out";
            this.Button_SignOut.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_SignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Button_SignOut_LinkClicked);
            // 
            // Button_Reconnect
            // 
            this.Button_Reconnect.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Reconnect.AutoSize = true;
            this.Button_Reconnect.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Reconnect.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Reconnect.Location = new System.Drawing.Point(126, 64);
            this.Button_Reconnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Button_Reconnect.Name = "Button_Reconnect";
            this.Button_Reconnect.Size = new System.Drawing.Size(67, 18);
            this.Button_Reconnect.TabIndex = 10;
            this.Button_Reconnect.TabStop = true;
            this.Button_Reconnect.Text = "reconnect";
            this.Button_Reconnect.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Reconnect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Button_Reconnect_LinkClicked);
            // 
            // Panel_InfoSummary
            // 
            this.Panel_InfoSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Panel_InfoSummary.Controls.Add(this.NotificationStatusSlider);
            this.Panel_InfoSummary.Controls.Add(this.User_NotificationStatus);
            this.Panel_InfoSummary.Controls.Add(this.StatusChanger_Invisible);
            this.Panel_InfoSummary.Controls.Add(this.StatusChanger_DND);
            this.Panel_InfoSummary.Controls.Add(this.StatusChanger_Idle);
            this.Panel_InfoSummary.Controls.Add(this.StatusChanger_Online);
            this.Panel_InfoSummary.Controls.Add(this.Label_ConnectedUsers);
            this.Panel_InfoSummary.Controls.Add(this.Separator);
            this.Panel_InfoSummary.Controls.Add(this.User_ConnectedServer);
            this.Panel_InfoSummary.Controls.Add(this.Button_Reconnect);
            this.Panel_InfoSummary.Controls.Add(this.Button_SignOut);
            this.Panel_InfoSummary.Controls.Add(this.User_UsernameLabel);
            this.Panel_InfoSummary.Controls.Add(this.User_ConnectionStatus);
            this.Panel_InfoSummary.Controls.Add(this.Label_SignedInAs);
            this.Panel_InfoSummary.Location = new System.Drawing.Point(0, 0);
            this.Panel_InfoSummary.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_InfoSummary.Name = "Panel_InfoSummary";
            this.Panel_InfoSummary.Size = new System.Drawing.Size(275, 120);
            this.Panel_InfoSummary.TabIndex = 5;
            // 
            // NotificationStatusSlider
            // 
            this.NotificationStatusSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(97)))), ((int)(((byte)(124)))));
            this.NotificationStatusSlider.Location = new System.Drawing.Point(130, 62);
            this.NotificationStatusSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NotificationStatusSlider.Name = "NotificationStatusSlider";
            this.NotificationStatusSlider.Size = new System.Drawing.Size(30, 5);
            this.NotificationStatusSlider.TabIndex = 18;
            this.NotificationStatusSlider.TabStop = false;
            // 
            // User_NotificationStatus
            // 
            this.User_NotificationStatus.AutoSize = true;
            this.User_NotificationStatus.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_NotificationStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.User_NotificationStatus.Location = new System.Drawing.Point(5, 64);
            this.User_NotificationStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_NotificationStatus.Name = "User_NotificationStatus";
            this.User_NotificationStatus.Size = new System.Drawing.Size(45, 18);
            this.User_NotificationStatus.TabIndex = 17;
            this.User_NotificationStatus.Text = "Online";
            // 
            // StatusChanger_Invisible
            // 
            this.StatusChanger_Invisible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.StatusChanger_Invisible.Location = new System.Drawing.Point(220, 50);
            this.StatusChanger_Invisible.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusChanger_Invisible.Name = "StatusChanger_Invisible";
            this.StatusChanger_Invisible.Size = new System.Drawing.Size(30, 12);
            this.StatusChanger_Invisible.TabIndex = 16;
            this.StatusChanger_Invisible.TabStop = false;
            this.StatusChanger_Invisible.Click += new System.EventHandler(this.StatusChanger_Invisible_Click);
            // 
            // StatusChanger_DND
            // 
            this.StatusChanger_DND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.StatusChanger_DND.Location = new System.Drawing.Point(190, 50);
            this.StatusChanger_DND.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusChanger_DND.Name = "StatusChanger_DND";
            this.StatusChanger_DND.Size = new System.Drawing.Size(30, 12);
            this.StatusChanger_DND.TabIndex = 15;
            this.StatusChanger_DND.TabStop = false;
            this.StatusChanger_DND.Click += new System.EventHandler(this.StatusChanger_DND_Click);
            // 
            // StatusChanger_Idle
            // 
            this.StatusChanger_Idle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.StatusChanger_Idle.Location = new System.Drawing.Point(160, 50);
            this.StatusChanger_Idle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusChanger_Idle.Name = "StatusChanger_Idle";
            this.StatusChanger_Idle.Size = new System.Drawing.Size(30, 12);
            this.StatusChanger_Idle.TabIndex = 14;
            this.StatusChanger_Idle.TabStop = false;
            this.StatusChanger_Idle.Click += new System.EventHandler(this.StatusChanger_Idle_Click);
            // 
            // StatusChanger_Online
            // 
            this.StatusChanger_Online.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.StatusChanger_Online.Location = new System.Drawing.Point(130, 50);
            this.StatusChanger_Online.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusChanger_Online.Name = "StatusChanger_Online";
            this.StatusChanger_Online.Size = new System.Drawing.Size(30, 12);
            this.StatusChanger_Online.TabIndex = 13;
            this.StatusChanger_Online.TabStop = false;
            this.StatusChanger_Online.Click += new System.EventHandler(this.StatusChanger_Online_Click);
            // 
            // Label_ConnectedUsers
            // 
            this.Label_ConnectedUsers.AutoSize = true;
            this.Label_ConnectedUsers.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConnectedUsers.Location = new System.Drawing.Point(4, 96);
            this.Label_ConnectedUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ConnectedUsers.Name = "Label_ConnectedUsers";
            this.Label_ConnectedUsers.Size = new System.Drawing.Size(103, 17);
            this.Label_ConnectedUsers.TabIndex = 7;
            this.Label_ConnectedUsers.Text = "connected users:";
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.Separator.Location = new System.Drawing.Point(0, 89);
            this.Separator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(275, 5);
            this.Separator.TabIndex = 12;
            this.Separator.TabStop = false;
            // 
            // User_ConnectedServer
            // 
            this.User_ConnectedServer.AutoSize = true;
            this.User_ConnectedServer.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_ConnectedServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.User_ConnectedServer.Location = new System.Drawing.Point(5, 47);
            this.User_ConnectedServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_ConnectedServer.Name = "User_ConnectedServer";
            this.User_ConnectedServer.Size = new System.Drawing.Size(68, 18);
            this.User_ConnectedServer.TabIndex = 11;
            this.User_ConnectedServer.Text = "192.168.0.1";
            // 
            // User_ConnectionStatus
            // 
            this.User_ConnectionStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(102)))));
            this.User_ConnectionStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.User_ConnectionStatus.Location = new System.Drawing.Point(268, 0);
            this.User_ConnectionStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.User_ConnectionStatus.Name = "User_ConnectionStatus";
            this.User_ConnectionStatus.Size = new System.Drawing.Size(7, 89);
            this.User_ConnectionStatus.TabIndex = 6;
            this.User_ConnectionStatus.TabStop = false;
            // 
            // Panel_ConnectedUsersList
            // 
            this.Panel_ConnectedUsersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Panel_ConnectedUsersList.Location = new System.Drawing.Point(0, 120);
            this.Panel_ConnectedUsersList.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_ConnectedUsersList.Name = "Panel_ConnectedUsersList";
            this.Panel_ConnectedUsersList.Size = new System.Drawing.Size(275, 495);
            this.Panel_ConnectedUsersList.TabIndex = 13;
            // 
            // Panel_Messages
            // 
            this.Panel_Messages.AutoScroll = true;
            this.Panel_Messages.Location = new System.Drawing.Point(275, 50);
            this.Panel_Messages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_Messages.Name = "Panel_Messages";
            this.Panel_Messages.Size = new System.Drawing.Size(925, 500);
            this.Panel_Messages.TabIndex = 14;
            // 
            // SelfHoster
            // 
            this.SelfHoster.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SelfHoster_DoWork);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.Window_ControlBar);
            this.Controls.Add(this.Panel_Messages);
            this.Controls.Add(this.Panel_ConnectedUsersList);
            this.Controls.Add(this.Panel_InfoSummary);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.SendMsgBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Client";
            this.Text = "Cynobroad Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.Window_ControlBar.ResumeLayout(false);
            this.Window_ControlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Close)).EndInit();
            this.Panel_InfoSummary.ResumeLayout(false);
            this.Panel_InfoSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationStatusSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusChanger_Invisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusChanger_DND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusChanger_Idle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusChanger_Online)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_ConnectionStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Window_ControlBar;
        private System.Windows.Forms.TextBox SendMsgBox;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label Window_Title;
        private System.Windows.Forms.PictureBox Window_Close;
        private System.Windows.Forms.PictureBox Window_Minimize;
        private System.Windows.Forms.Label Label_SignedInAs;
        private System.Windows.Forms.Label User_UsernameLabel;
        private System.Windows.Forms.LinkLabel Button_SignOut;
        private System.Windows.Forms.LinkLabel Button_Reconnect;
        private System.Windows.Forms.Label User_ConnectedServer;
        private System.Windows.Forms.PictureBox Separator;
        internal System.Windows.Forms.PictureBox User_ConnectionStatus;
        internal System.Windows.Forms.Panel Panel_InfoSummary;
        internal System.Windows.Forms.Panel Panel_ConnectedUsersList;
        private System.Windows.Forms.Label Label_ConnectedUsers;
        private System.Windows.Forms.Panel Panel_Messages;
        private System.ComponentModel.BackgroundWorker SelfHoster;
        private System.Windows.Forms.PictureBox StatusChanger_Invisible;
        private System.Windows.Forms.PictureBox StatusChanger_DND;
        private System.Windows.Forms.PictureBox StatusChanger_Idle;
        private System.Windows.Forms.PictureBox StatusChanger_Online;
        private System.Windows.Forms.PictureBox NotificationStatusSlider;
        private System.Windows.Forms.Label User_NotificationStatus;
    }
}

