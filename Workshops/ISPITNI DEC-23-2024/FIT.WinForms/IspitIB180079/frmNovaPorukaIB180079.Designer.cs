namespace FIT.WinForms.IspitIB180079
{
    partial class frmNovaPorukaIB180079
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbPredmet = new ComboBox();
            dtpValidnost = new DateTimePicker();
            cbHitnost = new ComboBox();
            txtSadrzaj = new TextBox();
            pbSlika = new PictureBox();
            btnSacuvaj = new Button();
            btnOdustani = new Button();
            openFileDialog = new OpenFileDialog();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Odaberite predmet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 0;
            label2.Text = "Poruka je validna do:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 0;
            label3.Text = "Hitnost poruke:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 190);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 0;
            label4.Text = "Sadržaj poruke:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 9);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 0;
            label5.Text = "Slika:";
            // 
            // cbPredmet
            // 
            cbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(12, 32);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(290, 28);
            cbPredmet.TabIndex = 1;
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(12, 93);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(290, 27);
            dtpValidnost.TabIndex = 2;
            dtpValidnost.Value = new DateTime(2030, 1, 11, 2, 27, 0, 0);
            // 
            // cbHitnost
            // 
            cbHitnost.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHitnost.FormattingEnabled = true;
            cbHitnost.Items.AddRange(new object[] { "Niska", "Srednja", "Visoka" });
            cbHitnost.Location = new Point(12, 159);
            cbHitnost.Name = "cbHitnost";
            cbHitnost.Size = new Size(290, 28);
            cbHitnost.TabIndex = 1;
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(11, 213);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(291, 171);
            txtSadrzaj.TabIndex = 3;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(320, 32);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(353, 352);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 4;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(544, 401);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(129, 29);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(399, 401);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(129, 29);
            btnOdustani.TabIndex = 5;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaPorukaIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 443);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbSlika);
            Controls.Add(txtSadrzaj);
            Controls.Add(dtpValidnost);
            Controls.Add(cbHitnost);
            Controls.Add(cbPredmet);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaPorukaIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poruka";
            Load += frmNovaPorukaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbPredmet;
        private DateTimePicker dtpValidnost;
        private ComboBox cbHitnost;
        private TextBox txtSadrzaj;
        private PictureBox pbSlika;
        private Button btnSacuvaj;
        private Button btnOdustani;
        private OpenFileDialog openFileDialog;
        private ErrorProvider err;
    }
}