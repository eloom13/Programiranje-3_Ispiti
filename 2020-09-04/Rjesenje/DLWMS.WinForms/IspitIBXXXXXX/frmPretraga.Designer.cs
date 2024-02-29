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
            txtFilter = new TextBox();
            dgvKorisniciPredmeti = new DataGridView();
            ImePrezime = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            Poruke = new DataGridViewButtonColumn();
            label2 = new Label();
            lblProsjek = new Label();
            groupBox1 = new GroupBox();
            txtThread = new TextBox();
            btnSumiraj = new Button();
            label3 = new Label();
            lblSuma = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKorisniciPredmeti).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Naziv predmeta:";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(135, 27);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(768, 27);
            txtFilter.TabIndex = 1;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // dgvKorisniciPredmeti
            // 
            dgvKorisniciPredmeti.AllowUserToAddRows = false;
            dgvKorisniciPredmeti.AllowUserToDeleteRows = false;
            dgvKorisniciPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKorisniciPredmeti.Columns.AddRange(new DataGridViewColumn[] { ImePrezime, Predmet, Datum, Ocjena, Poruke });
            dgvKorisniciPredmeti.Location = new Point(11, 72);
            dgvKorisniciPredmeti.Name = "dgvKorisniciPredmeti";
            dgvKorisniciPredmeti.ReadOnly = true;
            dgvKorisniciPredmeti.RowHeadersWidth = 51;
            dgvKorisniciPredmeti.RowTemplate.Height = 29;
            dgvKorisniciPredmeti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKorisniciPredmeti.Size = new Size(892, 324);
            dgvKorisniciPredmeti.TabIndex = 2;
            dgvKorisniciPredmeti.CellContentClick += dgvKorisniciPredmeti_CellContentClick;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "Korisnik";
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
            // Datum
            // 
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            Datum.Width = 125;
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
            // Poruke
            // 
            Poruke.HeaderText = "Poruke";
            Poruke.MinimumWidth = 6;
            Poruke.Name = "Poruke";
            Poruke.ReadOnly = true;
            Poruke.Resizable = DataGridViewTriState.True;
            Poruke.SortMode = DataGridViewColumnSortMode.Automatic;
            Poruke.Text = "Poruke";
            Poruke.UseColumnTextForButtonValue = true;
            Poruke.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 416);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 3;
            label2.Text = "Prosjek prikazanih ocjena:";
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Location = new Point(197, 416);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(0, 20);
            lblProsjek.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSuma);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSumiraj);
            groupBox1.Controls.Add(txtThread);
            groupBox1.Location = new Point(452, 416);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 163);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Threading";
            // 
            // txtThread
            // 
            txtThread.Location = new Point(6, 36);
            txtThread.Name = "txtThread";
            txtThread.Size = new Size(268, 27);
            txtThread.TabIndex = 0;
            // 
            // btnSumiraj
            // 
            btnSumiraj.Location = new Point(298, 34);
            btnSumiraj.Name = "btnSumiraj";
            btnSumiraj.Size = new Size(147, 29);
            btnSumiraj.TabIndex = 1;
            btnSumiraj.Text = "Sumiraj";
            btnSumiraj.UseVisualStyleBackColor = true;
            btnSumiraj.Click += btnSumiraj_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 83);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Suma:";
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(15, 125);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(0, 20);
            lblSuma.TabIndex = 3;
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 591);
            Controls.Add(groupBox1);
            Controls.Add(lblProsjek);
            Controls.Add(label2);
            Controls.Add(dgvKorisniciPredmeti);
            Controls.Add(txtFilter);
            Controls.Add(label1);
            Name = "frmPretraga";
            Text = "frmPretragaBrojIndeksa";
            Load += frmPretragaBrojIndeksa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKorisniciPredmeti).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFilter;
        private DataGridView dgvKorisniciPredmeti;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewButtonColumn Poruke;
        private Label label2;
        private Label lblProsjek;
        private GroupBox groupBox1;
        private Label lblSuma;
        private Label label3;
        private Button btnSumiraj;
        private TextBox txtThread;
    }
}