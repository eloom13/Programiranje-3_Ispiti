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
            components = new System.ComponentModel.Container();
            dgvKorisniciPolozeniPredmeti = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Godina = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            btnPrintajUvjerenje = new Button();
            cmbPredmeti = new ComboBox();
            cmbOcjene = new ComboBox();
            dtpDatum = new DateTimePicker();
            btnSacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            cmbGodineStudija = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKorisniciPolozeniPredmeti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgvKorisniciPolozeniPredmeti
            // 
            dgvKorisniciPolozeniPredmeti.AllowUserToAddRows = false;
            dgvKorisniciPolozeniPredmeti.AllowUserToDeleteRows = false;
            dgvKorisniciPolozeniPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKorisniciPolozeniPredmeti.Columns.AddRange(new DataGridViewColumn[] { Predmet, Godina, Ocjena, Datum });
            dgvKorisniciPolozeniPredmeti.Location = new Point(12, 96);
            dgvKorisniciPolozeniPredmeti.Name = "dgvKorisniciPolozeniPredmeti";
            dgvKorisniciPolozeniPredmeti.ReadOnly = true;
            dgvKorisniciPolozeniPredmeti.RowHeadersWidth = 51;
            dgvKorisniciPolozeniPredmeti.RowTemplate.Height = 29;
            dgvKorisniciPolozeniPredmeti.Size = new Size(1015, 342);
            dgvKorisniciPolozeniPredmeti.TabIndex = 0;
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
            // Godina
            // 
            Godina.DataPropertyName = "GodinaStudija";
            Godina.HeaderText = "Godina";
            Godina.MinimumWidth = 6;
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            Godina.Width = 125;
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
            btnPrintajUvjerenje.Location = new Point(859, 451);
            btnPrintajUvjerenje.Name = "btnPrintajUvjerenje";
            btnPrintajUvjerenje.Size = new Size(156, 29);
            btnPrintajUvjerenje.TabIndex = 1;
            btnPrintajUvjerenje.Text = "Printaj Uvjerenje";
            btnPrintajUvjerenje.UseVisualStyleBackColor = true;
            btnPrintajUvjerenje.Click += btnPrintajUvjerenje_Click;
            // 
            // cmbPredmeti
            // 
            cmbPredmeti.FormattingEnabled = true;
            cmbPredmeti.Location = new Point(12, 38);
            cmbPredmeti.Name = "cmbPredmeti";
            cmbPredmeti.Size = new Size(267, 28);
            cmbPredmeti.TabIndex = 2;
            // 
            // cmbOcjene
            // 
            cmbOcjene.FormattingEnabled = true;
            cmbOcjene.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjene.Location = new Point(297, 38);
            cmbOcjene.Name = "cmbOcjene";
            cmbOcjene.Size = new Size(81, 28);
            cmbOcjene.TabIndex = 3;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(604, 39);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(272, 27);
            dtpDatum.TabIndex = 4;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(894, 38);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(121, 28);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // cmbGodineStudija
            // 
            cmbGodineStudija.FormattingEnabled = true;
            cmbGodineStudija.Location = new Point(392, 38);
            cmbGodineStudija.Name = "cmbGodineStudija";
            cmbGodineStudija.Size = new Size(203, 28);
            cmbGodineStudija.TabIndex = 6;
            // 
            // frmKorisniciPolozeniPredmeti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 492);
            Controls.Add(cmbGodineStudija);
            Controls.Add(btnSacuvaj);
            Controls.Add(dtpDatum);
            Controls.Add(cmbOcjene);
            Controls.Add(cmbPredmeti);
            Controls.Add(btnPrintajUvjerenje);
            Controls.Add(dgvKorisniciPolozeniPredmeti);
            Name = "frmKorisniciPolozeniPredmeti";
            Text = "frmKorisniciPolozeniPredmeti";
            Load += frmKorisniciPolozeniPredmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKorisniciPolozeniPredmeti).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKorisniciPolozeniPredmeti;
        private Button btnPrintajUvjerenje;
        private ComboBox cmbPredmeti;
        private ComboBox cmbOcjene;
        private DateTimePicker dtpDatum;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider1;
        private ComboBox cmbGodineStudija;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn Datum;
    }
}