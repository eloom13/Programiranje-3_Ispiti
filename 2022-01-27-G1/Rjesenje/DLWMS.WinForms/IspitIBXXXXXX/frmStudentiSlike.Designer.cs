namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmStudentiSlike
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
            pbSlika = new PictureBox();
            label2 = new Label();
            txtOpis = new TextBox();
            btnDodajSliku = new Button();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            btnPrevious = new Button();
            btnNext = new Button();
            pbPregledSlika = new PictureBox();
            lblOpis = new Label();
            lblDatum = new Label();
            lblPretraga = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPregledSlika).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 32);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Slika:";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(29, 65);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(183, 173);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 1;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 32);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "Opis:";
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(329, 65);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(445, 123);
            txtOpis.TabIndex = 3;
            // 
            // btnDodajSliku
            // 
            btnDodajSliku.Location = new Point(680, 209);
            btnDodajSliku.Name = "btnDodajSliku";
            btnDodajSliku.Size = new Size(94, 29);
            btnDodajSliku.TabIndex = 4;
            btnDodajSliku.Text = "Dodaj sliku";
            btnDodajSliku.UseVisualStyleBackColor = true;
            btnDodajSliku.Click += btnDodajSliku_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(118, 480);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 5;
            btnPrevious.Text = "<=";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(551, 480);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 6;
            btnNext.Text = ">=";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // pbPregledSlika
            // 
            pbPregledSlika.Location = new Point(246, 377);
            pbPregledSlika.Name = "pbPregledSlika";
            pbPregledSlika.Size = new Size(274, 239);
            pbPregledSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPregledSlika.TabIndex = 7;
            pbPregledSlika.TabStop = false;
            // 
            // lblOpis
            // 
            lblOpis.AutoSize = true;
            lblOpis.Location = new Point(358, 641);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(0, 20);
            lblOpis.TabIndex = 8;
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(358, 681);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(0, 20);
            lblDatum.TabIndex = 9;
            // 
            // lblPretraga
            // 
            lblPretraga.AutoSize = true;
            lblPretraga.Location = new Point(358, 343);
            lblPretraga.Name = "lblPretraga";
            lblPretraga.Size = new Size(50, 20);
            lblPretraga.TabIndex = 10;
            lblPretraga.Text = "label3";
            // 
            // frmStudentiSlike
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 710);
            Controls.Add(lblPretraga);
            Controls.Add(lblDatum);
            Controls.Add(lblOpis);
            Controls.Add(pbPregledSlika);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnDodajSliku);
            Controls.Add(txtOpis);
            Controls.Add(label2);
            Controls.Add(pbSlika);
            Controls.Add(label1);
            Name = "frmStudentiSlike";
            Text = "frmStudentiSlike";
            Load += frmStudentiSlike_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPregledSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbSlika;
        private Label label2;
        private TextBox txtOpis;
        private Button btnDodajSliku;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
        private PictureBox pbPregledSlika;
        private Button btnNext;
        private Button btnPrevious;
        private Label lblOpis;
        private Label lblDatum;
        private Label lblPretraga;
    }
}