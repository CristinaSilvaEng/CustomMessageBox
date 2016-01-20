using System.Drawing;
using System.Windows.Forms;

namespace CustomMessageBox.View.CustomComponents
{
    public static class CustomMessageBox
    {
        public static DialogResult Show(string caption, string message, ButtonSet buttons, Bitmap icon)
        {
            using (var messageBox = new uxCustomMessageForm(caption, message, buttons, icon))
            {
                return messageBox.ShowDialog();
            }
        }
    }
}
