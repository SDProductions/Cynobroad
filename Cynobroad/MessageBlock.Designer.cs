﻿namespace Cynobroad
{
    partial class MessageBlock
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
            this.Block_UserIcon = new System.Windows.Forms.PictureBox();
            this.Block_User = new System.Windows.Forms.Label();
            this.Block_Message = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Block_UserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Block_UserIcon
            // 
            this.Block_UserIcon.BackgroundImage = global::Cynobroad.Properties.Resources.sdp_ico;
            this.Block_UserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Block_UserIcon.Location = new System.Drawing.Point(4, 4);
            this.Block_UserIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Block_UserIcon.Name = "Block_UserIcon";
            this.Block_UserIcon.Size = new System.Drawing.Size(53, 49);
            this.Block_UserIcon.TabIndex = 0;
            this.Block_UserIcon.TabStop = false;
            // 
            // Block_User
            // 
            this.Block_User.AutoSize = true;
            this.Block_User.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Block_User.Location = new System.Drawing.Point(65, 4);
            this.Block_User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Block_User.Name = "Block_User";
            this.Block_User.Size = new System.Drawing.Size(235, 24);
            this.Block_User.TabIndex = 1;
            this.Block_User.Text = "SDProductions TestClient";
            // 
            // Block_Message
            // 
            this.Block_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Block_Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Block_Message.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Block_Message.Location = new System.Drawing.Point(71, 32);
            this.Block_Message.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Block_Message.Name = "Block_Message";
            this.Block_Message.ReadOnly = true;
            this.Block_Message.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Block_Message.Size = new System.Drawing.Size(800, 21);
            this.Block_Message.TabIndex = 3;
            this.Block_Message.Text = "private void rtb_ContentsResized(object sender, ContentsResizedEventArgs e)privat" +
    "e void rtb_ContentsResized(object sender, ContentsResizedEventArgs e)";
            this.Block_Message.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.Block_Message_ContentsResized);
            // 
            // MessageBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Controls.Add(this.Block_Message);
            this.Controls.Add(this.Block_User);
            this.Controls.Add(this.Block_UserIcon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MessageBlock";
            this.Size = new System.Drawing.Size(900, 62);
            ((System.ComponentModel.ISupportInitialize)(this.Block_UserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox Block_UserIcon;
        internal System.Windows.Forms.Label Block_User;
        internal System.Windows.Forms.RichTextBox Block_Message;
    }
}
