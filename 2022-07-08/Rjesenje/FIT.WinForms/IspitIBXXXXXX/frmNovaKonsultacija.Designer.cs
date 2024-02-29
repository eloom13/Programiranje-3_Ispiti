namespace FIT.WinForms.IspitIBXXXXXX
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
            label2 = new Label();
            label3 = new Label();
            txtNapomena = new TextBox();
            cmbPredmet = new ComboBox();
            dtpVrijemeOdrzavanja = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            btnOdustani = new Button();
            btnSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 42);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Odaberite predmet:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 42);
            label2.Name = "label2";
            label2.Size = new Size(214, 20);
            label2.TabIndex = 1;
            label2.Text = "Odaberite vrijeme konsultacija:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 148);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 2;
            label3.Text = "Unesite napomenu:";
            // 
            // txtNapomena
            // 
            txtNapomena.Location = new Point(38, 190);
            txtNapomena.Multiline = true;
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(740, 189);
            txtNapomena.TabIndex = 3;
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(38, 74);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(238, 28);
            cmbPredmet.TabIndex = 4;
            // 
            // dtpVrijemeOdrzavanja
            // 
            dtpVrijemeOdrzavanja.Location = new Point(494, 72);
            dtpVrijemeOdrzavanja.Name = "dtpVrijemeOdrzavanja";
            dtpVrijemeOdrzavanja.Size = new Size(284, 27);
            dtpVrijemeOdrzavanja.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(551, 410);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(94, 29);
            btnOdustani.TabIndex = 6;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(684, 410);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 7;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmNovaKonsultacija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 462);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnOdustani);
            Controls.Add(dtpVrijemeOdrzavanja);
            Controls.Add(cmbPredmet);
            Controls.Add(txtNapomena);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private TextBox txtNapomena;
        private ComboBox cmbPredmet;
        private DateTimePicker dtpVrijemeOdrzavanja;
        private ErrorProvider errorProvider1;
        private Button btnSacuvaj;
        private Button btnOdustani;
    }
}