namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmPoruke
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
            lblKorisnik = new Label();
            dgvKorisniciPoruke = new DataGridView();
            Datum = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Brisi = new DataGridViewButtonColumn();
            btnNovaPoruka = new Button();
            btnPrintaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKorisniciPoruke).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 38);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Komunikacija sa:";
            // 
            // lblKorisnik
            // 
            lblKorisnik.AutoSize = true;
            lblKorisnik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKorisnik.Location = new Point(150, 34);
            lblKorisnik.Name = "lblKorisnik";
            lblKorisnik.Size = new Size(0, 28);
            lblKorisnik.TabIndex = 1;
            // 
            // dgvKorisniciPoruke
            // 
            dgvKorisniciPoruke.AllowUserToAddRows = false;
            dgvKorisniciPoruke.AllowUserToDeleteRows = false;
            dgvKorisniciPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKorisniciPoruke.Columns.AddRange(new DataGridViewColumn[] { Datum, Sadrzaj, Slika, Brisi });
            dgvKorisniciPoruke.Location = new Point(25, 100);
            dgvKorisniciPoruke.Name = "dgvKorisniciPoruke";
            dgvKorisniciPoruke.ReadOnly = true;
            dgvKorisniciPoruke.RowHeadersWidth = 51;
            dgvKorisniciPoruke.RowTemplate.Height = 29;
            dgvKorisniciPoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKorisniciPoruke.Size = new Size(763, 301);
            dgvKorisniciPoruke.TabIndex = 2;
            dgvKorisniciPoruke.CellContentClick += dgvKorisniciPoruke_CellContentClick;
            // 
            // Datum
            // 
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            Datum.Width = 125;
            // 
            // Sadrzaj
            // 
            Sadrzaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadrzaj";
            Sadrzaj.MinimumWidth = 6;
            Sadrzaj.Name = "Sadrzaj";
            Sadrzaj.ReadOnly = true;
            // 
            // Slika
            // 
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.MinimumWidth = 6;
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            Slika.Resizable = DataGridViewTriState.True;
            Slika.SortMode = DataGridViewColumnSortMode.Automatic;
            Slika.Width = 125;
            // 
            // Brisi
            // 
            Brisi.HeaderText = "Brisi";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Resizable = DataGridViewTriState.True;
            Brisi.SortMode = DataGridViewColumnSortMode.Automatic;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            Brisi.Width = 125;
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(645, 37);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(131, 29);
            btnNovaPoruka.TabIndex = 3;
            btnNovaPoruka.Text = "Nova poruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            btnNovaPoruka.Click += btnNovaPoruka_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(689, 417);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(99, 29);
            btnPrintaj.TabIndex = 4;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // frmPoruke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 458);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaPoruka);
            Controls.Add(dgvKorisniciPoruke);
            Controls.Add(lblKorisnik);
            Controls.Add(label1);
            Name = "frmPoruke";
            Text = "frmPorukeBrojIndeksa";
            Load += frmPorukeBrojIndeksa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKorisniciPoruke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblKorisnik;
        private DataGridView dgvKorisniciPoruke;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewImageColumn Slika;
        private DataGridViewButtonColumn Brisi;
        private Button btnNovaPoruka;
        private Button btnPrintaj;
    }
}