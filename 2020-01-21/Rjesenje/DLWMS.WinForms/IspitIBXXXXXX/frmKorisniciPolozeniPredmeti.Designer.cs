namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmKorisniciPolozeniPredmeti
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
            cmbOcjene = new ComboBox();
            dtpDatumPolaganja = new DateTimePicker();
            btnDodaj = new Button();
            cbNepolozeniPredmeti = new CheckBox();
            dgvKorisniciPolozeniPredmeti = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            btnPrintajUvjerenje = new Button();
            btnAsync = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKorisniciPolozeniPredmeti).BeginInit();
            SuspendLayout();
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(12, 49);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(240, 28);
            cmbPredmeti.TabIndex = 0;
            // 
            // cmbOcjene
            // 
            cmbOcjene.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjene.FormattingEnabled = true;
            cmbOcjene.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjene.Location = new Point(275, 49);
            cmbOcjene.Name = "cmbOcjene";
            cmbOcjene.Size = new Size(102, 28);
            cmbOcjene.TabIndex = 1;
            // 
            // dtpDatumPolaganja
            // 
            dtpDatumPolaganja.Location = new Point(397, 49);
            dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            dtpDatumPolaganja.Size = new Size(296, 27);
            dtpDatumPolaganja.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(710, 48);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(119, 29);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cbNepolozeniPredmeti
            // 
            cbNepolozeniPredmeti.AutoSize = true;
            cbNepolozeniPredmeti.Location = new Point(12, 95);
            cbNepolozeniPredmeti.Name = "cbNepolozeniPredmeti";
            cbNepolozeniPredmeti.Size = new Size(151, 24);
            cbNepolozeniPredmeti.TabIndex = 4;
            cbNepolozeniPredmeti.Text = "Ucitaj nepolozene";
            cbNepolozeniPredmeti.UseVisualStyleBackColor = true;
            cbNepolozeniPredmeti.CheckedChanged += cbNepolozeniPredmeti_CheckedChanged;
            // 
            // dgvKorisniciPolozeniPredmeti
            // 
            dgvKorisniciPolozeniPredmeti.AllowUserToAddRows = false;
            dgvKorisniciPolozeniPredmeti.AllowUserToDeleteRows = false;
            dgvKorisniciPolozeniPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKorisniciPolozeniPredmeti.Columns.AddRange(new DataGridViewColumn[] { Predmet, Ocjena, Datum });
            dgvKorisniciPolozeniPredmeti.Location = new Point(12, 131);
            dgvKorisniciPolozeniPredmeti.Name = "dgvKorisniciPolozeniPredmeti";
            dgvKorisniciPolozeniPredmeti.ReadOnly = true;
            dgvKorisniciPolozeniPredmeti.RowHeadersWidth = 51;
            dgvKorisniciPolozeniPredmeti.RowTemplate.Height = 29;
            dgvKorisniciPolozeniPredmeti.Size = new Size(817, 290);
            dgvKorisniciPolozeniPredmeti.TabIndex = 5;
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
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.MinimumWidth = 6;
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            Ocjena.Width = 125;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "DatumPolaganja";
            Datum.HeaderText = "Datum";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // btnPrintajUvjerenje
            // 
            btnPrintajUvjerenje.Location = new Point(698, 436);
            btnPrintajUvjerenje.Name = "btnPrintajUvjerenje";
            btnPrintajUvjerenje.Size = new Size(131, 29);
            btnPrintajUvjerenje.TabIndex = 6;
            btnPrintajUvjerenje.Text = "Printaj uvjerenje";
            btnPrintajUvjerenje.UseVisualStyleBackColor = true;
            btnPrintajUvjerenje.Click += btnPrintajUvjerenje_Click;
            // 
            // btnAsync
            // 
            btnAsync.Location = new Point(12, 441);
            btnAsync.Name = "btnAsync";
            btnAsync.Size = new Size(94, 29);
            btnAsync.TabIndex = 7;
            btnAsync.Text = "Run Async";
            btnAsync.UseVisualStyleBackColor = true;
            btnAsync.Click += btnAsync_Click;
            // 
            // frmKorisniciPolozeniPredmeti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 482);
            Controls.Add(btnAsync);
            Controls.Add(btnPrintajUvjerenje);
            Controls.Add(dgvKorisniciPolozeniPredmeti);
            Controls.Add(cbNepolozeniPredmeti);
            Controls.Add(btnDodaj);
            Controls.Add(dtpDatumPolaganja);
            Controls.Add(cmbOcjene);
            Controls.Add(cmbPredmeti);
            Name = "frmKorisniciPolozeniPredmeti";
            Text = "Polozeni predmeti korisnika";
            Load += frmKorisniciPolozeniPredmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKorisniciPolozeniPredmeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPredmeti;
        private ComboBox cmbOcjene;
        private DateTimePicker dtpDatumPolaganja;
        private Button btnDodaj;
        private CheckBox cbNepolozeniPredmeti;
        private DataGridView dgvKorisniciPolozeniPredmeti;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn Datum;
        private Button btnPrintajUvjerenje;
        private Button btnAsync;
    }
}