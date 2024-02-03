namespace FIT.WinForms.IspitIB000000
{
    partial class frmNovaDrzavaIB000000
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
            components = new System.ComponentModel.Container();
            pbSlika = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtNaziv = new TextBox();
            btnSacuvaj = new Button();
            btnOdustani = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(10, 28);
            pbSlika.Margin = new Padding(3, 2, 3, 2);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(293, 154);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pictureBox1_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Zastava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 192);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(10, 209);
            txtNaziv.Margin = new Padding(3, 2, 3, 2);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(294, 23);
            txtNaziv.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(221, 248);
            btnSacuvaj.Margin = new Padding(3, 2, 3, 2);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(82, 22);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(126, 248);
            btnOdustani.Margin = new Padding(3, 2, 3, 2);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(82, 22);
            btnOdustani.TabIndex = 5;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaDrzavaIB000000
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 277);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbSlika);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmNovaDrzavaIB000000";
            Text = "Dodavanje nove države";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label label1;
        private Label label2;
        private TextBox txtNaziv;
        private Button btnSacuvaj;
        private Button btnOdustani;
        private ErrorProvider err;
    }
}