namespace Cynobroad
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ControlBar = new System.Windows.Forms.Panel();
            this.Window_Close = new System.Windows.Forms.PictureBox();
            this.Window_Title = new System.Windows.Forms.Label();
            this.Window_Icon = new System.Windows.Forms.PictureBox();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Input_Username = new System.Windows.Forms.TextBox();
            this.Input_ServerIP = new System.Windows.Forms.TextBox();
            this.Accept = new System.Windows.Forms.Button();
            this.ControlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlBar
            // 
            this.ControlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ControlBar.Controls.Add(this.Window_Close);
            this.ControlBar.Controls.Add(this.Window_Title);
            this.ControlBar.Controls.Add(this.Window_Icon);
            this.ControlBar.Location = new System.Drawing.Point(0, 0);
            this.ControlBar.Name = "ControlBar";
            this.ControlBar.Size = new System.Drawing.Size(350, 40);
            this.ControlBar.TabIndex = 0;
            // 
            // Window_Close
            // 
            this.Window_Close.BackgroundImage = global::Cynobroad.Properties.Resources.close;
            this.Window_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Window_Close.Location = new System.Drawing.Point(321, 4);
            this.Window_Close.Margin = new System.Windows.Forms.Padding(4);
            this.Window_Close.Name = "Window_Close";
            this.Window_Close.Size = new System.Drawing.Size(25, 25);
            this.Window_Close.TabIndex = 2;
            this.Window_Close.TabStop = false;
            this.Window_Close.Click += new System.EventHandler(this.Window_Close_Click);
            // 
            // Window_Title
            // 
            this.Window_Title.AutoSize = true;
            this.Window_Title.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Window_Title.ForeColor = System.Drawing.Color.Silver;
            this.Window_Title.Location = new System.Drawing.Point(35, 8);
            this.Window_Title.Name = "Window_Title";
            this.Window_Title.Size = new System.Drawing.Size(111, 18);
            this.Window_Title.TabIndex = 1;
            this.Window_Title.Text = "Cynobroad Login";
            // 
            // Window_Icon
            // 
            this.Window_Icon.BackgroundImage = global::Cynobroad.Properties.Resources.sdp_ico;
            this.Window_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Window_Icon.Location = new System.Drawing.Point(4, 4);
            this.Window_Icon.Name = "Window_Icon";
            this.Window_Icon.Size = new System.Drawing.Size(25, 25);
            this.Window_Icon.TabIndex = 0;
            this.Window_Icon.TabStop = false;
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Username.Location = new System.Drawing.Point(35, 60);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(71, 18);
            this.Label_Username.TabIndex = 1;
            this.Label_Username.Text = "Username:";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.Location = new System.Drawing.Point(35, 90);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(66, 18);
            this.Label_Password.TabIndex = 2;
            this.Label_Password.Text = "Server IP:";
            // 
            // Input_Username
            // 
            this.Input_Username.Location = new System.Drawing.Point(112, 60);
            this.Input_Username.Margin = new System.Windows.Forms.Padding(3, 3, 35, 3);
            this.Input_Username.MaxLength = 32;
            this.Input_Username.Name = "Input_Username";
            this.Input_Username.Size = new System.Drawing.Size(194, 20);
            this.Input_Username.TabIndex = 3;
            // 
            // Input_ServerIP
            // 
            this.Input_ServerIP.Location = new System.Drawing.Point(112, 90);
            this.Input_ServerIP.Margin = new System.Windows.Forms.Padding(3, 3, 35, 3);
            this.Input_ServerIP.MaxLength = 512;
            this.Input_ServerIP.Name = "Input_ServerIP";
            this.Input_ServerIP.PasswordChar = '*';
            this.Input_ServerIP.Size = new System.Drawing.Size(194, 20);
            this.Input_ServerIP.TabIndex = 4;
            // 
            // Accept
            // 
            this.Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accept.Location = new System.Drawing.Point(231, 116);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 5;
            this.Accept.Text = "Login";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.Input_ServerIP);
            this.Controls.Add(this.Input_Username);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Username);
            this.Controls.Add(this.ControlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ControlBar.ResumeLayout(false);
            this.ControlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ControlBar;
        private System.Windows.Forms.Label Window_Title;
        private System.Windows.Forms.PictureBox Window_Icon;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox Input_Username;
        private System.Windows.Forms.TextBox Input_ServerIP;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.PictureBox Window_Close;
    }
}