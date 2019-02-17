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
            this.Window_Icon = new System.Windows.Forms.PictureBox();
            this.SendMsgBox = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Label_SignedInAs = new System.Windows.Forms.Label();
            this.User_UsernameLabel = new System.Windows.Forms.Label();
            this.Button_SignOut = new System.Windows.Forms.LinkLabel();
            this.Button_Reconnect = new System.Windows.Forms.LinkLabel();
            this.Panel_InfoSummary = new System.Windows.Forms.Panel();
            this.Label_ConnectedUsers = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.User_ConnectedServer = new System.Windows.Forms.Label();
            this.User_ConnectionStatus = new System.Windows.Forms.PictureBox();
            this.Panel_ConnectedUsersList = new System.Windows.Forms.Panel();
            this.Panel_Messages = new System.Windows.Forms.Panel();
            this.SelfHoster = new System.ComponentModel.BackgroundWorker();
            this.Window_ControlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Icon)).BeginInit();
            this.Panel_InfoSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_ConnectionStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // Window_ControlBar
            // 
            this.Window_ControlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.Window_ControlBar.Controls.Add(this.Window_Minimize);
            this.Window_ControlBar.Controls.Add(this.Window_Close);
            this.Window_ControlBar.Controls.Add(this.Window_Title);
            this.Window_ControlBar.Controls.Add(this.Window_Icon);
            this.Window_ControlBar.Location = new System.Drawing.Point(0, 0);
            this.Window_ControlBar.Name = "Window_ControlBar";
            this.Window_ControlBar.Size = new System.Drawing.Size(800, 40);
            this.Window_ControlBar.TabIndex = 0;
            this.Window_ControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Window_ControlBar_MouseDown);
            this.Window_ControlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Window_ControlBar_MouseMove);
            this.Window_ControlBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Window_ControlBar_MouseUp);
            // 
            // Window_Minimize
            // 
            this.Window_Minimize.BackgroundImage = global::Cynobroad.Properties.Resources.minimize;
            this.Window_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Window_Minimize.Location = new System.Drawing.Point(743, 4);
            this.Window_Minimize.Name = "Window_Minimize";
            this.Window_Minimize.Size = new System.Drawing.Size(25, 25);
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
            this.Window_Close.Location = new System.Drawing.Point(772, 4);
            this.Window_Close.Name = "Window_Close";
            this.Window_Close.Size = new System.Drawing.Size(25, 25);
            this.Window_Close.TabIndex = 2;
            this.Window_Close.TabStop = false;
            this.Window_Close.Click += new System.EventHandler(this.Window_Close_Click);
            this.Window_Close.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Window_Close.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Window_Title
            // 
            this.Window_Title.AutoSize = true;
            this.Window_Title.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Window_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Window_Title.Location = new System.Drawing.Point(35, 8);
            this.Window_Title.Name = "Window_Title";
            this.Window_Title.Size = new System.Drawing.Size(114, 18);
            this.Window_Title.TabIndex = 1;
            this.Window_Title.Text = "Cynobroad Client";
            // 
            // Window_Icon
            // 
            this.Window_Icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Window_Icon.BackgroundImage")));
            this.Window_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Window_Icon.Location = new System.Drawing.Point(4, 4);
            this.Window_Icon.Name = "Window_Icon";
            this.Window_Icon.Size = new System.Drawing.Size(25, 25);
            this.Window_Icon.TabIndex = 0;
            this.Window_Icon.TabStop = false;
            // 
            // SendMsgBox
            // 
            this.SendMsgBox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMsgBox.Location = new System.Drawing.Point(4, 450);
            this.SendMsgBox.Name = "SendMsgBox";
            this.SendMsgBox.Size = new System.Drawing.Size(522, 25);
            this.SendMsgBox.TabIndex = 2;
            this.SendMsgBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendMsgBox_KeyDown);
            // 
            // Send
            // 
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send.Location = new System.Drawing.Point(525, 450);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(64, 25);
            this.Send.TabIndex = 3;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Label_SignedInAs
            // 
            this.Label_SignedInAs.AutoSize = true;
            this.Label_SignedInAs.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SignedInAs.Location = new System.Drawing.Point(3, 6);
            this.Label_SignedInAs.Name = "Label_SignedInAs";
            this.Label_SignedInAs.Size = new System.Drawing.Size(65, 13);
            this.Label_SignedInAs.TabIndex = 7;
            this.Label_SignedInAs.Text = "signed in as:";
            // 
            // User_UsernameLabel
            // 
            this.User_UsernameLabel.AutoSize = true;
            this.User_UsernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_UsernameLabel.Location = new System.Drawing.Point(3, 19);
            this.User_UsernameLabel.Name = "User_UsernameLabel";
            this.User_UsernameLabel.Size = new System.Drawing.Size(171, 19);
            this.User_UsernameLabel.TabIndex = 6;
            this.User_UsernameLabel.Text = "SDProductions TestClient";
            // 
            // Button_SignOut
            // 
            this.Button_SignOut.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_SignOut.AutoSize = true;
            this.Button_SignOut.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SignOut.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_SignOut.Location = new System.Drawing.Point(132, 38);
            this.Button_SignOut.Name = "Button_SignOut";
            this.Button_SignOut.Size = new System.Drawing.Size(41, 15);
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
            this.Button_Reconnect.Location = new System.Drawing.Point(77, 38);
            this.Button_Reconnect.Name = "Button_Reconnect";
            this.Button_Reconnect.Size = new System.Drawing.Size(49, 15);
            this.Button_Reconnect.TabIndex = 10;
            this.Button_Reconnect.TabStop = true;
            this.Button_Reconnect.Text = "reconnect";
            this.Button_Reconnect.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Reconnect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Button_Reconnect_LinkClicked);
            // 
            // Panel_InfoSummary
            // 
            this.Panel_InfoSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Panel_InfoSummary.Controls.Add(this.Label_ConnectedUsers);
            this.Panel_InfoSummary.Controls.Add(this.pictureBox1);
            this.Panel_InfoSummary.Controls.Add(this.User_ConnectedServer);
            this.Panel_InfoSummary.Controls.Add(this.Button_Reconnect);
            this.Panel_InfoSummary.Controls.Add(this.Button_SignOut);
            this.Panel_InfoSummary.Controls.Add(this.User_UsernameLabel);
            this.Panel_InfoSummary.Controls.Add(this.User_ConnectionStatus);
            this.Panel_InfoSummary.Controls.Add(this.Label_SignedInAs);
            this.Panel_InfoSummary.Location = new System.Drawing.Point(595, 40);
            this.Panel_InfoSummary.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_InfoSummary.Name = "Panel_InfoSummary";
            this.Panel_InfoSummary.Size = new System.Drawing.Size(205, 86);
            this.Panel_InfoSummary.TabIndex = 5;
            // 
            // Label_ConnectedUsers
            // 
            this.Label_ConnectedUsers.AutoSize = true;
            this.Label_ConnectedUsers.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConnectedUsers.Location = new System.Drawing.Point(3, 73);
            this.Label_ConnectedUsers.Name = "Label_ConnectedUsers";
            this.Label_ConnectedUsers.Size = new System.Drawing.Size(88, 13);
            this.Label_ConnectedUsers.TabIndex = 7;
            this.Label_ConnectedUsers.Text = "connected users:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(0, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 4);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // User_ConnectedServer
            // 
            this.User_ConnectedServer.AutoSize = true;
            this.User_ConnectedServer.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_ConnectedServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.User_ConnectedServer.Location = new System.Drawing.Point(4, 38);
            this.User_ConnectedServer.Name = "User_ConnectedServer";
            this.User_ConnectedServer.Size = new System.Drawing.Size(56, 15);
            this.User_ConnectedServer.TabIndex = 11;
            this.User_ConnectedServer.Text = "192.168.0.1";
            // 
            // User_ConnectionStatus
            // 
            this.User_ConnectionStatus.BackColor = System.Drawing.Color.Gold;
            this.User_ConnectionStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.User_ConnectionStatus.Location = new System.Drawing.Point(200, 0);
            this.User_ConnectionStatus.Name = "User_ConnectionStatus";
            this.User_ConnectionStatus.Size = new System.Drawing.Size(5, 70);
            this.User_ConnectionStatus.TabIndex = 6;
            this.User_ConnectionStatus.TabStop = false;
            // 
            // Panel_ConnectedUsersList
            // 
            this.Panel_ConnectedUsersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Panel_ConnectedUsersList.Location = new System.Drawing.Point(595, 125);
            this.Panel_ConnectedUsersList.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_ConnectedUsersList.Name = "Panel_ConnectedUsersList";
            this.Panel_ConnectedUsersList.Size = new System.Drawing.Size(205, 375);
            this.Panel_ConnectedUsersList.TabIndex = 13;
            // 
            // Panel_Messages
            // 
            this.Panel_Messages.AutoScroll = true;
            this.Panel_Messages.Location = new System.Drawing.Point(4, 46);
            this.Panel_Messages.Name = "Panel_Messages";
            this.Panel_Messages.Size = new System.Drawing.Size(585, 398);
            this.Panel_Messages.TabIndex = 14;
            // 
            // SelfHoster
            // 
            this.SelfHoster.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SelfHoster_DoWork);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.Panel_Messages);
            this.Controls.Add(this.Panel_ConnectedUsersList);
            this.Controls.Add(this.Panel_InfoSummary);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.SendMsgBox);
            this.Controls.Add(this.Window_ControlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "Cynobroad Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.Window_ControlBar.ResumeLayout(false);
            this.Window_ControlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Icon)).EndInit();
            this.Panel_InfoSummary.ResumeLayout(false);
            this.Panel_InfoSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_ConnectionStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Window_ControlBar;
        private System.Windows.Forms.PictureBox Window_Icon;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.PictureBox User_ConnectionStatus;
        internal System.Windows.Forms.Panel Panel_InfoSummary;
        internal System.Windows.Forms.Panel Panel_ConnectedUsersList;
        private System.Windows.Forms.Label Label_ConnectedUsers;
        private System.Windows.Forms.Panel Panel_Messages;
        private System.ComponentModel.BackgroundWorker SelfHoster;
    }
}

