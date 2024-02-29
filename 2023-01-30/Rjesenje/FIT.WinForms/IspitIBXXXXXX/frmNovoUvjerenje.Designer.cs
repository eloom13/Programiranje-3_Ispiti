namespace FIT.WinForms.IspitIBXXXXXX
{
    partial class frmNovoUvjerenje
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
            cmbVrstaUvjerenja = new ComboBox();
            label2 = new Label();
            txtSvrhaRegulisanja = new TextBox();
            label3 = new Label();
            pbSlika = new PictureBox();
            btnSacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // cmbVrstaUvjerenja
            // 
            cmbVrstaUvjerenja.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrstaUvjerenja.FormattingEnabled = true;
            cmbVrstaUvjerenja.Items.AddRange(new object[] { "Uvjerenje o položenim ispitima", "Uvjerenje o statusu studenta" });
            cmbVrstaUvjerenja.Location = new Point(24, 37);
            cmbVrstaUvjerenja.Name = "cmbVrstaUvjerenja";
            cmbVrstaUvjerenja.Size = new Size(227, 28);
            cmbVrstaUvjerenja.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 85);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 2;
            label2.Text = "Svrha regulisanja:";
            // 
            // txtSvrhaRegulisanja
            // 
            txtSvrhaRegulisanja.Location = new Point(24, 112);
            txtSvrhaRegulisanja.Multiline = true;
            txtSvrhaRegulisanja.Name = "txtSvrhaRegulisanja";
            txtSvrhaRegulisanja.Size = new Size(227, 248);
            txtSvrhaRegulisanja.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 9);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 4;
            label3.Text = "Skenirana uplatnica:";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(277, 37);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(417, 256);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 5;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(589, 311);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(105, 34);
            btnSacuvaj.TabIndex = 6;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovoUvjerenje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 372);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbSlika);
            Controls.Add(label3);
            Controls.Add(txtSvrhaRegulisanja);
            Controls.Add(label2);
            Controls.Add(cmbVrstaUvjerenja);
            Controls.Add(label1);
            Name = "frmNovoUvjerenje";
            Text = "frmNovoUvjerenje";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbVrstaUvjerenja;
        private Label label2;
        private TextBox txtSvrhaRegulisanja;
        private Label label3;
        private PictureBox pbSlika;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}