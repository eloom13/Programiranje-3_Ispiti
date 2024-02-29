namespace FIT.WinForms.IspitIBXXXXXX
{
    partial class frmPretraga
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
            txtNazivFilter = new TextBox();
            dgvPretraga = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            KorisnickoIme = new DataGridViewTextBoxColumn();
            Admin = new DataGridViewCheckBoxColumn();
            Polozeni = new DataGridViewButtonColumn();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            SuspendLayout();
            // 
            // txtNazivFilter
            // 
            txtNazivFilter.Location = new Point(20, 29);
            txtNazivFilter.Name = "txtNazivFilter";
            txtNazivFilter.Size = new Size(1049, 27);
            txtNazivFilter.TabIndex = 0;
            txtNazivFilter.TextChanged += txtNazivFilter_TextChanged;
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, Spol, KorisnickoIme, Admin, Polozeni });
            dgvPretraga.Location = new Point(20, 76);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowHeadersWidth = 51;
            dgvPretraga.RowTemplate.Height = 29;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(1049, 362);
            dgvPretraga.TabIndex = 1;
            dgvPretraga.CellClick += dgvPretraga_CellClick;
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
            // KorisnickoIme
            // 
            KorisnickoIme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            KorisnickoIme.DataPropertyName = "KorisnickoIme";
            KorisnickoIme.HeaderText = "Korisnicko Ime";
            KorisnickoIme.MinimumWidth = 6;
            KorisnickoIme.Name = "KorisnickoIme";
            KorisnickoIme.ReadOnly = true;
            // 
            // Admin
            // 
            Admin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Admin.DataPropertyName = "Admin";
            Admin.HeaderText = "Admin";
            Admin.MinimumWidth = 6;
            Admin.Name = "Admin";
            Admin.ReadOnly = true;
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
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.ForeColor = Color.Red;
            lblProsjek.Location = new Point(30, 465);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(0, 20);
            lblProsjek.TabIndex = 2;
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 510);
            Controls.Add(lblProsjek);
            Controls.Add(dgvPretraga);
            Controls.Add(txtNazivFilter);
            Name = "frmPretraga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPretraga";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNazivFilter;
        private DataGridView dgvPretraga;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewTextBoxColumn KorisnickoIme;
        private DataGridViewCheckBoxColumn Admin;
        private DataGridViewButtonColumn Polozeni;
        private Label lblProsjek;
    }
}