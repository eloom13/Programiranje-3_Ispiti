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
            label1 = new Label();
            cmbOcjena = new ComboBox();
            btnPretraga = new Button();
            dgvPretraga = new DataGridView();
            Rb = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            Seminarski = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            btnPrintaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Maksimalna ocjena:";
            // 
            // cmbOcjena
            // 
            cmbOcjena.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjena.FormattingEnabled = true;
            cmbOcjena.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjena.Location = new Point(168, 24);
            cmbOcjena.Name = "cmbOcjena";
            cmbOcjena.Size = new Size(144, 28);
            cmbOcjena.TabIndex = 1;
            // 
            // btnPretraga
            // 
            btnPretraga.Location = new Point(363, 24);
            btnPretraga.Name = "btnPretraga";
            btnPretraga.Size = new Size(141, 29);
            btnPretraga.TabIndex = 2;
            btnPretraga.Text = "Pretraga";
            btnPretraga.UseVisualStyleBackColor = true;
            btnPretraga.Click += btnPretraga_Click;
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { Rb, ImePrezime, Predmet, Ocjena, DatumPolaganja, Seminarski });
            dgvPretraga.Location = new Point(23, 82);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowHeadersWidth = 51;
            dgvPretraga.RowTemplate.Height = 29;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(990, 248);
            dgvPretraga.TabIndex = 3;
            dgvPretraga.CellClick += dgvPretraga_CellClick;
            // 
            // Rb
            // 
            Rb.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Rb.DataPropertyName = "Rb";
            Rb.HeaderText = "Rb";
            Rb.MinimumWidth = 6;
            Rb.Name = "Rb";
            Rb.ReadOnly = true;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime Prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
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
            DatumPolaganja.HeaderText = "Datum Polaganja";
            DatumPolaganja.MinimumWidth = 6;
            DatumPolaganja.Name = "DatumPolaganja";
            DatumPolaganja.ReadOnly = true;
            // 
            // Seminarski
            // 
            Seminarski.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Seminarski.HeaderText = "Seminarski";
            Seminarski.MinimumWidth = 6;
            Seminarski.Name = "Seminarski";
            Seminarski.ReadOnly = true;
            Seminarski.Text = "Seminarski";
            Seminarski.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(23, 359);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(724, 265);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(845, 378);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(120, 31);
            btnPrintaj.TabIndex = 5;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 655);
            Controls.Add(btnPrintaj);
            Controls.Add(groupBox1);
            Controls.Add(dgvPretraga);
            Controls.Add(btnPretraga);
            Controls.Add(cmbOcjena);
            Controls.Add(label1);
            Name = "frmPretraga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPretraga";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbOcjena;
        private Button btnPretraga;
        private DataGridView dgvPretraga;
        private DataGridViewTextBoxColumn Rb;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn DatumPolaganja;
        private DataGridViewButtonColumn Seminarski;
        private GroupBox groupBox1;
        private Button btnPrintaj;
    }
}