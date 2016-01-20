namespace CustomMessageBox.View.CustomComponents
{
    partial class uxCustomMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxCustomMessageForm));
            this.uxPbxIcon = new System.Windows.Forms.PictureBox();
            this.uxTbxMessage = new System.Windows.Forms.TextBox();
            this.uxBtnOk = new System.Windows.Forms.Button();
            this.uxBtnCancel = new System.Windows.Forms.Button();
            this.uxBtnNo = new System.Windows.Forms.Button();
            this.uxBtnYes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxPbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // uxPbxIcon
            // 
            this.uxPbxIcon.Location = new System.Drawing.Point(12, 24);
            this.uxPbxIcon.Name = "uxPbxIcon";
            this.uxPbxIcon.Size = new System.Drawing.Size(70, 70);
            this.uxPbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uxPbxIcon.TabIndex = 0;
            this.uxPbxIcon.TabStop = false;
            // 
            // uxTbxMessage
            // 
            this.uxTbxMessage.BackColor = System.Drawing.Color.White;
            this.uxTbxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxTbxMessage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uxTbxMessage.Enabled = false;
            this.uxTbxMessage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTbxMessage.Location = new System.Drawing.Point(89, 24);
            this.uxTbxMessage.Multiline = true;
            this.uxTbxMessage.Name = "uxTbxMessage";
            this.uxTbxMessage.Size = new System.Drawing.Size(283, 70);
            this.uxTbxMessage.TabIndex = 1;
            // 
            // uxBtnOk
            // 
            this.uxBtnOk.BackColor = System.Drawing.Color.DarkCyan;
            this.uxBtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxBtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnOk.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnOk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uxBtnOk.Location = new System.Drawing.Point(125, 110);
            this.uxBtnOk.Name = "uxBtnOk";
            this.uxBtnOk.Size = new System.Drawing.Size(120, 40);
            this.uxBtnOk.TabIndex = 2;
            this.uxBtnOk.Text = "Ok";
            this.uxBtnOk.UseVisualStyleBackColor = false;
            this.uxBtnOk.Visible = false;
            this.uxBtnOk.Click += new System.EventHandler(this.uxBtnOk_Click);
            // 
            // uxBtnCancel
            // 
            this.uxBtnCancel.BackColor = System.Drawing.Color.DarkCyan;
            this.uxBtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxBtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uxBtnCancel.Location = new System.Drawing.Point(264, 110);
            this.uxBtnCancel.Name = "uxBtnCancel";
            this.uxBtnCancel.Size = new System.Drawing.Size(120, 40);
            this.uxBtnCancel.TabIndex = 3;
            this.uxBtnCancel.Text = "Cancel";
            this.uxBtnCancel.UseVisualStyleBackColor = false;
            this.uxBtnCancel.Visible = false;
            this.uxBtnCancel.Click += new System.EventHandler(this.uxBtnCancel_Click);
            // 
            // uxBtnNo
            // 
            this.uxBtnNo.BackColor = System.Drawing.Color.DarkCyan;
            this.uxBtnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxBtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnNo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnNo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uxBtnNo.Location = new System.Drawing.Point(138, 110);
            this.uxBtnNo.Name = "uxBtnNo";
            this.uxBtnNo.Size = new System.Drawing.Size(120, 40);
            this.uxBtnNo.TabIndex = 5;
            this.uxBtnNo.Text = "No";
            this.uxBtnNo.UseVisualStyleBackColor = false;
            this.uxBtnNo.Visible = false;
            this.uxBtnNo.Click += new System.EventHandler(this.uxBtnNo_Click);
            // 
            // uxBtnYes
            // 
            this.uxBtnYes.BackColor = System.Drawing.Color.DarkCyan;
            this.uxBtnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxBtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnYes.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnYes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uxBtnYes.Location = new System.Drawing.Point(12, 110);
            this.uxBtnYes.Name = "uxBtnYes";
            this.uxBtnYes.Size = new System.Drawing.Size(120, 40);
            this.uxBtnYes.TabIndex = 4;
            this.uxBtnYes.Text = "Yes";
            this.uxBtnYes.UseVisualStyleBackColor = false;
            this.uxBtnYes.Visible = false;
            this.uxBtnYes.Click += new System.EventHandler(this.uxBtnYes_Click);
            // 
            // uxCustomMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 161);
            this.Controls.Add(this.uxBtnNo);
            this.Controls.Add(this.uxBtnYes);
            this.Controls.Add(this.uxBtnCancel);
            this.Controls.Add(this.uxBtnOk);
            this.Controls.Add(this.uxTbxMessage);
            this.Controls.Add(this.uxPbxIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uxCustomMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Caption";
            ((System.ComponentModel.ISupportInitialize)(this.uxPbxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox uxPbxIcon;
        private System.Windows.Forms.TextBox uxTbxMessage;
        private System.Windows.Forms.Button uxBtnOk;
        private System.Windows.Forms.Button uxBtnCancel;
        private System.Windows.Forms.Button uxBtnNo;
        private System.Windows.Forms.Button uxBtnYes;
    }
}