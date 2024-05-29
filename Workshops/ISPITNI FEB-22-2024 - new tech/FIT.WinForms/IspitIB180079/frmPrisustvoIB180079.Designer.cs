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
            lblProstorija = new Label();
            label1 = new Label();
            lblDo = new Label();
            lblOd = new Label();
            label2 = new Label();
            lbl = new Label();
            cbStudent = new ComboBox();
            button1 = new Button();
            dgvPrisustva = new DataGridView();
            Nastava = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            cbNastave = new ComboBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtBroj = new TextBox();
            button2 = new Button();
            txtInfo = new TextBox();
            label4 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPrisustva).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblProstorija
            // 
            lblProstorija.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblProstorija.Location = new Point(12, 19);
            lblProstorija.Name = "lblProstorija";
            lblProstorija.Size = new Size(533, 113);
            lblProstorija.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(737, 28);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 2;
            label1.Text = "/";
            // 
            // lblDo
            // 
            lblDo.Location = new Point(758, 28);
            lblDo.Name = "lblDo";
            lblDo.Size = new Size(50, 20);
            lblDo.TabIndex = 2;
            // 
            // lblOd
            // 
            lblOd.Location = new Point(681, 28);
            lblOd.Name = "lblOd";
            lblOd.Size = new Size(50, 20);
            lblOd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 161);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 3;
            label2.Text = "Nastava:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(325, 161);
            lbl.Name = "lbl";
            lbl.Size = new Size(63, 20);
            lbl.TabIndex = 3;
            lbl.Text = "Student:";
            // 
            // cbStudent
            // 
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(325, 194);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(293, 28);
            cbStudent.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(634, 193);
            button1.Name = "button1";
            button1.Size = new Size(174, 29);
            button1.TabIndex = 5;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvPrisustva
            // 
            dgvPrisustva.AllowUserToAddRows = false;
            dgvPrisustva.AllowUserToDeleteRows = false;
            dgvPrisustva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustva.Columns.AddRange(new DataGridViewColumn[] { Nastava, Student });
            dgvPrisustva.Location = new Point(12, 237);
            dgvPrisustva.Name = "dgvPrisustva";
            dgvPrisustva.ReadOnly = true;
            dgvPrisustva.RowHeadersWidth = 51;
            dgvPrisustva.RowTemplate.Height = 29;
            dgvPrisustva.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrisustva.Size = new Size(796, 206);
            dgvPrisustva.TabIndex = 6;
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
            // cbNastave
            // 
            cbNastave.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNastave.FormattingEnabled = true;
            cbNastave.Location = new Point(12, 193);
            cbNastave.Name = "cbNastave";
            cbNastave.Size = new Size(284, 28);
            cbNastave.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 461);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 227);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 82);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 0;
            label3.Text = "Info:";
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(106, 35);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(98, 27);
            txtBroj.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(224, 33);
            button2.Name = "button2";
            button2.Size = new Size(152, 29);
            button2.TabIndex = 2;
            button2.Text = "Generiši";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(15, 105);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(752, 102);
            txtInfo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 42);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 0;
            label4.Text = "Broj zapisa:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPrisustvoIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 700);
            Controls.Add(groupBox1);
            Controls.Add(cbNastave);
            Controls.Add(dgvPrisustva);
            Controls.Add(button1);
            Controls.Add(cbStudent);
            Controls.Add(lbl);
            Controls.Add(label2);
            Controls.Add(lblOd);
            Controls.Add(lblDo);
            Controls.Add(label1);
            Controls.Add(lblProstorija);
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

        private Label lblProstorija;
        private Label label1;
        private Label label2;
        private Label lblDo;
        private Label lblOd;
        private Label lbl;
        private ComboBox cbStudent;
        private Button button1;
        private DataGridView dgvPrisustva;
        private DataGridViewTextBoxColumn Nastava;
        private DataGridViewTextBoxColumn Student;
        private ComboBox cbNastave;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private Button button2;
        private TextBox txtBroj;
        private Label label4;
        private Label label3;
        private ErrorProvider err;
    }
}