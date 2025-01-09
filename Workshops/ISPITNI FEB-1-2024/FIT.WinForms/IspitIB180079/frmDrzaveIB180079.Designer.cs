namespace FIT.WinForms.IspitIB180079
{
    partial class frmDrzaveIB180079
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
            statusStrip1 = new StatusStrip();
            tslVrijeme = new ToolStripStatusLabel();
            timer = new System.Windows.Forms.Timer(components);
            dgvDrzave = new DataGridView();
            Zastava = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Broj = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Gradovi = new DataGridViewButtonColumn();
            button1 = new Button();
            button2 = new Button();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslVrijeme });
            statusStrip1.Location = new Point(0, 417);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(917, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslVrijeme
            // 
            tslVrijeme.Name = "tslVrijeme";
            tslVrijeme.Size = new Size(151, 20);
            tslVrijeme.Text = "toolStripStatusLabel1";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // dgvDrzave
            // 
            dgvDrzave.AllowUserToAddRows = false;
            dgvDrzave.AllowUserToDeleteRows = false;
            dgvDrzave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzave.Columns.AddRange(new DataGridViewColumn[] { Zastava, Naziv, Broj, Aktivan, Gradovi });
            dgvDrzave.Location = new Point(12, 54);
            dgvDrzave.Margin = new Padding(3, 4, 3, 4);
            dgvDrzave.Name = "dgvDrzave";
            dgvDrzave.ReadOnly = true;
            dgvDrzave.RowHeadersWidth = 51;
            dgvDrzave.RowTemplate.Height = 25;
            dgvDrzave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrzave.Size = new Size(889, 292);
            dgvDrzave.TabIndex = 1;
            dgvDrzave.CellClick += dgvDrzave_CellClick;
            dgvDrzave.CellContentClick += dgvDrzave_CellContentClick;
            // 
            // Zastava
            // 
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Zastava.MinimumWidth = 6;
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            Zastava.Width = 60;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Država";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Broj
            // 
            Broj.DataPropertyName = "BrojGradova";
            Broj.HeaderText = "Broj gradova";
            Broj.MinimumWidth = 6;
            Broj.Name = "Broj";
            Broj.ReadOnly = true;
            Broj.Width = 125;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Status";
            Aktivan.HeaderText = "Aktivna";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Resizable = DataGridViewTriState.True;
            Aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            Aktivan.Width = 125;
            // 
            // Gradovi
            // 
            Gradovi.HeaderText = "";
            Gradovi.MinimumWidth = 6;
            Gradovi.Name = "Gradovi";
            Gradovi.ReadOnly = true;
            Gradovi.Text = "Gradovi";
            Gradovi.UseColumnTextForButtonValue = true;
            Gradovi.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(752, 15);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(149, 31);
            button1.TabIndex = 2;
            button1.Text = "Nova država";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(752, 354);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(149, 31);
            button2.TabIndex = 2;
            button2.Text = "Printaj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmDrzaveIB180079
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 443);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvDrzave);
            Controls.Add(statusStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDrzaveIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drzave";
            Load += frmDrzaveIB180079_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer;
        private ToolStripStatusLabel tslVrijeme;
        private DataGridView dgvDrzave;
        private Button button1;
        private Button button2;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Broj;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Gradovi;
    }
}