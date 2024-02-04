namespace FIT.WinForms.IspitIB180079
{
    partial class frmNovaDrzavaIB180079
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
            label1 = new Label();
            pbZastava = new PictureBox();
            label2 = new Label();
            txtNaziv = new TextBox();
            err = new ErrorProvider(components);
            chbAktivan = new CheckBox();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Zastava : ";
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 38);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(306, 170);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 1;
            pbZastava.TabStop = false;
            pbZastava.DoubleClick += pbZastava_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 223);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Naziv :";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(12, 241);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(306, 23);
            txtNaziv.TabIndex = 2;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Location = new Point(12, 270);
            chbAktivan.Name = "chbAktivan";
            chbAktivan.Size = new Size(66, 19);
            chbAktivan.TabIndex = 3;
            chbAktivan.Text = "Aktivna";
            chbAktivan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(219, 295);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 4;
            button1.Text = "Sačuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaDrzavaIB180079
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 329);
            Controls.Add(button1);
            Controls.Add(chbAktivan);
            Controls.Add(txtNaziv);
            Controls.Add(pbZastava);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaDrzavaIB180079";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o državi";
            Load += frmNovaDrzavaIB180079_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbZastava;
        private Label label2;
        private TextBox txtNaziv;
        private ErrorProvider err;
        private Button button1;
        private CheckBox chbAktivan;
        private OpenFileDialog openFileDialog1;
    }
}