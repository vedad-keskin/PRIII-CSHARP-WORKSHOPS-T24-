namespace FIT.WinForms.IspitIB180079
{
    partial class frmNovoUvjerenjeIB180079
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
            cbVrsta = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtSvrha = new TextBox();
            pbUplatnica = new PictureBox();
            btnSacuvaj = new Button();
            btnOtkazi = new Button();
            openFileDialog = new OpenFileDialog();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // cbVrsta
            // 
            cbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrsta.FormattingEnabled = true;
            cbVrsta.Items.AddRange(new object[] { "Uvjerenje o statusu studenta", "Uvjerenje o polozenim predmetima" });
            cbVrsta.Location = new Point(12, 32);
            cbVrsta.Name = "cbVrsta";
            cbVrsta.Size = new Size(296, 28);
            cbVrsta.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 0;
            label2.Text = "Svrha izdavanja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 9);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 0;
            label3.Text = "Skenirana uplatnica:";
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(12, 106);
            txtSvrha.Multiline = true;
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(296, 237);
            txtSvrha.TabIndex = 2;
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(326, 32);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(552, 252);
            pbUplatnica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUplatnica.TabIndex = 3;
            pbUplatnica.TabStop = false;
            pbUplatnica.DoubleClick += pbUplatnica_DoubleClick;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(740, 301);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(138, 29);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(585, 301);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(138, 29);
            btnOtkazi.TabIndex = 4;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovoUvjerenjeIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 356);
            Controls.Add(btnOtkazi);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbUplatnica);
            Controls.Add(txtSvrha);
            Controls.Add(cbVrsta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovoUvjerenjeIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novi zahtjev za izdavajem uvjerenja";
            Load += frmNovoUvjerenjeIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbVrsta;
        private Label label2;
        private Label label3;
        private TextBox txtSvrha;
        private PictureBox pbUplatnica;
        private Button btnSacuvaj;
        private Button btnOtkazi;
        private OpenFileDialog openFileDialog;
        private ErrorProvider err;
    }
}