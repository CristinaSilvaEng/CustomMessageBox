using System;
using System.Windows.Forms;

namespace CustomMessageBox.View
{
    public partial class uxMainForm : Form
    {
        public uxMainForm()
        {
            InitializeComponent();
        }

        private void uxBtnOk_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.View.CustomComponents.CustomMessageBox.Show("Hello, World!", "Bye, World!", CustomComponents.ButtonSet.Ok, Properties.Resources.HappyIcon);
            Console.WriteLine(result);
        }

        private void uxBtnOkCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.View.CustomComponents.CustomMessageBox.Show("Hello, World!", "Bye, World!", CustomComponents.ButtonSet.OkCancel, Properties.Resources.SadIcon);
            Console.WriteLine(result);
        }

        private void uxBtnYesNo_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.View.CustomComponents.CustomMessageBox.Show("Hello, World!", "Bye, World!", CustomComponents.ButtonSet.YesNo, Properties.Resources.HappyIcon);
            Console.WriteLine(result);
        }

        private void uxBtnYesNoCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.View.CustomComponents.CustomMessageBox.Show("Hello, World!", "Bye, World!", CustomComponents.ButtonSet.YesNoCancel, Properties.Resources.SadIcon);
            Console.WriteLine(result);
        }
    }
}
