namespace FIT.WinForms.IspitIBXXXXXX
{
    partial class frmPolozeniPredmeti
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
            cmbPredmeti = new ComboBox();
            cmbOcjena = new ComboBox();
            dtpDatum = new DateTimePicker();
            btnDodaj = new Button();
            cbNepolozeni = new CheckBox();
            dgvPolozeni = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            btnRunAsync = new Button();
            btnPrintaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPolozeni).BeginInit();
            SuspendLayout();
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(12, 23);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(241, 28);
            cmbPredmeti.TabIndex = 0;
            // 
            // cmbOcjena
            // 
            cmbOcjena.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjena.FormattingEnabled = true;
            cmbOcjena.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjena.Location = new Point(280, 23);
            cmbOcjena.Name = "cmbOcjena";
            cmbOcjena.Size = new Size(151, 28);
            cmbOcjena.TabIndex = 1;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(468, 24);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(303, 27);
            dtpDatum.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(795, 23);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(137, 28);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cbNepolozeni
            // 
            cbNepolozeni.AutoSize = true;
            cbNepolozeni.Location = new Point(12, 65);
            cbNepolozeni.Name = "cbNepolozeni";
            cbNepolozeni.Size = new Size(151, 24);
            cbNepolozeni.TabIndex = 4;
            cbNepolozeni.Text = "Ucitaj nepolozene";
            cbNepolozeni.UseVisualStyleBackColor = true;
            cbNepolozeni.CheckedChanged += cbNepolozeni_CheckedChanged;
            // 
            // dgvPolozeni
            // 
            dgvPolozeni.AllowUserToAddRows = false;
            dgvPolozeni.AllowUserToDeleteRows = false;
            dgvPolozeni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPolozeni.Columns.AddRange(new DataGridViewColumn[] { Predmet, Ocjena, DatumPolaganja });
            dgvPolozeni.Location = new Point(12, 112);
            dgvPolozeni.Name = "dgvPolozeni";
            dgvPolozeni.ReadOnly = true;
            dgvPolozeni.RowHeadersWidth = 51;
            dgvPolozeni.RowTemplate.Height = 29;
            dgvPolozeni.Size = new Size(920, 298);
            dgvPolozeni.TabIndex = 5;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            Ocjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.MinimumWidth = 6;
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            // 
            // DatumPolaganja
            // 
            DatumPolaganja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPolaganja.DataPropertyName = "DatumPolaganja";
            DatumPolaganja.HeaderText = "Datum";
            DatumPolaganja.MinimumWidth = 6;
            DatumPolaganja.Name = "DatumPolaganja";
            DatumPolaganja.ReadOnly = true;
            // 
            // btnRunAsync
            // 
            btnRunAsync.Location = new Point(12, 434);
            btnRunAsync.Name = "btnRunAsync";
            btnRunAsync.Size = new Size(94, 29);
            btnRunAsync.TabIndex = 6;
            btnRunAsync.Text = "Run Async";
            btnRunAsync.UseVisualStyleBackColor = true;
            btnRunAsync.Click += btnRunAsync_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(838, 434);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 7;
            btnPrintaj.Text = "Printaj uvjerenje";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // frmPolozeniPredmeti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 475);
            Controls.Add(btnPrintaj);
            Controls.Add(btnRunAsync);
            Controls.Add(dgvPolozeni);
            Controls.Add(cbNepolozeni);
            Controls.Add(btnDodaj);
            Controls.Add(dtpDatum);
            Controls.Add(cmbOcjena);
            Controls.Add(cmbPredmeti);
            Name = "frmPolozeniPredmeti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPolozeniPredmeti";
            Load += frmPolozeniPredmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPolozeni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPredmeti;
        private ComboBox cmbOcjena;
        private DateTimePicker dtpDatum;
        private Button btnDodaj;
        private CheckBox cbNepolozeni;
        private DataGridView dgvPolozeni;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn DatumPolaganja;
        private Button btnRunAsync;
        private Button btnPrintaj;
    }
}