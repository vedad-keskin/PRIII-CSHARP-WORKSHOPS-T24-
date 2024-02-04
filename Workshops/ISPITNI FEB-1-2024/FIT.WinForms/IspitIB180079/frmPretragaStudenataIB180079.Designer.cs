namespace FIT.WinForms.IspitIB180079
{
    partial class frmPretragaStudenataIB180079
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
            dgvStudenti = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            Drzava = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            cbDrzava = new ComboBox();
            cbGrad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Student, Drzava, Grad, Prosjek });
            dgvStudenti.Location = new Point(12, 49);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowTemplate.Height = 25;
            dgvStudenti.RowTemplate.Resizable = DataGridViewTriState.True;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(443, 236);
            dgvStudenti.TabIndex = 0;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Drzava";
            Drzava.HeaderText = "Država";
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            // 
            // Grad
            // 
            Grad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad";
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Država:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 20);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Grad:";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(58, 17);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(190, 23);
            cbDrzava.TabIndex = 2;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(295, 17);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(160, 23);
            cbGrad.TabIndex = 3;
            cbGrad.SelectedIndexChanged += cbGrad_SelectedIndexChanged;
            // 
            // frmPretragaStudenataIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 299);
            Controls.Add(cbGrad);
            Controls.Add(cbDrzava);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStudenti);
            Name = "frmPretragaStudenataIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga studenata";
            Load += frmPretragaStudenataIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudenti;
        private Label label1;
        private Label label2;
        private ComboBox cbDrzava;
        private ComboBox cbGrad;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Prosjek;
    }
}