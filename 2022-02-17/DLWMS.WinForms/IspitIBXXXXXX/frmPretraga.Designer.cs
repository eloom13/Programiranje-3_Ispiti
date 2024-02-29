namespace DLWMS.WinForms.IspitIBXXXXXX
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
            txtFilterImePrezime = new TextBox();
            label2 = new Label();
            cmbGodinaStudija = new ComboBox();
            dgvPretraga = new DataGridView();
            ImePrezime = new DataGridViewTextBoxColumn();
            GodinaStudija = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            Konsultacije = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 35);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime ili prezime:";
            // 
            // txtFilterImePrezime
            // 
            txtFilterImePrezime.Location = new Point(145, 32);
            txtFilterImePrezime.Name = "txtFilterImePrezime";
            txtFilterImePrezime.Size = new Size(548, 27);
            txtFilterImePrezime.TabIndex = 1;
            txtFilterImePrezime.TextChanged += txtFilterImePrezime_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(739, 35);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Godina studija:";
            // 
            // cmbGodinaStudija
            // 
            cmbGodinaStudija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodinaStudija.FormattingEnabled = true;
            cmbGodinaStudija.Location = new Point(853, 32);
            cmbGodinaStudija.Name = "cmbGodinaStudija";
            cmbGodinaStudija.Size = new Size(182, 28);
            cmbGodinaStudija.TabIndex = 3;
            cmbGodinaStudija.SelectedIndexChanged += cmbGodinaStudija_SelectedIndexChanged;
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { ImePrezime, GodinaStudija, Prosjek, Konsultacije });
            dgvPretraga.Location = new Point(28, 87);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowHeadersWidth = 51;
            dgvPretraga.RowTemplate.Height = 29;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(1006, 339);
            dgvPretraga.TabIndex = 4;
            dgvPretraga.CellContentClick += dgvPretraga_CellContentClick;
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
            // GodinaStudija
            // 
            GodinaStudija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GodinaStudija.DataPropertyName = "GodinaStudija";
            GodinaStudija.HeaderText = "GodinaStudija";
            GodinaStudija.MinimumWidth = 6;
            GodinaStudija.Name = "GodinaStudija";
            GodinaStudija.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // Konsultacije
            // 
            Konsultacije.HeaderText = "Konsultacije";
            Konsultacije.MinimumWidth = 6;
            Konsultacije.Name = "Konsultacije";
            Konsultacije.ReadOnly = true;
            Konsultacije.Text = "Konsultacije";
            Konsultacije.UseColumnTextForButtonValue = true;
            Konsultacije.Width = 125;
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 450);
            Controls.Add(dgvPretraga);
            Controls.Add(cmbGodinaStudija);
            Controls.Add(label2);
            Controls.Add(txtFilterImePrezime);
            Controls.Add(label1);
            Name = "frmPretraga";
            Text = "frmPretraga";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFilterImePrezime;
        private Label label2;
        private ComboBox cmbGodinaStudija;
        private DataGridView dgvPretraga;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn GodinaStudija;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewButtonColumn Konsultacije;
    }
}