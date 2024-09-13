namespace FIT.WinForms.IspitIB180079
{
    partial class frmStudentInfoIB180079
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
            pbSlika = new PictureBox();
            lblImePrezime = new Label();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(24, 27);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(268, 231);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblImePrezime
            // 
            lblImePrezime.Font = new Font("Segoe UI", 18F);
            lblImePrezime.Location = new Point(24, 275);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(268, 42);
            lblImePrezime.TabIndex = 1;
            lblImePrezime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProsjek
            // 
            lblProsjek.Font = new Font("Segoe UI", 10F);
            lblProsjek.Location = new Point(24, 325);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(268, 25);
            lblProsjek.TabIndex = 2;
            lblProsjek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmStudentInfoIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 374);
            Controls.Add(lblProsjek);
            Controls.Add(lblImePrezime);
            Controls.Add(pbSlika);
            Name = "frmStudentInfoIB180079";
            Text = "Info";
            Load += frmStudentInfoIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblImePrezime;
        private Label lblProsjek;
    }
}