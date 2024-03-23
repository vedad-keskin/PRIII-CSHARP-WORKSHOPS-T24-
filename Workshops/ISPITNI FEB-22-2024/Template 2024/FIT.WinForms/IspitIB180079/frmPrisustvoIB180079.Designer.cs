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
            err = new ErrorProvider(components);
            lblProstorija = new Label();
            label1 = new Label();
            label2 = new Label();
            cbNastava = new ComboBox();
            cbStudent = new ComboBox();
            button1 = new Button();
            lblOdDo = new Label();
            dgvNastava = new DataGridView();
            Info = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            button2 = new Button();
            txtBroj = new TextBox();
            label5 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNastava).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // lblProstorija
            // 
            lblProstorija.Font = new Font("Segoe UI", 16F);
            lblProstorija.Location = new Point(12, 9);
            lblProstorija.Name = "lblProstorija";
            lblProstorija.Size = new Size(416, 42);
            lblProstorija.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Nastava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 55);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Student:";
            // 
            // cbNastava
            // 
            cbNastava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNastava.FormattingEnabled = true;
            cbNastava.Location = new Point(12, 73);
            cbNastava.Name = "cbNastava";
            cbNastava.Size = new Size(236, 23);
            cbNastava.TabIndex = 2;
            cbNastava.SelectedIndexChanged += cbNastava_SelectedIndexChanged;
            // 
            // cbStudent
            // 
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.FormattingEnabled = true;
            cbStudent.Location = new Point(268, 73);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(236, 23);
            cbStudent.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(522, 73);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 3;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblOdDo
            // 
            lblOdDo.Font = new Font("Segoe UI", 16F);
            lblOdDo.Location = new Point(461, 9);
            lblOdDo.Name = "lblOdDo";
            lblOdDo.Size = new Size(149, 42);
            lblOdDo.TabIndex = 0;
            lblOdDo.TextAlign = ContentAlignment.TopRight;
            // 
            // dgvNastava
            // 
            dgvNastava.AllowUserToAddRows = false;
            dgvNastava.AllowUserToDeleteRows = false;
            dgvNastava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastava.Columns.AddRange(new DataGridViewColumn[] { Info, Student });
            dgvNastava.Location = new Point(12, 102);
            dgvNastava.Name = "dgvNastava";
            dgvNastava.ReadOnly = true;
            dgvNastava.RowTemplate.Height = 25;
            dgvNastava.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNastava.Size = new Size(598, 163);
            dgvNastava.TabIndex = 4;
            // 
            // Info
            // 
            Info.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Info.DataPropertyName = "Info";
            Info.HeaderText = "Predmet, prostorija, vrijeme";
            Info.Name = "Info";
            Info.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 281);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 171);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(16, 74);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(565, 91);
            txtInfo.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(209, 19);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 3;
            button2.Text = "Generiši";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(88, 20);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(100, 23);
            txtBroj.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 56);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 1;
            label5.Text = "Info:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 23);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 1;
            label3.Text = "Broj zapisa:";
            // 
            // frmPrisustvoIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 464);
            Controls.Add(groupBox1);
            Controls.Add(dgvNastava);
            Controls.Add(button1);
            Controls.Add(cbStudent);
            Controls.Add(cbNastava);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblOdDo);
            Controls.Add(lblProstorija);
            Name = "frmPrisustvoIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evidencija nastave";
            Load += frmPrisustvoIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNastava).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider err;
        private Button button1;
        private ComboBox cbStudent;
        private ComboBox cbNastava;
        private Label label2;
        private Label label1;
        private Label lblProstorija;
        private DataGridView dgvNastava;
        private Label lblOdDo;
        private DataGridViewTextBoxColumn Info;
        private DataGridViewTextBoxColumn Student;
        private GroupBox groupBox1;
        private TextBox txtBroj;
        private Label label3;
        private TextBox txtInfo;
        private Button button2;
        private Label label5;
    }
}