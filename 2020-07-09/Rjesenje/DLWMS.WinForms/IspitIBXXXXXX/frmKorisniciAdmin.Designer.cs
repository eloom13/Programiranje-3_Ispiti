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
            txtFilter = new TextBox();
            cmbSpolovi = new ComboBox();
            cbAdministrator = new CheckBox();
            dgvKorisnici = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            KorisnickoIme = new DataGridViewTextBoxColumn();
            Administrator = new DataGridViewCheckBoxColumn();
            Slike = new DataGridViewButtonColumn();
            btnPrintajUvjerenje = new Button();
            txtThread = new TextBox();
            btnSuma = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).BeginInit();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(12, 29);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(606, 27);
            txtFilter.TabIndex = 0;
            // 
            // cmbSpolovi
            // 
            cmbSpolovi.FormattingEnabled = true;
            cmbSpolovi.Items.AddRange(new object[] { "Svi", "Zenski", "Muski" });
            cmbSpolovi.Location = new Point(657, 28);
            cmbSpolovi.Name = "cmbSpolovi";
            cmbSpolovi.Size = new Size(142, 28);
            cmbSpolovi.TabIndex = 1;
            // 
            // cbAdministrator
            // 
            cbAdministrator.AutoSize = true;
            cbAdministrator.Location = new Point(837, 29);
            cbAdministrator.Name = "cbAdministrator";
            cbAdministrator.Size = new Size(122, 24);
            cbAdministrator.TabIndex = 2;
            cbAdministrator.Text = "Administrator";
            cbAdministrator.UseVisualStyleBackColor = true;
            // 
            // dgvKorisnici
            // 
            dgvKorisnici.AllowUserToAddRows = false;
            dgvKorisnici.AllowUserToDeleteRows = false;
            dgvKorisnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKorisnici.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, Spol, KorisnickoIme, Administrator, Slike });
            dgvKorisnici.Location = new Point(12, 78);
            dgvKorisnici.Name = "dgvKorisnici";
            dgvKorisnici.ReadOnly = true;
            dgvKorisnici.RowHeadersWidth = 51;
            dgvKorisnici.RowTemplate.Height = 29;
            dgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKorisnici.Size = new Size(947, 285);
            dgvKorisnici.TabIndex = 3;
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
            KorisnickoIme.HeaderText = "Korisnicko ime";
            KorisnickoIme.MinimumWidth = 6;
            KorisnickoIme.Name = "KorisnickoIme";
            KorisnickoIme.ReadOnly = true;
            // 
            // Administrator
            // 
            Administrator.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Administrator.DataPropertyName = "Administrator";
            Administrator.HeaderText = "Administrator";
            Administrator.MinimumWidth = 6;
            Administrator.Name = "Administrator";
            Administrator.ReadOnly = true;
            Administrator.Resizable = DataGridViewTriState.True;
            Administrator.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Slike
            // 
            Slike.HeaderText = "";
            Slike.MinimumWidth = 6;
            Slike.Name = "Slike";
            Slike.ReadOnly = true;
            Slike.Resizable = DataGridViewTriState.True;
            Slike.SortMode = DataGridViewColumnSortMode.Automatic;
            Slike.Text = "Slike";
            Slike.UseColumnTextForButtonValue = true;
            Slike.Width = 125;
            // 
            // btnPrintajUvjerenje
            // 
            btnPrintajUvjerenje.Location = new Point(792, 378);
            btnPrintajUvjerenje.Name = "btnPrintajUvjerenje";
            btnPrintajUvjerenje.Size = new Size(167, 29);
            btnPrintajUvjerenje.TabIndex = 4;
            btnPrintajUvjerenje.Text = "Printaj uvjerenje";
            btnPrintajUvjerenje.UseVisualStyleBackColor = true;
            btnPrintajUvjerenje.Click += btnPrintajUvjerenje_Click;
            // 
            // txtThread
            // 
            txtThread.Location = new Point(12, 378);
            txtThread.Name = "txtThread";
            txtThread.Size = new Size(272, 27);
            txtThread.TabIndex = 5;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(301, 376);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(94, 29);
            btnSuma.TabIndex = 6;
            btnSuma.Text = "Suma";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // frmKorisniciAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 419);
            Controls.Add(btnSuma);
            Controls.Add(txtThread);
            Controls.Add(btnPrintajUvjerenje);
            Controls.Add(dgvKorisnici);
            Controls.Add(cbAdministrator);
            Controls.Add(cmbSpolovi);
            Controls.Add(txtFilter);
            Name = "frmKorisniciAdmin";
            Text = "frmKorisniciAdmin";
            Load += frmKorisniciAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilter;
        private ComboBox cmbSpolovi;
        private CheckBox cbAdministrator;
        private DataGridView dgvKorisnici;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewTextBoxColumn KorisnickoIme;
        private DataGridViewCheckBoxColumn Administrator;
        private DataGridViewButtonColumn Slike;
        private Button btnPrintajUvjerenje;
        private TextBox txtThread;
        private Button btnSuma;
    }
}