namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmNoviScanIspita
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
            cmbPredmeti = new ComboBox();
            label2 = new Label();
            txtNapomena = new TextBox();
            label3 = new Label();
            pbSlika = new PictureBox();
            cbVaranje = new CheckBox();
            btnSpasi = new Button();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Predmet:";
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(29, 56);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(262, 28);
            cmbPredmeti.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 102);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            txtNapomena.Location = new Point(29, 125);
            txtNapomena.Multiline = true;
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(262, 256);
            txtNapomena.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 33);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Slika:";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(307, 56);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(247, 325);
            pbSlika.TabIndex = 5;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // cbVaranje
            // 
            cbVaranje.AutoSize = true;
            cbVaranje.Location = new Point(29, 397);
            cbVaranje.Name = "cbVaranje";
            cbVaranje.Size = new Size(140, 24);
            cbVaranje.TabIndex = 6;
            cbVaranje.Text = "Varanje na ispitu";
            cbVaranje.UseVisualStyleBackColor = true;
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(460, 397);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(94, 29);
            btnSpasi.TabIndex = 7;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNoviScanIspita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 450);
            Controls.Add(btnSpasi);
            Controls.Add(cbVaranje);
            Controls.Add(pbSlika);
            Controls.Add(label3);
            Controls.Add(txtNapomena);
            Controls.Add(label2);
            Controls.Add(cmbPredmeti);
            Controls.Add(label1);
            Name = "frmNoviScanIspita";
            Text = "frmNoviScanIspita";
            Load += frmNoviScanIspita_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPredmeti;
        private Label label2;
        private TextBox txtNapomena;
        private Label label3;
        private PictureBox pbSlika;
        private CheckBox cbVaranje;
        private Button btnSpasi;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}