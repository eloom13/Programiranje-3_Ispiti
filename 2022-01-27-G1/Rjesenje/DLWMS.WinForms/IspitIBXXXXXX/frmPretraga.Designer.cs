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
            txtFilterNazivPredmeta = new TextBox();
            dgvPretraga = new DataGridView();
            ImePrezime = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            BrisiPredmet = new DataGridViewButtonColumn();
            Slike = new DataGridViewButtonColumn();
            btnPrintaj = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            btnSumiraj = new Button();
            label4 = new Label();
            txtOd = new TextBox();
            txtDo = new TextBox();
            txtSuma = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Naziv predmeta:";
            // 
            // txtFilterNazivPredmeta
            // 
            txtFilterNazivPredmeta.Location = new Point(145, 25);
            txtFilterNazivPredmeta.Name = "txtFilterNazivPredmeta";
            txtFilterNazivPredmeta.Size = new Size(1046, 27);
            txtFilterNazivPredmeta.TabIndex = 1;
            txtFilterNazivPredmeta.TextChanged += txtFilterNazivPredmeta_TextChanged;
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { ImePrezime, Predmet, Ocjena, Datum, BrisiPredmet, Slike });
            dgvPretraga.Location = new Point(21, 74);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowHeadersWidth = 51;
            dgvPretraga.RowTemplate.Height = 29;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(1170, 288);
            dgvPretraga.TabIndex = 2;
            dgvPretraga.CellContentClick += dgvPretraga_CellContentClick;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "Student";
            ImePrezime.HeaderText = "Ime i prezime";
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
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.MinimumWidth = 6;
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            Ocjena.Width = 125;
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
            // BrisiPredmet
            // 
            BrisiPredmet.HeaderText = "Brisi predmet";
            BrisiPredmet.MinimumWidth = 6;
            BrisiPredmet.Name = "BrisiPredmet";
            BrisiPredmet.ReadOnly = true;
            BrisiPredmet.Text = "brisi predmet";
            BrisiPredmet.UseColumnTextForButtonValue = true;
            BrisiPredmet.Width = 125;
            // 
            // Slike
            // 
            Slike.HeaderText = "Slike";
            Slike.MinimumWidth = 6;
            Slike.Name = "Slike";
            Slike.ReadOnly = true;
            Slike.Text = "Slike";
            Slike.UseColumnTextForButtonValue = true;
            Slike.Width = 125;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(1097, 382);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 3;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSuma);
            groupBox1.Controls.Add(txtDo);
            groupBox1.Controls.Add(txtOd);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnSumiraj);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(21, 382);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(710, 173);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sumiraj brojeve";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 59);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 0;
            label2.Text = "Od:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 59);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 1;
            label3.Text = "Do:";
            // 
            // btnSumiraj
            // 
            btnSumiraj.Location = new Point(349, 101);
            btnSumiraj.Name = "btnSumiraj";
            btnSumiraj.Size = new Size(94, 29);
            btnSumiraj.TabIndex = 2;
            btnSumiraj.Text = "Sumiraj =>";
            btnSumiraj.UseVisualStyleBackColor = true;
            btnSumiraj.Click += btnSumiraj_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(542, 59);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Suma:";
            // 
            // txtOd
            // 
            txtOd.Location = new Point(6, 100);
            txtOd.Name = "txtOd";
            txtOd.Size = new Size(112, 27);
            txtOd.TabIndex = 4;
            // 
            // txtDo
            // 
            txtDo.Location = new Point(167, 101);
            txtDo.Name = "txtDo";
            txtDo.Size = new Size(112, 27);
            txtDo.TabIndex = 5;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(542, 100);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(112, 27);
            txtSuma.TabIndex = 6;
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 567);
            Controls.Add(groupBox1);
            Controls.Add(btnPrintaj);
            Controls.Add(dgvPretraga);
            Controls.Add(txtFilterNazivPredmeta);
            Controls.Add(label1);
            Name = "frmPretraga";
            Text = "frmPretraga";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFilterNazivPredmeta;
        private DataGridView dgvPretraga;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewButtonColumn BrisiPredmet;
        private DataGridViewButtonColumn Slike;
        private Button btnPrintaj;
        private GroupBox groupBox1;
        private TextBox txtSuma;
        private TextBox txtDo;
        private TextBox txtOd;
        private Label label4;
        private Button btnSumiraj;
        private Label label3;
        private Label label2;
    }
}