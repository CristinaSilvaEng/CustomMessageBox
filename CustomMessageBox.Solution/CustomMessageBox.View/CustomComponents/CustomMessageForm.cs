using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomMessageBox.View.CustomComponents
{
    internal partial class uxCustomMessageForm : Form
    {
        public uxCustomMessageForm(string caption, string message, ButtonSet buttons, Bitmap icon)
        {
            InitializeComponent();

            this.Text = caption;
            this.uxTbxMessage.Text = message;
            this.uxPbxIcon.Image = icon;

            SetButtons(buttons);
        }

        private void SetButtons(ButtonSet buttons)
        {
            switch (buttons)
            {
                case ButtonSet.Ok:
                    this.uxBtnOk.Location = new System.Drawing.Point(250, 110);
                    this.uxBtnOk.Visible = true;
                    break;
                case ButtonSet.OkCancel:
                    this.uxBtnOk.Location = new System.Drawing.Point(125, 110);
                    this.uxBtnOk.Visible = true;
                    this.uxBtnCancel.Location = new System.Drawing.Point(250, 110);
                    this.uxBtnCancel.Visible = true;
                    break;
                case ButtonSet.YesNo:
                    this.uxBtnYes.Location = new System.Drawing.Point(125, 110);
                    this.uxBtnYes.Visible = true;
                    this.uxBtnNo.Location = new System.Drawing.Point(250, 110);
                    this.uxBtnNo.Visible = true;
                    break;
                case ButtonSet.YesNoCancel:
                    this.uxBtnYes.Location = new System.Drawing.Point(12, 110);
                    this.uxBtnYes.Visible = true;
                    this.uxBtnNo.Location = new System.Drawing.Point(138, 110);
                    this.uxBtnNo.Visible = true;
                    this.uxBtnCancel.Location = new System.Drawing.Point(264, 110);
                    this.uxBtnCancel.Visible = true;
                    break;
            }
        }

        private void uxBtnOk_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void uxBtnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void uxBtnYes_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void uxBtnNo_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
