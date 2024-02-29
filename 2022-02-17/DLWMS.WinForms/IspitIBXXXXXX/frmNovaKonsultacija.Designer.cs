namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmNovaKonsultacija
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
            txtNapomena = new TextBox();
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Odaberite predmet:";
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(24, 65);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(332, 28);
            cmbPredmet.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 32);
            label2.Name = "label2";
            label2.Size = new Size(211, 20);
            label2.TabIndex = 2;
            label2.Text = "Odaberite vrijeme konsultacija";
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(456, 66);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(332, 27);
            dtpDatum.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 170);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 4;
            label3.Text = "Unesite napomenu:";
            // 
            // txtNapomena
            // 
            txtNapomena.Location = new Point(24, 204);
            txtNapomena.Multiline = true;
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(764, 144);
            txtNapomena.TabIndex = 5;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(556, 409);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(94, 29);
            btnOdustani.TabIndex = 6;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(694, 409);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 7;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNovaKonsultacija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnOdustani);
            Controls.Add(txtNapomena);
            Controls.Add(label3);
            Controls.Add(dtpDatum);
            Controls.Add(label2);
            Controls.Add(cmbPredmet);
            Controls.Add(label1);
            Name = "frmNovaKonsultacija";
            Text = "frmNovaKonsultacija";
            Load += frmNovaKonsultacija_Load;
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
        private TextBox txtNapomena;
        private Button btnOdustani;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider1;
    }
}