namespace FIT.WinForms.IspitIB180079
{
    partial class frmPrisustvoIB180079
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
            lblPrebrojavanje = new Label();
            lblProstorijaNaziv = new Label();
            dgvPrisustva = new DataGridView();
            Nastava = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            cbNastava = new ComboBox();
            cbStudent = new ComboBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            txtInfo = new TextBox();
            txtBroj = new TextBox();
            label4 = new Label();
            label3 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPrisustva).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblPrebrojavanje
            // 
            lblPrebrojavanje.Font = new Font("Segoe UI", 20F);
            lblPrebrojavanje.Location = new Point(670, 28);
            lblPrebrojavanje.Name = "lblPrebrojavanje";
            lblPrebrojavanje.Size = new Size(148, 71);
            lblPrebrojavanje.TabIndex = 0;
            lblPrebrojavanje.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblProstorijaNaziv
            // 
            lblProstorijaNaziv.Font = new Font("Segoe UI", 20F);
            lblProstorijaNaziv.Location = new Point(21, 28);
            lblProstorijaNaziv.Name = "lblProstorijaNaziv";
            lblProstorijaNaziv.Size = new Size(557, 71);
            lblProstorijaNaziv.TabIndex = 0;
            // 
            // dgvPrisustva
            // 
            dgvPrisustva.AllowUserToAddRows = false;
            dgvPrisustva.AllowUserToDeleteRows = false;
            dgvPrisustva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustva.Columns.AddRange(new DataGridViewColumn[] { Nastava, Student });
            dgvPrisustva.Location = new Point(21, 179);
            dgvPrisustva.Name = "dgvPrisustva";
            dgvPrisustva.ReadOnly = true;
            dgvPrisustva.RowHeadersWidth = 51;
            dgvPrisustva.RowTemplate.Height = 29;
            dgvPrisustva.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrisustva.Size = new Size(797, 193);
            dgvPrisustva.TabIndex = 1;
            // 
            // Nastava
            // 
            Nastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nastava.DataPropertyName = "Nastava";
            Nastava.HeaderText = "Predmet, prostorija, vrijeme";
            Nastava.MinimumWidth = 6;
            Nastava.Name = "Nastava";
            Nastava.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 108);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Nastava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 108);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Student:";
            // 
            // cbNastava
            // 
            cbNastava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNastava.FormattingEnabled = true;
            cbNastava.Location = new Point(21, 131);
            cbNastava.Name = "cbNastava";
            cbNastava.Size = new Size(315, 28);
            cbNastava.TabIndex = 3;
            cbNastava.SelectedIndexChanged += cbNastava_SelectedIndexChanged;
            // 
            // cbStudent
            // 
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(352, 131);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(318, 28);
            cbStudent.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(676, 131);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 4;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(21, 389);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 297);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // button2
            // 
            button2.Location = new Point(266, 29);
            button2.Name = "button2";
            button2.Size = new Size(128, 29);
            button2.TabIndex = 2;
            button2.Text = "Generiši";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(29, 114);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(741, 160);
            txtInfo.TabIndex = 1;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(120, 31);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(125, 27);
            txtBroj.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 34);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 0;
            label4.Text = "Broj zapisa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 82);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 0;
            label3.Text = "Info:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPrisustvoIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 698);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(cbStudent);
            Controls.Add(cbNastava);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPrisustva);
            Controls.Add(lblProstorijaNaziv);
            Controls.Add(lblPrebrojavanje);
            Name = "frmPrisustvoIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evidencija nastave";
            Load += frmPrisustvoIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrisustva).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrebrojavanje;
        private Label lblProstorijaNaziv;
        private DataGridView dgvPrisustva;
        private Label label1;
        private Label label2;
        private ComboBox cbNastava;
        private ComboBox cbStudent;
        private Button button1;
        private DataGridViewTextBoxColumn Nastava;
        private DataGridViewTextBoxColumn Student;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private TextBox txtBroj;
        private Label label4;
        private Label label3;
        private Button button2;
        private ErrorProvider err;
    }
}