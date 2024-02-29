namespace FIT.WinForms.IspitIBXXXXXX
{
    partial class frmPorukeIBXXXXXX
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
            dgvPoruke = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Sadrzaj = new DataGridViewTextBoxColumn();
            Validnost = new DataGridViewTextBoxColumn();
            Slika = new DataGridViewImageColumn();
            Brisi = new DataGridViewButtonColumn();
            btnNovaPoruka = new Button();
            lblInfo = new Label();
            btnPrintaj = new Button();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            label4 = new Label();
            btnDodaj = new Button();
            dtpDatum = new DateTimePicker();
            label3 = new Label();
            cmbPredmet = new ComboBox();
            label2 = new Label();
            txtBrojPoruka = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPoruke
            // 
            dgvPoruke.AllowUserToAddRows = false;
            dgvPoruke.AllowUserToDeleteRows = false;
            dgvPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPoruke.Columns.AddRange(new DataGridViewColumn[] { Predmet, Sadrzaj, Validnost, Slika, Brisi });
            dgvPoruke.Location = new Point(12, 63);
            dgvPoruke.Name = "dgvPoruke";
            dgvPoruke.ReadOnly = true;
            dgvPoruke.RowHeadersWidth = 51;
            dgvPoruke.RowTemplate.Height = 29;
            dgvPoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPoruke.Size = new Size(959, 320);
            dgvPoruke.TabIndex = 0;
            dgvPoruke.CellClick += dgvPoruke_CellClick;
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
            // Sadrzaj
            // 
            Sadrzaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sadrzaj.DataPropertyName = "Sadrzaj";
            Sadrzaj.HeaderText = "Sadrzaj";
            Sadrzaj.MinimumWidth = 6;
            Sadrzaj.Name = "Sadrzaj";
            Sadrzaj.ReadOnly = true;
            // 
            // Validnost
            // 
            Validnost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Validnost.DataPropertyName = "Validnost";
            Validnost.HeaderText = "Validnost";
            Validnost.MinimumWidth = 6;
            Validnost.Name = "Validnost";
            Validnost.ReadOnly = true;
            // 
            // Slika
            // 
            Slika.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Slika.DataPropertyName = "Slika";
            Slika.HeaderText = "Slika";
            Slika.MinimumWidth = 6;
            Slika.Name = "Slika";
            Slika.ReadOnly = true;
            Slika.Resizable = DataGridViewTriState.True;
            Slika.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // btnNovaPoruka
            // 
            btnNovaPoruka.Location = new Point(793, 16);
            btnNovaPoruka.Name = "btnNovaPoruka";
            btnNovaPoruka.Size = new Size(178, 33);
            btnNovaPoruka.TabIndex = 1;
            btnNovaPoruka.Text = "Nova poruka";
            btnNovaPoruka.UseVisualStyleBackColor = true;
            btnNovaPoruka.Click += btnNovaPoruka_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(24, 22);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(50, 20);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "label1";
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(875, 394);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 3;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(dtpDatum);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbPredmet);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBrojPoruka);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 441);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(959, 285);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje poruka";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(312, 63);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(641, 216);
            txtInfo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 34);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 7;
            label4.Text = "Info:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(25, 241);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(250, 29);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj =>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(25, 191);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(250, 27);
            dtpDatum.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 163);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "Validna do:";
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(23, 123);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(252, 28);
            cmbPredmet.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 100);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Predmet";
            // 
            // txtBrojPoruka
            // 
            txtBrojPoruka.Location = new Point(25, 63);
            txtBrojPoruka.Name = "txtBrojPoruka";
            txtBrojPoruka.Size = new Size(250, 27);
            txtBrojPoruka.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Broj poruka:";
            // 
            // frmPorukeIBXXXXXX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 730);
            Controls.Add(groupBox1);
            Controls.Add(btnPrintaj);
            Controls.Add(lblInfo);
            Controls.Add(btnNovaPoruka);
            Controls.Add(dgvPoruke);
            Name = "frmPorukeIBXXXXXX";
            Text = "frmPorukeIBXXXXXX";
            Load += frmPorukeIBXXXXXX_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPoruke).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPoruke;
        private Button btnNovaPoruka;
        private Label lblInfo;
        private Button btnPrintaj;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Sadrzaj;
        private DataGridViewTextBoxColumn Validnost;
        private DataGridViewImageColumn Slika;
        private DataGridViewButtonColumn Brisi;
        private GroupBox groupBox1;
        private DateTimePicker dtpDatum;
        private Label label3;
        private ComboBox cmbPredmet;
        private Label label2;
        private TextBox txtBrojPoruka;
        private Label label1;
        private TextBox txtInfo;
        private Label label4;
        private Button btnDodaj;
    }
}