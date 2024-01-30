namespace OfpLauncher
{
    partial class frmAspectRatio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAspectRatio));
            this.cmbAspectRatio = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAspectRatio
            // 
            this.cmbAspectRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAspectRatio.FormattingEnabled = true;
            this.cmbAspectRatio.Location = new System.Drawing.Point(12, 11);
            this.cmbAspectRatio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAspectRatio.Name = "cmbAspectRatio";
            this.cmbAspectRatio.Size = new System.Drawing.Size(129, 23);
            this.cmbAspectRatio.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(147, 9);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 25);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmAspectRatio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 41);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cmbAspectRatio);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAspectRatio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "화면비 설정";
            this.Load += new System.EventHandler(this.frmAspectRatio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAspectRatio;
        private System.Windows.Forms.Button btnConfirm;
    }
}