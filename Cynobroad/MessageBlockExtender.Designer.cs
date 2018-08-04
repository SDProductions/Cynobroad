namespace Cynobroad
{
    partial class MessageBlockExtender
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
            this.Block_Message = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Block_Message
            // 
            this.Block_Message.BackColor = System.Drawing.SystemColors.Control;
            this.Block_Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Block_Message.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Block_Message.Location = new System.Drawing.Point(53, 6);
            this.Block_Message.Name = "Block_Message";
            this.Block_Message.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Block_Message.Size = new System.Drawing.Size(480, 17);
            this.Block_Message.TabIndex = 4;
            this.Block_Message.Text = "private void rtb_ContentsResized(object sender, ContentsResizedEventArgs e)privat" +
    "e void rtb_ContentsResized(object sender, ContentsResizedEventArgs e)";
            this.Block_Message.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.Block_Message_ContentsResized);
            // 
            // MessageBlockExtender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Block_Message);
            this.Name = "MessageBlockExtender";
            this.Size = new System.Drawing.Size(565, 30);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox Block_Message;
    }
}
