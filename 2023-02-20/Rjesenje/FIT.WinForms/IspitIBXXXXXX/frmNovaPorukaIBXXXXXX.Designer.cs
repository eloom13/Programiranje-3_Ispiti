namespace FIT.WinForms.IspitIBXXXXXX
{
    partial class frmNovaPorukaIBXXXXXX
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
            cmbPredmet = new ComboBox();
            label2 = new Label();
            dtpDatum = new DateTimePicker();
            label3 = new Label();
            txtSadrzaj = new TextBox();
            label4 = new Label();
            pbSlika = new PictureBox();
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Odaberite predmet:";
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(12, 46);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(267, 28);
            cmbPredmet.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 87);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 2;
            label2.Text = "Poruka je validna do:";
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(12, 110);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(267, 27);
            dtpDatum.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "Sadrzaj";
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(12, 187);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(267, 108);
            txtSadrzaj.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 26);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 6;
            label4.Text = "Slika:";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(302, 49);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(269, 206);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 7;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(351, 269);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(95, 26);
            btnOdustani.TabIndex = 8;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(476, 269);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(95, 26);
            btnSacuvaj.TabIndex = 9;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNovaPorukaIBXXXXXX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 318);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnOdustani);
            Controls.Add(pbSlika);
            Controls.Add(label4);
            Controls.Add(txtSadrzaj);
            Controls.Add(label3);
            Controls.Add(dtpDatum);
            Controls.Add(label2);
            Controls.Add(cmbPredmet);
            Controls.Add(label1);
            Name = "frmNovaPorukaIBXXXXXX";
            Text = "frmNovaPorukaIBXXXXXX";
            Load += frmNovaPorukaIBXXXXXX_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPredmet;
        private Label label2;
        private DateTimePicker dtpDatum;
        private Label label3;
        private TextBox txtSadrzaj;
        private Label label4;
        private PictureBox pbSlika;
        private Button btnOdustani;
        private Button btnSacuvaj;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}