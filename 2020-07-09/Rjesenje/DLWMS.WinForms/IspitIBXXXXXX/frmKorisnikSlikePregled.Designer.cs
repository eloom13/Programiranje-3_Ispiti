namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmKorisnikSlikePregled
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
            btnPrevious = new Button();
            btnNext = new Button();
            pbSlika = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(25, 100);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 184);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(466, 100);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 184);
            btnNext.TabIndex = 1;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(152, 35);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(292, 317);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 2;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmKorisnikSlikePregled
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 377);
            Controls.Add(pbSlika);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Name = "frmKorisnikSlikePregled";
            Text = "frmKorisnikSlikePregled";
            Load += frmKorisnikSlikePregled_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrevious;
        private Button btnNext;
        private PictureBox pbSlika;
        private OpenFileDialog openFileDialog1;
    }
}