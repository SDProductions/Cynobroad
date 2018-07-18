using System.Windows.Forms;

namespace Cynobroad
{
    public partial class MessageBlock : UserControl
    {
        public MessageBlock()
        {
            InitializeComponent();
        }

        private void Block_Message_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        }
    }
}
