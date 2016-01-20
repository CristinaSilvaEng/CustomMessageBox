namespace CustomMessageBox.View
{
    partial class uxMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxMainForm));
            this.uxBtnOk = new System.Windows.Forms.Button();
            this.uxBtnYesNo = new System.Windows.Forms.Button();
            this.uxBtnYesNoCancel = new System.Windows.Forms.Button();
            this.uxBtnOkCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxBtnOk
            // 
            this.uxBtnOk.BackColor = System.Drawing.Color.DarkCyan;
            this.uxBtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxBtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnOk.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnOk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uxBtnOk.Location = new System.Drawing.Point(12, 12);
            this.uxBtnOk.Name = "uxBtnOk";
            this.uxBtnOk.Size = new System.Drawing.Size(145, 45);
            this.uxBtnOk.TabIndex = 0;
            this.uxBtnOk.Text = "Ok";
            this.uxBtnOk.UseVisualStyleBackColor = false;
            this.uxBtnOk.Click += new System.EventHandler(this.uxBtnOk_Click);
            // 
            // uxBtnYesNo
            // 
            this.uxBtnYesNo.BackColor = System.Drawing.Color.DarkCyan;
            this.uxBtnYesNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxBtnYesNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnYesNo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnYesNo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uxBtnYesNo.Location = new System.Drawing.Point(314, 12);
            this.uxBtnYesNo.Name = "uxBtnYesNo";
            this.uxBtnYesNo.Size = new System.Drawing.Size(145, 45);
            this.uxBtnYesNo.TabIndex = 1;
            this.uxBtnYesNo.Text = "YesNo";
            this.uxBtnYesNo.UseVisualStyleBackColor = false;
            this.uxBtnYesNo.Click += new System.EventHandler(this.uxBtnYesNo_Click);
            // 
            // uxBtnYesNoCancel
            // 
            this.uxBtnYesNoCancel.BackColor = System.Drawing.Color.DarkCyan;
            this.uxBtnYesNoCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxBtnYesNoCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnYesNoCancel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnYesNoCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uxBtnYesNoCancel.Location = new System.Drawing.Point(465, 12);
            this.uxBtnYesNoCancel.Name = "uxBtnYesNoCancel";
            this.uxBtnYesNoCancel.Size = new System.Drawing.Size(145, 45);
            this.uxBtnYesNoCancel.TabIndex = 2;
            this.uxBtnYesNoCancel.Text = "YesNoCancel";
            this.uxBtnYesNoCancel.UseVisualStyleBackColor = false;
            this.uxBtnYesNoCancel.Click += new System.EventHandler(this.uxBtnYesNoCancel_Click);
            // 
            // uxBtnOkCancel
            // 
            this.uxBtnOkCancel.BackColor = System.Drawing.Color.DarkCyan;
            this.uxBtnOkCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uxBtnOkCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxBtnOkCancel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBtnOkCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uxBtnOkCancel.Location = new System.Drawing.Point(163, 12);
            this.uxBtnOkCancel.Name = "uxBtnOkCancel";
            this.uxBtnOkCancel.Size = new System.Drawing.Size(145, 45);
            this.uxBtnOkCancel.TabIndex = 3;
            this.uxBtnOkCancel.Text = "OkCancel";
            this.uxBtnOkCancel.UseVisualStyleBackColor = false;
            this.uxBtnOkCancel.Click += new System.EventHandler(this.uxBtnOkCancel_Click);
            // 
            // uxMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 68);
            this.Controls.Add(this.uxBtnOkCancel);
            this.Controls.Add(this.uxBtnYesNoCancel);
            this.Controls.Add(this.uxBtnYesNo);
            this.Controls.Add(this.uxBtnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "uxMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxBtnOk;
        private System.Windows.Forms.Button uxBtnYesNo;
        private System.Windows.Forms.Button uxBtnYesNoCancel;
        private System.Windows.Forms.Button uxBtnOkCancel;
    }
}

