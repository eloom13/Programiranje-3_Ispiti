namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmStudenti
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
            txtFilterImePrezime = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dgvStudenti = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            GodinaStudija = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Polozeni = new DataGridViewButtonColumn();
            label4 = new Label();
            lblBrojStudenata = new Label();
            lblProsjek = new Label();
            btnPrintaj = new Button();
            cmbGodineStudija = new ComboBox();
            cmbAktivnosti = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 40);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime ili prezime:";
            // 
            // txtFilterImePrezime
            // 
            txtFilterImePrezime.Location = new Point(143, 37);
            txtFilterImePrezime.Name = "txtFilterImePrezime";
            txtFilterImePrezime.Size = new Size(281, 27);
            txtFilterImePrezime.TabIndex = 1;
            txtFilterImePrezime.TextChanged += txtFilterImePrezime_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 40);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Godina studija:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(782, 40);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Aktivnost:";
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Indeks, Ime, Prezime, Spol, GodinaStudija, Aktivan, Polozeni });
            dgvStudenti.Location = new Point(12, 82);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.Size = new Size(986, 371);
            dgvStudenti.TabIndex = 6;
            // 
            // Indeks
            // 
            Indeks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Indeks.DataPropertyName = "BrojIndeksa";
            Indeks.HeaderText = "Indeks";
            Indeks.MinimumWidth = 6;
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.MinimumWidth = 6;
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.MinimumWidth = 6;
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // Spol
            // 
            Spol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Spol.DataPropertyName = "Spol";
            Spol.HeaderText = "Spol";
            Spol.MinimumWidth = 6;
            Spol.Name = "Spol";
            Spol.ReadOnly = true;
            // 
            // GodinaStudija
            // 
            GodinaStudija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GodinaStudija.DataPropertyName = "GodinaStudija";
            GodinaStudija.HeaderText = "Godina studija";
            GodinaStudija.MinimumWidth = 6;
            GodinaStudija.Name = "GodinaStudija";
            GodinaStudija.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Resizable = DataGridViewTriState.True;
            Aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Polozeni
            // 
            Polozeni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Polozeni.HeaderText = "Polozeni";
            Polozeni.MinimumWidth = 6;
            Polozeni.Name = "Polozeni";
            Polozeni.ReadOnly = true;
            Polozeni.Text = "Polozeni";
            Polozeni.UseColumnTextForButtonValue = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 473);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 7;
            label4.Text = "Broj studenata:";
            // 
            // lblBrojStudenata
            // 
            lblBrojStudenata.AutoSize = true;
            lblBrojStudenata.Location = new Point(143, 473);
            lblBrojStudenata.Name = "lblBrojStudenata";
            lblBrojStudenata.Size = new Size(0, 20);
            lblBrojStudenata.TabIndex = 8;
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Location = new Point(155, 504);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(0, 20);
            lblProsjek.TabIndex = 10;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(904, 469);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 11;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // cmbGodineStudija
            // 
            cmbGodineStudija.FormattingEnabled = true;
            cmbGodineStudija.Location = new Point(571, 36);
            cmbGodineStudija.Name = "cmbGodineStudija";
            cmbGodineStudija.Size = new Size(166, 28);
            cmbGodineStudija.TabIndex = 12;
            cmbGodineStudija.SelectedIndexChanged += cmbGodineStudija_SelectedIndexChanged;
            // 
            // cmbAktivnosti
            // 
            cmbAktivnosti.FormattingEnabled = true;
            cmbAktivnosti.Location = new Point(861, 36);
            cmbAktivnosti.Name = "cmbAktivnosti";
            cmbAktivnosti.Size = new Size(137, 28);
            cmbAktivnosti.TabIndex = 13;
            cmbAktivnosti.SelectedIndexChanged += cmbAktivnosti_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmStudenti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 514);
            Controls.Add(cmbAktivnosti);
            Controls.Add(cmbGodineStudija);
            Controls.Add(btnPrintaj);
            Controls.Add(lblProsjek);
            Controls.Add(lblBrojStudenata);
            Controls.Add(label4);
            Controls.Add(dgvStudenti);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFilterImePrezime);
            Controls.Add(label1);
            Name = "frmStudenti";
            Text = "Studenti";
            Load += frmStudenti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFilterImePrezime;
        private Label label2;
        private Label label3;
        private DataGridView dgvStudenti;
        private Label label4;
        private Label lblBrojStudenata;
        private Label lblProsjek;
        private Button btnPrintaj;
        private ComboBox cmbGodineStudija;
        private ComboBox cmbAktivnosti;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewTextBoxColumn GodinaStudija;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Polozeni;
        private ErrorProvider errorProvider1;
    }
}