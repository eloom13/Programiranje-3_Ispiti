namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmCovidTest
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
            label1 = new Label();
            cmbStudenti = new ComboBox();
            label2 = new Label();
            dtpDatumTestiranja = new DateTimePicker();
            cmbRezultatTesta = new ComboBox();
            label3 = new Label();
            cbNalazDostavljen = new CheckBox();
            btnDodaj = new Button();
            dgvRezultati = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Rezultat = new DataGridViewTextBoxColumn();
            Dostavljen = new DataGridViewCheckBoxColumn();
            lblUkupanBroj = new Label();
            groupBox1 = new GroupBox();
            btnObrisiTestove = new Button();
            groupBox2 = new GroupBox();
            btnGenerisi = new Button();
            txtBrojTestova = new TextBox();
            label4 = new Label();
            btnPrintaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRezultati).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 23);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Student";
            // 
            // cmbStudenti
            // 
            cmbStudenti.FormattingEnabled = true;
            cmbStudenti.Location = new Point(31, 46);
            cmbStudenti.Name = "cmbStudenti";
            cmbStudenti.Size = new Size(190, 28);
            cmbStudenti.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 23);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 2;
            label2.Text = "Datum testiranja:";
            // 
            // dtpDatumTestiranja
            // 
            dtpDatumTestiranja.Location = new Point(256, 47);
            dtpDatumTestiranja.Name = "dtpDatumTestiranja";
            dtpDatumTestiranja.Size = new Size(250, 27);
            dtpDatumTestiranja.TabIndex = 3;
            // 
            // cmbRezultatTesta
            // 
            cmbRezultatTesta.FormattingEnabled = true;
            cmbRezultatTesta.Items.AddRange(new object[] { "Pozitivan", "Negativan" });
            cmbRezultatTesta.Location = new Point(542, 46);
            cmbRezultatTesta.Name = "cmbRezultatTesta";
            cmbRezultatTesta.Size = new Size(136, 28);
            cmbRezultatTesta.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(542, 23);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 4;
            label3.Text = "Rezultat testa:";
            // 
            // cbNalazDostavljen
            // 
            cbNalazDostavljen.AutoSize = true;
            cbNalazDostavljen.Location = new Point(702, 48);
            cbNalazDostavljen.Name = "cbNalazDostavljen";
            cbNalazDostavljen.Size = new Size(141, 24);
            cbNalazDostavljen.TabIndex = 6;
            cbNalazDostavljen.Text = "Nalaz dostavljen";
            cbNalazDostavljen.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(862, 41);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(129, 36);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvRezultati
            // 
            dgvRezultati.AllowUserToAddRows = false;
            dgvRezultati.AllowUserToDeleteRows = false;
            dgvRezultati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRezultati.Columns.AddRange(new DataGridViewColumn[] { Student, Datum, Rezultat, Dostavljen });
            dgvRezultati.Location = new Point(31, 92);
            dgvRezultati.Name = "dgvRezultati";
            dgvRezultati.ReadOnly = true;
            dgvRezultati.RowHeadersWidth = 51;
            dgvRezultati.RowTemplate.Height = 29;
            dgvRezultati.Size = new Size(960, 321);
            dgvRezultati.TabIndex = 8;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Rezultat
            // 
            Rezultat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Rezultat.DataPropertyName = "Rezultat";
            Rezultat.HeaderText = "Rezultat";
            Rezultat.MinimumWidth = 6;
            Rezultat.Name = "Rezultat";
            Rezultat.ReadOnly = true;
            // 
            // Dostavljen
            // 
            Dostavljen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dostavljen.DataPropertyName = "Dostavljen";
            Dostavljen.HeaderText = "Nalaz dostavljen";
            Dostavljen.MinimumWidth = 6;
            Dostavljen.Name = "Dostavljen";
            Dostavljen.ReadOnly = true;
            Dostavljen.Resizable = DataGridViewTriState.True;
            Dostavljen.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // lblUkupanBroj
            // 
            lblUkupanBroj.AutoSize = true;
            lblUkupanBroj.Location = new Point(31, 442);
            lblUkupanBroj.Name = "lblUkupanBroj";
            lblUkupanBroj.Size = new Size(0, 20);
            lblUkupanBroj.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnObrisiTestove);
            groupBox1.Location = new Point(582, 428);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 77);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Brisanje testova:";
            // 
            // btnObrisiTestove
            // 
            btnObrisiTestove.Location = new Point(25, 35);
            btnObrisiTestove.Name = "btnObrisiTestove";
            btnObrisiTestove.Size = new Size(206, 27);
            btnObrisiTestove.TabIndex = 0;
            btnObrisiTestove.Text = "OBRISI TESTOVE";
            btnObrisiTestove.UseVisualStyleBackColor = true;
            btnObrisiTestove.Click += btnObrisiTestove_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGenerisi);
            groupBox2.Controls.Add(txtBrojTestova);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(209, 428);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(339, 83);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Generisanje testova:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(239, 36);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 2;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // txtBrojTestova
            // 
            txtBrojTestova.Location = new Point(103, 36);
            txtBrojTestova.Name = "txtBrojTestova";
            txtBrojTestova.Size = new Size(125, 27);
            txtBrojTestova.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 38);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 0;
            label4.Text = "Broj testova:";
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(884, 462);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 12;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // frmCovidTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 523);
            Controls.Add(btnPrintaj);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblUkupanBroj);
            Controls.Add(dgvRezultati);
            Controls.Add(btnDodaj);
            Controls.Add(cbNalazDostavljen);
            Controls.Add(cmbRezultatTesta);
            Controls.Add(label3);
            Controls.Add(dtpDatumTestiranja);
            Controls.Add(label2);
            Controls.Add(cmbStudenti);
            Controls.Add(label1);
            Name = "frmCovidTest";
            Text = "frmCovidTest";
            Load += frmCovidTest_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRezultati).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbStudenti;
        private Label label2;
        private DateTimePicker dtpDatumTestiranja;
        private ComboBox cmbRezultatTesta;
        private Label label3;
        private CheckBox cbNalazDostavljen;
        private Button btnDodaj;
        private DataGridView dgvRezultati;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Rezultat;
        private DataGridViewCheckBoxColumn Dostavljen;
        private Label lblUkupanBroj;
        private GroupBox groupBox1;
        private Button btnObrisiTestove;
        private GroupBox groupBox2;
        private Button btnGenerisi;
        private TextBox txtBrojTestova;
        private Label label4;
        private Button btnPrintaj;
    }
}