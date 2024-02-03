namespace FIT.WinForms.IspitIB000000
{
    partial class frmGradoviIB000000
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
            lblDrzava = new Label();
            txtNaziv = new TextBox();
            label1 = new Label();
            ckAktivan1 = new CheckBox();
            btnDodaj = new Button();
            btnPrintaj = new Button();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnGenerisi = new Button();
            ckAktivan2 = new CheckBox();
            txtBroj = new TextBox();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            err = new ErrorProvider(components);
            dgvGradovi = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            PromijeniStatus = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(10, 9);
            pbSlika.Margin = new Padding(3, 2, 3, 2);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(257, 122);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblDrzava
            // 
            lblDrzava.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrzava.Location = new Point(287, 45);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(329, 49);
            lblDrzava.TabIndex = 1;
            lblDrzava.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(10, 170);
            txtNaziv.Margin = new Padding(3, 2, 3, 2);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(416, 23);
            txtNaziv.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 152);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 3;
            label1.Text = "Unesite naziv grada:";
            // 
            // ckAktivan1
            // 
            ckAktivan1.AutoSize = true;
            ckAktivan1.Location = new Point(431, 171);
            ckAktivan1.Margin = new Padding(3, 2, 3, 2);
            ckAktivan1.Name = "ckAktivan1";
            ckAktivan1.Size = new Size(66, 19);
            ckAktivan1.TabIndex = 4;
            ckAktivan1.Text = "Aktivan";
            ckAktivan1.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(507, 170);
            btnDodaj.Margin = new Padding(3, 2, 3, 2);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(127, 22);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj=>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(507, 405);
            btnPrintaj.Margin = new Padding(3, 2, 3, 2);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(127, 22);
            btnPrintaj.TabIndex = 6;
            btnPrintaj.Text = "Printaj=>";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(ckAktivan2);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Location = new Point(2, 431);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(641, 191);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodaj gradove:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(5, 82);
            txtInfo.Margin = new Padding(3, 2, 3, 2);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(618, 110);
            txtInfo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 65);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Info:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 26);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Broj:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(279, 41);
            btnGenerisi.Margin = new Padding(3, 2, 3, 2);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(82, 22);
            btnGenerisi.TabIndex = 2;
            btnGenerisi.Text = "Generiši=>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // ckAktivan2
            // 
            ckAktivan2.AutoSize = true;
            ckAktivan2.Location = new Point(204, 44);
            ckAktivan2.Margin = new Padding(3, 2, 3, 2);
            ckAktivan2.Name = "ckAktivan2";
            ckAktivan2.Size = new Size(66, 19);
            ckAktivan2.TabIndex = 1;
            ckAktivan2.Text = "Aktivan";
            ckAktivan2.UseVisualStyleBackColor = true;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(5, 43);
            txtBroj.Margin = new Padding(3, 2, 3, 2);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(181, 23);
            txtBroj.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Aktivan, PromijeniStatus });
            dgvGradovi.Location = new Point(10, 205);
            dgvGradovi.Margin = new Padding(3, 2, 3, 2);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowHeadersWidth = 51;
            dgvGradovi.RowTemplate.Height = 29;
            dgvGradovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradovi.Size = new Size(623, 185);
            dgvGradovi.TabIndex = 8;
            dgvGradovi.CellContentClick += dgvGradovi_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Resizable = DataGridViewTriState.True;
            Aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // PromijeniStatus
            // 
            PromijeniStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PromijeniStatus.DataPropertyName = "PromijeniStatus";
            PromijeniStatus.HeaderText = "";
            PromijeniStatus.MinimumWidth = 6;
            PromijeniStatus.Name = "PromijeniStatus";
            PromijeniStatus.ReadOnly = true;
            PromijeniStatus.Text = "PROMJENI STATUS";
            PromijeniStatus.UseColumnTextForButtonValue = true;
            // 
            // frmGradoviIB000000
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 562);
            Controls.Add(dgvGradovi);
            Controls.Add(groupBox1);
            Controls.Add(btnPrintaj);
            Controls.Add(btnDodaj);
            Controls.Add(ckAktivan1);
            Controls.Add(label1);
            Controls.Add(txtNaziv);
            Controls.Add(lblDrzava);
            Controls.Add(pbSlika);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGradoviIB000000";
            Text = "Dodavanje gradova";
            Load += frmGradoviIB000000_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblDrzava;
        private TextBox txtNaziv;
        private Label label1;
        private CheckBox ckAktivan1;
        private Button btnDodaj;
        private Button btnPrintaj;
        private GroupBox groupBox1;
        private TextBox txtBroj;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label label2;
        private Button btnGenerisi;
        private CheckBox ckAktivan2;
        private TextBox txtInfo;
        private Label label3;
        private ErrorProvider err;
        private DataGridView dgvGradovi;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn PromijeniStatus;
    }
}