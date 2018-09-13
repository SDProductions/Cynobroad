using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cynobroad
{
    public partial class MessageBlockExtender : UserControl
    {
        public string username;

        public MessageBlockExtender()
        {
            InitializeComponent();
        }

        private void Block_Message_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        }
    }
}
