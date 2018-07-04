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
            this.ControlBar = new System.Windows.Forms.Panel();
            this.Window_Icon = new System.Windows.Forms.PictureBox();
            this.ChatDisplay = new System.Windows.Forms.RichTextBox();
            this.SendMsgBox = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.ControlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Window_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlBar
            // 
            this.ControlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ControlBar.Controls.Add(this.Window_Icon);
            this.ControlBar.Location = new System.Drawing.Point(0, 0);
            this.ControlBar.Name = "ControlBar";
            this.ControlBar.Size = new System.Drawing.Size(640, 40);
            this.ControlBar.TabIndex = 0;
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
            // ChatDisplay
            // 
            this.ChatDisplay.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatDisplay.Location = new System.Drawing.Point(10, 50);
            this.ChatDisplay.Name = "ChatDisplay";
            this.ChatDisplay.ReadOnly = true;
            this.ChatDisplay.Size = new System.Drawing.Size(480, 370);
            this.ChatDisplay.TabIndex = 1;
            this.ChatDisplay.TabStop = false;
            this.ChatDisplay.Text = "";
            // 
            // SendMsgBox
            // 
            this.SendMsgBox.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMsgBox.Location = new System.Drawing.Point(10, 426);
            this.SendMsgBox.Name = "SendMsgBox";
            this.SendMsgBox.Size = new System.Drawing.Size(404, 25);
            this.SendMsgBox.TabIndex = 2;
            // 
            // Send
            // 
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send.Location = new System.Drawing.Point(421, 426);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(69, 25);
            this.Send.TabIndex = 3;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.SendMsgBox);
            this.Controls.Add(this.ChatDisplay);
            this.Controls.Add(this.ControlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "Cynobroad Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ControlBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Window_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ControlBar;
        private System.Windows.Forms.PictureBox Window_Icon;
        private System.Windows.Forms.RichTextBox ChatDisplay;
        private System.Windows.Forms.TextBox SendMsgBox;
        private System.Windows.Forms.Button Send;
    }
}

