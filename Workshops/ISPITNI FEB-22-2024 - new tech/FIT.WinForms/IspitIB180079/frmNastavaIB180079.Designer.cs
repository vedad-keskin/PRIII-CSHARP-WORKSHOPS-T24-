namespace FIT.WinForms.IspitIB180079
{
    partial class frmNastavaIB180079
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
            lblNazivProstorije = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbPredmet = new ComboBox();
            cbDan = new ComboBox();
            cbVrijeme = new ComboBox();
            button1 = new Button();
            dgvNastave = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvNastave).BeginInit();
            SuspendLayout();
            // 
            // lblNazivProstorije
            // 
            lblNazivProstorije.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNazivProstorije.Location = new Point(12, 18);
            lblNazivProstorije.Name = "lblNazivProstorije";
            lblNazivProstorije.Size = new Size(776, 68);
            lblNazivProstorije.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 1;
            label1.Text = "Predmet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 103);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Dan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 103);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 1;
            label3.Text = "Vrijeme:";
            // 
            // cbPredmet
            // 
            cbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(12, 126);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(231, 28);
            cbPredmet.TabIndex = 2;
            // 
            // cbDan
            // 
            cbDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDan.FormattingEnabled = true;
            cbDan.Items.AddRange(new object[] { "Ponedeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedelja" });
            cbDan.Location = new Point(261, 126);
            cbDan.Name = "cbDan";
            cbDan.Size = new Size(167, 28);
            cbDan.TabIndex = 2;
            // 
            // cbVrijeme
            // 
            cbVrijeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrijeme.FormattingEnabled = true;
            cbVrijeme.Items.AddRange(new object[] { "08 - 10", "10 - 12", "12 - 14" });
            cbVrijeme.Location = new Point(443, 126);
            cbVrijeme.Name = "cbVrijeme";
            cbVrijeme.Size = new Size(167, 28);
            cbVrijeme.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(632, 125);
            button1.Name = "button1";
            button1.Size = new Size(156, 29);
            button1.TabIndex = 3;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvNastave
            // 
            dgvNastave.AllowUserToAddRows = false;
            dgvNastave.AllowUserToDeleteRows = false;
            dgvNastave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastave.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme });
            dgvNastave.Location = new Point(12, 160);
            dgvNastave.Name = "dgvNastave";
            dgvNastave.ReadOnly = true;
            dgvNastave.RowHeadersWidth = 51;
            dgvNastave.RowTemplate.Height = 29;
            dgvNastave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNastave.Size = new Size(776, 278);
            dgvNastave.TabIndex = 4;
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
            // Dan
            // 
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.MinimumWidth = 6;
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            Dan.Width = 125;
            // 
            // Vrijeme
            // 
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.MinimumWidth = 6;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            Vrijeme.Width = 125;
            // 
            // frmNastavaIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvNastave);
            Controls.Add(button1);
            Controls.Add(cbVrijeme);
            Controls.Add(cbDan);
            Controls.Add(cbPredmet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNazivProstorije);
            Name = "frmNastavaIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nastava";
            FormClosed += frmNastavaIB180079_FormClosed;
            Load += frmNastavaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNastave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazivProstorije;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbPredmet;
        private ComboBox cbDan;
        private ComboBox cbVrijeme;
        private Button button1;
        private DataGridView dgvNastave;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
    }
}