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
            lblDrzava = new Label();
            label1 = new Label();
            txtNaziv = new TextBox();
            button1 = new Button();
            dgvGradovi = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Status = new DataGridViewButtonColumn();
            err = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtBroj = new TextBox();
            err2 = new ErrorProvider(components);
            chbStatus = new CheckBox();
            btnGenerisi = new Button();
            label3 = new Label();
            txtInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err2).BeginInit();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 12);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(158, 94);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblDrzava
            // 
            lblDrzava.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblDrzava.Location = new Point(186, 52);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(403, 54);
            lblDrzava.TabIndex = 1;
            lblDrzava.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 127);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 2;
            label1.Text = "Unesite naziv novog grada :";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(186, 124);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(285, 23);
            txtNaziv.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(494, 124);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 4;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Aktivan, Status });
            dgvGradovi.Location = new Point(12, 155);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowTemplate.Height = 25;
            dgvGradovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradovi.Size = new Size(577, 150);
            dgvGradovi.TabIndex = 5;
            dgvGradovi.CellContentClick += dgvGradovi_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv grada";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Status";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Text = "Promijeni status";
            Status.UseColumnTextForButtonValue = true;
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
            groupBox1.Location = new Point(12, 311);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(577, 193);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 0;
            label2.Text = "Broj gradova:";
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(89, 16);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(97, 23);
            txtBroj.TabIndex = 1;
            // 
            // err2
            // 
            err2.ContainerControl = this;
            // 
            // chbStatus
            // 
            chbStatus.AutoSize = true;
            chbStatus.Location = new Point(192, 19);
            chbStatus.Name = "chbStatus";
            chbStatus.Size = new Size(63, 19);
            chbStatus.TabIndex = 2;
            chbStatus.Text = "Aktivni";
            chbStatus.UseVisualStyleBackColor = true;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(261, 16);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(105, 23);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "Info:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 72);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(565, 115);
            txtInfo.TabIndex = 4;
            // 
            // frmGradoviIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 516);
            Controls.Add(groupBox1);
            Controls.Add(dgvGradovi);
            Controls.Add(button1);
            Controls.Add(txtNaziv);
            Controls.Add(label1);
            Controls.Add(lblDrzava);
            Controls.Add(pbZastava);
            Name = "frmGradoviIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o gradu";
            FormClosed += frmGradoviIB180079_FormClosed;
            Load += frmGradoviIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblDrzava;
        private Label label1;
        private TextBox txtNaziv;
        private Button button1;
        private DataGridView dgvGradovi;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Status;
        private ErrorProvider err;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private Button btnGenerisi;
        private CheckBox chbStatus;
        private TextBox txtBroj;
        private Label label3;
        private Label label2;
        private ErrorProvider err2;
    }
}