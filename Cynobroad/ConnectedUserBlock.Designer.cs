namespace Cynobroad
{
    partial class ConnectedUserBlock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.User_OnlineStatus = new System.Windows.Forms.PictureBox();
            this.User_Username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.User_OnlineStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // User_OnlineStatus
            // 
            this.User_OnlineStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.User_OnlineStatus.Location = new System.Drawing.Point(0, 0);
            this.User_OnlineStatus.Name = "User_OnlineStatus";
            this.User_OnlineStatus.Size = new System.Drawing.Size(5, 25);
            this.User_OnlineStatus.TabIndex = 0;
            this.User_OnlineStatus.TabStop = false;
            // 
            // User_Username
            // 
            this.User_Username.AutoSize = true;
            this.User_Username.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Username.Location = new System.Drawing.Point(16, 4);
            this.User_Username.Name = "User_Username";
            this.User_Username.Size = new System.Drawing.Size(65, 16);
            this.User_Username.TabIndex = 1;
            this.User_Username.Text = "Placeholder";
            // 
            // ConnectedUserBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.Controls.Add(this.User_Username);
            this.Controls.Add(this.User_OnlineStatus);
            this.Name = "ConnectedUserBlock";
            this.Size = new System.Drawing.Size(205, 25);
            ((System.ComponentModel.ISupportInitialize)(this.User_OnlineStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox User_OnlineStatus;
        internal System.Windows.Forms.Label User_Username;
    }
}
