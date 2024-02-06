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
            button1 = new Button();
            button2 = new Button();
            Zastava = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Broj = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Gradovi = new DataGridViewButtonColumn();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslVrijeme });
            statusStrip1.Location = new Point(0, 310);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(802, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslVrijeme
            // 
            tslVrijeme.Name = "tslVrijeme";
            tslVrijeme.Size = new Size(118, 17);
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
            dgvDrzave.Location = new Point(12, 57);
            dgvDrzave.Name = "dgvDrzave";
            dgvDrzave.ReadOnly = true;
            dgvDrzave.RowTemplate.Height = 25;
            dgvDrzave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrzave.Size = new Size(778, 219);
            dgvDrzave.TabIndex = 1;
            dgvDrzave.CellClick += dgvDrzave_CellClick;
            dgvDrzave.CellContentClick += dgvDrzave_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(660, 28);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 2;
            button1.Text = "Nova država";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(660, 282);
            button2.Name = "button2";
            button2.Size = new Size(130, 23);
            button2.TabIndex = 2;
            button2.Text = "Printaj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Zastava
            // 
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            Zastava.Width = 60;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Država";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Broj
            // 
            Broj.DataPropertyName = "BrojGradova";
            Broj.HeaderText = "Broj gradova";
            Broj.Name = "Broj";
            Broj.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Status";
            Aktivan.HeaderText = "Aktivna";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Resizable = DataGridViewTriState.True;
            Aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Gradovi
            // 
            Gradovi.HeaderText = "";
            Gradovi.Name = "Gradovi";
            Gradovi.ReadOnly = true;
            Gradovi.Text = "Gradovi";
            Gradovi.UseColumnTextForButtonValue = true;
            // 
            // frmDrzaveIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 332);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvDrzave);
            Controls.Add(statusStrip1);
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