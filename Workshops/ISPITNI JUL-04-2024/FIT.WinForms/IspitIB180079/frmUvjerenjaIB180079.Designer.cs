namespace FIT.WinForms.IspitIB180079
{
    partial class frmUvjerenjaIB180079
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
            btnNovi = new Button();
            dgvUvjerenja = new DataGridView();
            Vrijeme = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            btnDodaj = new Button();
            txtBroj = new TextBox();
            txtSvrha = new TextBox();
            cbVrsta = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnNovi
            // 
            btnNovi.Location = new Point(809, 12);
            btnNovi.Name = "btnNovi";
            btnNovi.Size = new Size(151, 29);
            btnNovi.TabIndex = 0;
            btnNovi.Text = "Novi zahtjev";
            btnNovi.UseVisualStyleBackColor = true;
            btnNovi.Click += btnNovi_Click;
            // 
            // dgvUvjerenja
            // 
            dgvUvjerenja.AllowUserToAddRows = false;
            dgvUvjerenja.AllowUserToDeleteRows = false;
            dgvUvjerenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjerenja.Columns.AddRange(new DataGridViewColumn[] { Vrijeme, Vrsta, Svrha, Uplatnica, Printano, Brisi, Printaj });
            dgvUvjerenja.Location = new Point(12, 55);
            dgvUvjerenja.Name = "dgvUvjerenja";
            dgvUvjerenja.ReadOnly = true;
            dgvUvjerenja.RowHeadersWidth = 51;
            dgvUvjerenja.RowTemplate.Height = 29;
            dgvUvjerenja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUvjerenja.Size = new Size(948, 252);
            dgvUvjerenja.TabIndex = 1;
            dgvUvjerenja.CellContentClick += dgvUvjerenja_CellContentClick;
            // 
            // Vrijeme
            // 
            Vrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Datum";
            Vrijeme.MinimumWidth = 6;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            // 
            // Vrsta
            // 
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.MinimumWidth = 6;
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            Vrsta.Width = 125;
            // 
            // Svrha
            // 
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.MinimumWidth = 6;
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            Svrha.Width = 125;
            // 
            // Uplatnica
            // 
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Uplatnica.MinimumWidth = 6;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            Uplatnica.Width = 125;
            // 
            // Printano
            // 
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.MinimumWidth = 6;
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            Printano.Width = 125;
            // 
            // Brisi
            // 
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Briši";
            Brisi.UseColumnTextForButtonValue = true;
            Brisi.Width = 125;
            // 
            // Printaj
            // 
            Printaj.HeaderText = "";
            Printaj.MinimumWidth = 6;
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            Printaj.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(txtSvrha);
            groupBox1.Controls.Add(cbVrsta);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 323);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(948, 282);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva za izdavanjem uvjerenja";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 113);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(924, 163);
            txtInfo.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(797, 60);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(133, 29);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(645, 60);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(130, 27);
            txtBroj.TabIndex = 2;
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(286, 59);
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(336, 27);
            txtSvrha.TabIndex = 2;
            // 
            // cbVrsta
            // 
            cbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrsta.FormattingEnabled = true;
            cbVrsta.Items.AddRange(new object[] { "Uvjerenje o položenim ispitima", "Uvjerenja o statusu studenta" });
            cbVrsta.Location = new Point(6, 59);
            cbVrsta.Name = "cbVrsta";
            cbVrsta.Size = new Size(266, 28);
            cbVrsta.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(645, 36);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 0;
            label3.Text = "Broj zahtjeva:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 36);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 0;
            label2.Text = "Svrha uvjerenja:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 90);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 0;
            label4.Text = "Info:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmUvjerenjaIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 617);
            Controls.Add(groupBox1);
            Controls.Add(dgvUvjerenja);
            Controls.Add(btnNovi);
            Name = "frmUvjerenjaIB180079";
            Text = "Info";
            Load += frmUvjerenjaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovi;
        private DataGridView dgvUvjerenja;
        private DataGridViewTextBoxColumn Vrijeme;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
        private GroupBox groupBox1;
        private ComboBox cbVrsta;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtInfo;
        private Button btnDodaj;
        private TextBox txtBroj;
        private TextBox txtSvrha;
        private Label label4;
        private ErrorProvider err;
    }
}