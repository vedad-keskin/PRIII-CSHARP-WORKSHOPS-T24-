namespace FIT.WinForms.IspitIB180079
{
    partial class frmPretragaIB180079
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbSpol = new ComboBox();
            dtpDatumOd = new DateTimePicker();
            dtpDatumDo = new DateTimePicker();
            label4 = new Label();
            txtImePrezime = new TextBox();
            chbAktivan = new CheckBox();
            dgvStudenti = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            Uvjerenja = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Spol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 9);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 0;
            label2.Text = "rođen u periodu od";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(721, 9);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 0;
            label3.Text = "do";
            // 
            // cbSpol
            // 
            cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpol.FormattingEnabled = true;
            cbSpol.Items.AddRange(new object[] { "Svi", "Muški", "Ženski" });
            cbSpol.Location = new Point(57, 6);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(258, 28);
            cbSpol.TabIndex = 1;
            cbSpol.SelectedIndexChanged += cbSpol_SelectedIndexChanged;
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Location = new Point(465, 6);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(250, 27);
            dtpDatumOd.TabIndex = 2;
            dtpDatumOd.Value = new DateTime(1999, 1, 13, 17, 27, 0, 0);
            dtpDatumOd.ValueChanged += dtpDatumOd_ValueChanged;
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Location = new Point(757, 6);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(250, 27);
            dtpDatumDo.TabIndex = 2;
            dtpDatumDo.ValueChanged += dtpDatumDo_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 42);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 0;
            label4.Text = "Ime ili prezime";
            // 
            // txtImePrezime
            // 
            txtImePrezime.Location = new Point(126, 40);
            txtImePrezime.Name = "txtImePrezime";
            txtImePrezime.Size = new Size(783, 27);
            txtImePrezime.TabIndex = 3;
            txtImePrezime.TextChanged += txtImePrezime_TextChanged;
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Checked = true;
            chbAktivan.CheckState = CheckState.Checked;
            chbAktivan.Location = new Point(931, 43);
            chbAktivan.Name = "chbAktivan";
            chbAktivan.Size = new Size(80, 24);
            chbAktivan.TabIndex = 4;
            chbAktivan.Text = "Aktivan";
            chbAktivan.UseVisualStyleBackColor = true;
            chbAktivan.CheckedChanged += chbAktivan_CheckedChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Indeks, ImePrezime, Prosjek, DatumRodjenja, Aktivan, Spol, Uvjerenja });
            dgvStudenti.Location = new Point(12, 73);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(999, 260);
            dgvStudenti.TabIndex = 5;
            dgvStudenti.CellClick += dgvStudenti_CellClick;
            // 
            // Indeks
            // 
            Indeks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Broj indeksa";
            Indeks.MinimumWidth = 6;
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rođenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Spol
            // 
            Spol.DataPropertyName = "Spol";
            Spol.HeaderText = "Spol";
            Spol.MinimumWidth = 6;
            Spol.Name = "Spol";
            Spol.ReadOnly = true;
            Spol.Width = 125;
            // 
            // Uvjerenja
            // 
            Uvjerenja.HeaderText = "";
            Uvjerenja.MinimumWidth = 6;
            Uvjerenja.Name = "Uvjerenja";
            Uvjerenja.ReadOnly = true;
            Uvjerenja.Text = "Uvjerenja";
            Uvjerenja.UseColumnTextForButtonValue = true;
            Uvjerenja.Width = 125;
            // 
            // frmPretragaIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 345);
            Controls.Add(dgvStudenti);
            Controls.Add(chbAktivan);
            Controls.Add(txtImePrezime);
            Controls.Add(dtpDatumDo);
            Controls.Add(dtpDatumOd);
            Controls.Add(cbSpol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "frmPretragaIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga studenta";
            Load += frmPretragaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbSpol;
        private DateTimePicker dtpDatumOd;
        private DateTimePicker dtpDatumDo;
        private Label label4;
        private TextBox txtImePrezime;
        private CheckBox chbAktivan;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewButtonColumn Uvjerenja;
    }
}