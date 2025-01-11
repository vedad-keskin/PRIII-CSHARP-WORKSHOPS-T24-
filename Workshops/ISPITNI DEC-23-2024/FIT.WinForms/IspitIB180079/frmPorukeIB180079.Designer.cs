namespace FIT.WinForms.IspitIB180079
{
    partial class frmPorukeIB180079
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
            lblStudent = new Label();
            btnNovaPoruka = new Button();
            dgvPoruke = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Hitnost = new DataGridViewTextBoxColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            btnDodaj = new Button();
            dtpValidnost = new DateTimePicker();
            cbPredmet = new ComboBox();
            txtBroj = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            err = new ErrorProvider(components);
            btnPrintaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(12, 13);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(114, 20);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "Poruke studenta";
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(833, 9);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(149, 29);
            btnNovaPoruka.TabIndex = 1;
            btnNovaPoruka.Text = "Nova poruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            btnNovaPoruka.Click += btnNovaPoruka_Click;
            // 
            // dgvPoruke
            // 
            dgvPoruke.AllowUserToAddRows = false;
            dgvPoruke.AllowUserToDeleteRows = false;
            dgvPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoruke.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Slika, Hitnost, Validnost, Brisi });
            dgvPoruke.Location = new Point(12, 44);
            dgvPoruke.Name = "dgvPoruke";
            dgvPoruke.ReadOnly = true;
            dgvPoruke.RowHeadersWidth = 51;
            dgvPoruke.RowTemplate.Height = 29;
            dgvPoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoruke.Size = new Size(970, 243);
            dgvPoruke.TabIndex = 2;
            dgvPoruke.CellContentClick += dgvPoruke_CellContentClick;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Sadrzaj
            // 
            Sadrzaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadrzaj";
            Sadrzaj.MinimumWidth = 6;
            Sadrzaj.Name = "Sadrzaj";
            Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            Slika.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.MinimumWidth = 6;
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            // 
            // Hitnost
            // 
            Hitnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hitnost.DataPropertyName = "Hitnost";
            Hitnost.HeaderText = "Hitnost";
            Hitnost.MinimumWidth = 6;
            Hitnost.Name = "Hitnost";
            Hitnost.ReadOnly = true;
            // 
            // Validnost
            // 
            Validnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.MinimumWidth = 6;
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(dtpValidnost);
            groupBox1.Controls.Add(cbPredmet);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 341);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(967, 246);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje poruka:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(319, 46);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(642, 179);
            txtInfo.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(17, 196);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(285, 29);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dtpValidnost
            // 
            dtpValidnost.Location = new Point(17, 157);
            dtpValidnost.Name = "dtpValidnost";
            dtpValidnost.Size = new Size(285, 27);
            dtpValidnost.TabIndex = 3;
            dtpValidnost.Value = new DateTime(2030, 1, 11, 3, 4, 0, 0);
            // 
            // cbPredmet
            // 
            cbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(17, 99);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(285, 28);
            cbPredmet.TabIndex = 2;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(17, 46);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(285, 27);
            txtBroj.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 134);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 0;
            label3.Text = "Poruka je validna do:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 76);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 0;
            label2.Text = "Predmet:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 23);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 0;
            label4.Text = "Info:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Broj poruka:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(833, 302);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(140, 29);
            btnPrintaj.TabIndex = 4;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // frmPorukeIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 599);
            Controls.Add(btnPrintaj);
            Controls.Add(groupBox1);
            Controls.Add(dgvPoruke);
            Controls.Add(btnNovaPoruka);
            Controls.Add(lblStudent);
            Name = "frmPorukeIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Broj poruka:";
            Load += frmPorukeIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudent;
        private Button btnNovaPoruka;
        private DataGridView dgvPoruke;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewTextBoxColumn Hitnost;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewButtonColumn Brisi;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtInfo;
        private Button btnDodaj;
        private DateTimePicker dtpValidnost;
        private ComboBox cbPredmet;
        private TextBox txtBroj;
        private Label label4;
        private ErrorProvider err;
        private Button btnPrintaj;
    }
}