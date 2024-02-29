namespace FIT.WinForms.IspitIBXXXXXX
{
    partial class frmNovaDrzavaIBXXXXXX
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
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            label2 = new Label();
            txtNaziv = new TextBox();
            cbStatus = new CheckBox();
            btnSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Zastava";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(12, 57);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(344, 130);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 1;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 204);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(12, 227);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(344, 27);
            txtNaziv.TabIndex = 3;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(15, 282);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(80, 24);
            cbStatus.TabIndex = 4;
            cbStatus.Text = "Aktivna";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(239, 319);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(117, 36);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmNovaDrzavaIBXXXXXX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 367);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbStatus);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(pbSlika);
            Controls.Add(label1);
            Name = "frmNovaDrzavaIBXXXXXX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNovaDrzavaIBXXXXXX";
            Load += frmNovaDrzavaIBXXXXXX_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbSlika;
        private ErrorProvider errorProvider1;
        private Button btnSacuvaj;
        private CheckBox cbStatus;
        private TextBox txtNaziv;
        private Label label2;
        private OpenFileDialog openFileDialog1;
    }
}