namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmNovaPoruka
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
            txtPrimalac = new TextBox();
            label2 = new Label();
            txtSadrzaj = new TextBox();
            label3 = new Label();
            pbSlika = new PictureBox();
            btnSpasi = new Button();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Primalac:";
            // 
            // txtPrimalac
            // 
            txtPrimalac.Enabled = false;
            txtPrimalac.Location = new Point(12, 45);
            txtPrimalac.Name = "txtPrimalac";
            txtPrimalac.Size = new Size(283, 27);
            txtPrimalac.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Sadrzaj:";
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(12, 111);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.Size = new Size(283, 259);
            txtSadrzaj.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 22);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Slika:";
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(321, 46);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(280, 324);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 5;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(507, 380);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(94, 29);
            btnSpasi.TabIndex = 6;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaPoruka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 421);
            Controls.Add(btnSpasi);
            Controls.Add(pbSlika);
            Controls.Add(label3);
            Controls.Add(txtSadrzaj);
            Controls.Add(label2);
            Controls.Add(txtPrimalac);
            Controls.Add(label1);
            Name = "frmNovaPoruka";
            Text = "frmNovaPoruka";
            Load += frmNovaPoruka_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPrimalac;
        private Label label2;
        private TextBox txtSadrzaj;
        private Label label3;
        private PictureBox pbSlika;
        private Button btnSpasi;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}