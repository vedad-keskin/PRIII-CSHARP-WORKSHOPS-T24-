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
            cbDrzava = new ComboBox();
            cbGrad = new ComboBox();
            dgvStudenti = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            Drzava = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Država";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 9);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 0;
            label2.Text = "Grad";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(12, 32);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(275, 28);
            cbDrzava.TabIndex = 1;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(293, 32);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(275, 28);
            cbGrad.TabIndex = 1;
            cbGrad.SelectedIndexChanged += cbGrad_SelectedIndexChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, Grad, Drzava, Prosjek });
            dgvStudenti.Location = new Point(12, 66);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(874, 270);
            dgvStudenti.TabIndex = 2;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.MinimumWidth = 6;
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.MinimumWidth = 6;
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // Grad
            // 
            Grad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad";
            Grad.MinimumWidth = 6;
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "DrzavaInfo";
            Drzava.HeaderText = "Drzava";
            Drzava.MinimumWidth = 6;
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
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
            // frmPretragaIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 348);
            Controls.Add(dgvStudenti);
            Controls.Add(cbGrad);
            Controls.Add(cbDrzava);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB180079";
            Text = "Podaci o studentima";
            Load += frmPretragaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbDrzava;
        private ComboBox cbGrad;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn Prosjek;
    }
}