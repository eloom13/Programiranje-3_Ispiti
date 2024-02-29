namespace FIT.WinForms.IspitIBXXXXXX
{
    partial class frmSeminarski
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
            lblStudentInfo = new Label();
            lblPredmetInfo = new Label();
            label1 = new Label();
            pbSlika = new PictureBox();
            label2 = new Label();
            txtOpis = new TextBox();
            btnDodaj = new Button();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            pbSlikaPregled = new PictureBox();
            btnPrevious = new Button();
            btnNext = new Button();
            lblSlikeInfo = new Label();
            lblOpis = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlikaPregled).BeginInit();
            SuspendLayout();
            // 
            // lblStudentInfo
            // 
            lblStudentInfo.AutoSize = true;
            lblStudentInfo.Location = new Point(211, 37);
            lblStudentInfo.Name = "lblStudentInfo";
            lblStudentInfo.Size = new Size(50, 20);
            lblStudentInfo.TabIndex = 0;
            lblStudentInfo.Text = "label1";
            // 
            // lblPredmetInfo
            // 
            lblPredmetInfo.AutoSize = true;
            lblPredmetInfo.Location = new Point(211, 89);
            lblPredmetInfo.Name = "lblPredmetInfo";
            lblPredmetInfo.Size = new Size(50, 20);
            lblPredmetInfo.TabIndex = 1;
            lblPredmetInfo.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 157);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 2;
            label1.Text = "Slika:";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(20, 190);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(175, 145);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 3;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 157);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Opis:";
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(222, 190);
            txtOpis.Multiline = true;
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(242, 61);
            txtOpis.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(222, 293);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(138, 30);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pbSlikaPregled
            // 
            pbSlikaPregled.Location = new Point(150, 424);
            pbSlikaPregled.Name = "pbSlikaPregled";
            pbSlikaPregled.Size = new Size(172, 163);
            pbSlikaPregled.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlikaPregled.TabIndex = 7;
            pbSlikaPregled.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(32, 479);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(87, 50);
            btnPrevious.TabIndex = 8;
            btnPrevious.Text = "<=";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(348, 479);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(87, 50);
            btnNext.TabIndex = 9;
            btnNext.Text = ">=";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblSlikeInfo
            // 
            lblSlikeInfo.AutoSize = true;
            lblSlikeInfo.Location = new Point(202, 388);
            lblSlikeInfo.Name = "lblSlikeInfo";
            lblSlikeInfo.Size = new Size(50, 20);
            lblSlikeInfo.TabIndex = 10;
            lblSlikeInfo.Text = "label3";
            // 
            // lblOpis
            // 
            lblOpis.AutoSize = true;
            lblOpis.Location = new Point(202, 611);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(0, 20);
            lblOpis.TabIndex = 11;
            // 
            // frmSeminarski
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 707);
            Controls.Add(lblOpis);
            Controls.Add(lblSlikeInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(pbSlikaPregled);
            Controls.Add(btnDodaj);
            Controls.Add(txtOpis);
            Controls.Add(label2);
            Controls.Add(pbSlika);
            Controls.Add(label1);
            Controls.Add(lblPredmetInfo);
            Controls.Add(lblStudentInfo);
            Name = "frmSeminarski";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSeminarski";
            Load += frmSeminarski_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlikaPregled).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentInfo;
        private Label lblPredmetInfo;
        private Label label1;
        private PictureBox pbSlika;
        private Label label2;
        private TextBox txtOpis;
        private Button btnDodaj;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
        private PictureBox pbSlikaPregled;
        private Button btnNext;
        private Button btnPrevious;
        private Label lblSlikeInfo;
        private Label lblOpis;
    }
}