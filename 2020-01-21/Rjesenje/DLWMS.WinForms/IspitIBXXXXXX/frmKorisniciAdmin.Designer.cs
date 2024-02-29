namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmKorisniciAdmin
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
            dgvKorisnici = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            KorisnickoIme = new DataGridViewTextBoxColumn();
            Admin = new DataGridViewCheckBoxColumn();
            Polozeni = new DataGridViewButtonColumn();
            txtFilter = new TextBox();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).BeginInit();
            SuspendLayout();
            // 
            // dgvKorisnici
            // 
            dgvKorisnici.AllowUserToAddRows = false;
            dgvKorisnici.AllowUserToDeleteRows = false;
            dgvKorisnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKorisnici.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, Spol, KorisnickoIme, Admin, Polozeni });
            dgvKorisnici.Location = new Point(12, 97);
            dgvKorisnici.Name = "dgvKorisnici";
            dgvKorisnici.ReadOnly = true;
            dgvKorisnici.RowHeadersWidth = 51;
            dgvKorisnici.RowTemplate.Height = 29;
            dgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKorisnici.Size = new Size(958, 250);
            dgvKorisnici.TabIndex = 0;
            dgvKorisnici.CellContentClick += dgvKorisnici_CellContentClick;
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
            Spol.DataPropertyName = "Spol";
            Spol.HeaderText = "Spol";
            Spol.MinimumWidth = 6;
            Spol.Name = "Spol";
            Spol.ReadOnly = true;
            Spol.Width = 125;
            // 
            // KorisnickoIme
            // 
            KorisnickoIme.DataPropertyName = "KorisnickoIme";
            KorisnickoIme.HeaderText = "KorisnickoIme";
            KorisnickoIme.MinimumWidth = 6;
            KorisnickoIme.Name = "KorisnickoIme";
            KorisnickoIme.ReadOnly = true;
            KorisnickoIme.Width = 125;
            // 
            // Admin
            // 
            Admin.DataPropertyName = "Admin";
            Admin.HeaderText = "Admin";
            Admin.MinimumWidth = 6;
            Admin.Name = "Admin";
            Admin.ReadOnly = true;
            Admin.Width = 125;
            // 
            // Polozeni
            // 
            Polozeni.HeaderText = "Polozeni";
            Polozeni.MinimumWidth = 6;
            Polozeni.Name = "Polozeni";
            Polozeni.ReadOnly = true;
            Polozeni.Text = "Polozeni";
            Polozeni.UseColumnTextForButtonValue = true;
            Polozeni.Width = 125;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(12, 48);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(948, 27);
            txtFilter.TabIndex = 1;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Location = new Point(12, 377);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(0, 20);
            lblProsjek.TabIndex = 2;
            // 
            // frmKorisniciAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 418);
            Controls.Add(lblProsjek);
            Controls.Add(txtFilter);
            Controls.Add(dgvKorisnici);
            Name = "frmKorisniciAdmin";
            Text = "frmKorisniciAdmin";
            Load += frmKorisniciAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKorisnici;
        private TextBox txtFilter;
        private Label lblProsjek;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewTextBoxColumn KorisnickoIme;
        private DataGridViewCheckBoxColumn Admin;
        private DataGridViewButtonColumn Polozeni;
    }
}