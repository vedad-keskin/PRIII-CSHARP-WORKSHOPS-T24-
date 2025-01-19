namespace FIT.WinForms.IspitIB180079
{
    partial class frmGradoviIB180079
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
            pbZastava = new PictureBox();
            lblNazivDrzave = new Label();
            label1 = new Label();
            txtNaziv = new TextBox();
            btnDodaj = new Button();
            dgvGradovi = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            PromijeniStatus = new DataGridViewButtonColumn();
            err = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            btnGenerisi = new Button();
            chbStatus = new CheckBox();
            txtBroj = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 12);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(162, 81);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblNazivDrzave
            // 
            lblNazivDrzave.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNazivDrzave.Location = new Point(198, 47);
            lblNazivDrzave.Name = "lblNazivDrzave";
            lblNazivDrzave.Size = new Size(519, 46);
            lblNazivDrzave.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 2;
            label1.Text = "Unesite naziv novog grada:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(198, 110);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(408, 27);
            txtNaziv.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(612, 109);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(105, 29);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Status, PromijeniStatus });
            dgvGradovi.Location = new Point(12, 144);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowHeadersWidth = 51;
            dgvGradovi.RowTemplate.Height = 29;
            dgvGradovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradovi.Size = new Size(705, 156);
            dgvGradovi.TabIndex = 5;
            dgvGradovi.CellContentClick += dgvGradovi_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv grada";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivan";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // PromijeniStatus
            // 
            PromijeniStatus.HeaderText = "";
            PromijeniStatus.MinimumWidth = 6;
            PromijeniStatus.Name = "PromijeniStatus";
            PromijeniStatus.ReadOnly = true;
            PromijeniStatus.Text = "Promijeni status";
            PromijeniStatus.UseColumnTextForButtonValue = true;
            PromijeniStatus.Width = 125;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(chbStatus);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(705, 266);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(25, 103);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(656, 146);
            txtInfo.TabIndex = 4;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(354, 36);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(158, 29);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // chbStatus
            // 
            chbStatus.AutoSize = true;
            chbStatus.Location = new Point(272, 37);
            chbStatus.Name = "chbStatus";
            chbStatus.Size = new Size(76, 24);
            chbStatus.TabIndex = 2;
            chbStatus.Text = "Aktivni";
            chbStatus.UseVisualStyleBackColor = true;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(129, 35);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(125, 27);
            txtBroj.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 80);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 0;
            label3.Text = "Info:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 38);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Broj gradova:";
            // 
            // frmGradoviIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 593);
            Controls.Add(dgvGradovi);
            Controls.Add(groupBox1);
            Controls.Add(btnDodaj);
            Controls.Add(txtNaziv);
            Controls.Add(label1);
            Controls.Add(lblNazivDrzave);
            Controls.Add(pbZastava);
            Name = "frmGradoviIB180079";
            Text = "Podaci o gradu";
            FormClosed += frmGradoviIB180079_FormClosed;
            Load += frmGradoviIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblNazivDrzave;
        private Label label1;
        private TextBox txtNaziv;
        private Button btnDodaj;
        private DataGridView dgvGradovi;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn PromijeniStatus;
        private ErrorProvider err;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private Button btnGenerisi;
        private CheckBox chbStatus;
        private TextBox txtBroj;
        private Label label3;
        private Label label2;
    }
}