namespace FIT.WinForms.IspitIBXXXXXX
{
    partial class frmPretragaIBXXXXXX
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
            cmbOcjenaOd = new ComboBox();
            label2 = new Label();
            cmbOcjenaDo = new ComboBox();
            label3 = new Label();
            dtpOd = new DateTimePicker();
            dtpDo = new DateTimePicker();
            label4 = new Label();
            dgvPretraga = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            lblInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Ocjena od";
            // 
            // cmbOcjenaOd
            // 
            cmbOcjenaOd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjenaOd.FormattingEnabled = true;
            cmbOcjenaOd.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjenaOd.Location = new Point(106, 23);
            cmbOcjenaOd.Name = "cmbOcjenaOd";
            cmbOcjenaOd.Size = new Size(85, 28);
            cmbOcjenaOd.TabIndex = 1;
            cmbOcjenaOd.SelectedIndexChanged += cmbOcjenaOd_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 28);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 2;
            label2.Text = "do";
            // 
            // cmbOcjenaDo
            // 
            cmbOcjenaDo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjenaDo.FormattingEnabled = true;
            cmbOcjenaDo.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjenaDo.Location = new Point(239, 23);
            cmbOcjenaDo.Name = "cmbOcjenaDo";
            cmbOcjenaDo.Size = new Size(85, 28);
            cmbOcjenaDo.TabIndex = 3;
            cmbOcjenaDo.SelectedIndexChanged += cmbOcjenaDo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 28);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 4;
            label3.Text = "polozena u periodu od";
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(509, 26);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(261, 27);
            dtpOd.TabIndex = 5;
            dtpOd.ValueChanged += dtpOd_ValueChanged;
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(836, 28);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(261, 27);
            dtpDo.TabIndex = 7;
            dtpDo.ValueChanged += dtpDo_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(793, 29);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 6;
            label4.Text = "do";
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { Indeks, ImePrezime, Predmet, Ocjena, DatumPolaganja, Poruke });
            dgvPretraga.Location = new Point(23, 91);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowHeadersWidth = 51;
            dgvPretraga.RowTemplate.Height = 29;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(1074, 368);
            dgvPretraga.TabIndex = 8;
            dgvPretraga.CellClick += dgvPretraga_CellClick;
            // 
            // Indeks
            // 
            Indeks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Indeks";
            Indeks.MinimumWidth = 6;
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i Prezime";
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
            DatumPolaganja.HeaderText = "Datum polaganja";
            DatumPolaganja.MinimumWidth = 6;
            DatumPolaganja.Name = "DatumPolaganja";
            DatumPolaganja.ReadOnly = true;
            // 
            // Poruke
            // 
            Poruke.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Poruke.HeaderText = "";
            Poruke.MinimumWidth = 6;
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Resizable = DataGridViewTriState.True;
            Poruke.SortMode = DataGridViewColumnSortMode.Automatic;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.ForeColor = Color.Red;
            lblInfo.Location = new Point(31, 58);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(50, 20);
            lblInfo.TabIndex = 9;
            lblInfo.Text = "label5";
            // 
            // frmPretragaIBXXXXXX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 468);
            Controls.Add(lblInfo);
            Controls.Add(dgvPretraga);
            Controls.Add(dtpDo);
            Controls.Add(label4);
            Controls.Add(dtpOd);
            Controls.Add(label3);
            Controls.Add(cmbOcjenaDo);
            Controls.Add(label2);
            Controls.Add(cmbOcjenaOd);
            Controls.Add(label1);
            Name = "frmPretragaIBXXXXXX";
            Text = "frmPretraga";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbOcjenaOd;
        private Label label2;
        private ComboBox cmbOcjenaDo;
        private Label label3;
        private DateTimePicker dtpOd;
        private DateTimePicker dtpDo;
        private Label label4;
        private DataGridView dgvPretraga;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn DatumPolaganja;
        private DataGridViewButtonColumn Poruke;
        private Label lblInfo;
    }
}