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
            components = new System.ComponentModel.Container();
            lblNastava = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbPredmet = new ComboBox();
            cbDan = new ComboBox();
            cbVrijeme = new ComboBox();
            button1 = new Button();
            dgvNastava = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvNastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblNastava
            // 
            lblNastava.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblNastava.Location = new Point(12, 9);
            lblNastava.Name = "lblNastava";
            lblNastava.Size = new Size(702, 113);
            lblNastava.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 122);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 1;
            label1.Text = "Predmet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 122);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Dan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(540, 122);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 1;
            label3.Text = "Vrijeme:";
            // 
            // cbPredmet
            // 
            cbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPredmet.FormattingEnabled = true;
            cbPredmet.Location = new Point(12, 145);
            cbPredmet.Name = "cbPredmet";
            cbPredmet.Size = new Size(237, 28);
            cbPredmet.TabIndex = 2;
            // 
            // cbDan
            // 
            cbDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDan.FormattingEnabled = true;
            cbDan.Items.AddRange(new object[] { "Ponedeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedelja" });
            cbDan.Location = new Point(279, 145);
            cbDan.Name = "cbDan";
            cbDan.Size = new Size(237, 28);
            cbDan.TabIndex = 2;
            // 
            // cbVrijeme
            // 
            cbVrijeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVrijeme.FormattingEnabled = true;
            cbVrijeme.Items.AddRange(new object[] { "08 - 10", "10 - 12", "12 - 14" });
            cbVrijeme.Location = new Point(540, 145);
            cbVrijeme.Name = "cbVrijeme";
            cbVrijeme.Size = new Size(237, 28);
            cbVrijeme.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(797, 144);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 3;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvNastava
            // 
            dgvNastava.AllowUserToAddRows = false;
            dgvNastava.AllowUserToDeleteRows = false;
            dgvNastava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastava.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme });
            dgvNastava.Location = new Point(12, 179);
            dgvNastava.Name = "dgvNastava";
            dgvNastava.ReadOnly = true;
            dgvNastava.RowHeadersWidth = 51;
            dgvNastava.RowTemplate.Height = 29;
            dgvNastava.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNastava.Size = new Size(919, 252);
            dgvNastava.TabIndex = 4;
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
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNastavaIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 442);
            Controls.Add(dgvNastava);
            Controls.Add(button1);
            Controls.Add(cbVrijeme);
            Controls.Add(cbDan);
            Controls.Add(cbPredmet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNastava);
            Name = "frmNastavaIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nastava";
            FormClosed += frmNastavaIB180079_FormClosed;
            Load += frmNastavaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNastava;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbPredmet;
        private ComboBox cbDan;
        private ComboBox cbVrijeme;
        private Button button1;
        private DataGridView dgvNastava;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
        private ErrorProvider err;
    }
}