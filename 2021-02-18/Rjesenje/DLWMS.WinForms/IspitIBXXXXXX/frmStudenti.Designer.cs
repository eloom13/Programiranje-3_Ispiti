namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmStudenti
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
            label1 = new Label();
            dtpOd = new DateTimePicker();
            dtpDo = new DateTimePicker();
            label2 = new Label();
            cmbOperator = new ComboBox();
            label3 = new Label();
            cmbOcjene = new ComboBox();
            dgvStudenti = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Polozeni = new DataGridViewButtonColumn();
            lblUkupanBrojStudenata = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Od:";
            // 
            // dtpOd
            // 
            dtpOd.Location = new Point(59, 28);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(275, 27);
            dtpOd.TabIndex = 1;
            dtpOd.ValueChanged += dtpOd_ValueChanged;
            // 
            // dtpDo
            // 
            dtpDo.Location = new Point(407, 28);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(275, 27);
            dtpDo.TabIndex = 3;
            dtpDo.ValueChanged += dtpDo_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 33);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 2;
            label2.Text = "Do:";
            // 
            // cmbOperator
            // 
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Items.AddRange(new object[] { "=", ">", ">=", "<", "<=" });
            cmbOperator.Location = new Point(795, 30);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(102, 28);
            cmbOperator.TabIndex = 4;
            cmbOperator.SelectedIndexChanged += cmbVrijednost_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(731, 33);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 5;
            label3.Text = "Ocjena:";
            // 
            // cmbOcjene
            // 
            cmbOcjene.FormattingEnabled = true;
            cmbOcjene.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjene.Location = new Point(913, 30);
            cmbOcjene.Name = "cmbOcjene";
            cmbOcjene.Size = new Size(80, 28);
            cmbOcjene.TabIndex = 6;
            cmbOcjene.SelectedIndexChanged += cmbOcjene_SelectedIndexChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, Spol, Aktivan, Polozeni });
            dgvStudenti.Location = new Point(21, 74);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.Size = new Size(972, 338);
            dgvStudenti.TabIndex = 7;
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
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Resizable = DataGridViewTriState.True;
            Aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
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
            // lblUkupanBrojStudenata
            // 
            lblUkupanBrojStudenata.AutoSize = true;
            lblUkupanBrojStudenata.Location = new Point(21, 421);
            lblUkupanBrojStudenata.Name = "lblUkupanBrojStudenata";
            lblUkupanBrojStudenata.Size = new Size(0, 20);
            lblUkupanBrojStudenata.TabIndex = 8;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmStudenti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(lblUkupanBrojStudenata);
            Controls.Add(dgvStudenti);
            Controls.Add(cmbOcjene);
            Controls.Add(label3);
            Controls.Add(cmbOperator);
            Controls.Add(dtpDo);
            Controls.Add(label2);
            Controls.Add(dtpOd);
            Controls.Add(label1);
            Name = "frmStudenti";
            Text = "frmStudenti";
            Load += frmStudenti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpOd;
        private DateTimePicker dtpDo;
        private Label label2;
        private ComboBox cmbOperator;
        private Label label3;
        private ComboBox cmbOcjene;
        private DataGridView dgvStudenti;
        private Label lblUkupanBrojStudenata;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Polozeni;
        private ErrorProvider errorProvider1;
    }
}