namespace FIT.WinForms.IspitIBXXXXXX
{
    partial class frmGradoviIBXXXXXX
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
            pbSlika = new PictureBox();
            lblDrzavaInfo = new Label();
            label1 = new Label();
            txtNaziv = new TextBox();
            btnDodaj = new Button();
            dgvGradovi = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            PromjeniStatus = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtBrojGradova = new TextBox();
            cbStatus = new CheckBox();
            btnGenerisi = new Button();
            txtInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(12, 28);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(217, 78);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblDrzavaInfo
            // 
            lblDrzavaInfo.AutoSize = true;
            lblDrzavaInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrzavaInfo.Location = new Point(253, 56);
            lblDrzavaInfo.Name = "lblDrzavaInfo";
            lblDrzavaInfo.Size = new Size(79, 31);
            lblDrzavaInfo.TabIndex = 1;
            lblDrzavaInfo.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 154);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 2;
            label1.Text = "Unesite naziv novog grada:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(209, 152);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(190, 27);
            txtNaziv.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(419, 149);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(104, 33);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Status, PromjeniStatus });
            dgvGradovi.Location = new Point(12, 205);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowHeadersWidth = 51;
            dgvGradovi.RowTemplate.Height = 29;
            dgvGradovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradovi.Size = new Size(510, 183);
            dgvGradovi.TabIndex = 5;
            dgvGradovi.CellClick += dgvGradovi_CellClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv Grada";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivan";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // PromjeniStatus
            // 
            PromjeniStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PromjeniStatus.DataPropertyName = "PromjeniStatus";
            PromjeniStatus.HeaderText = "";
            PromjeniStatus.MinimumWidth = 6;
            PromjeniStatus.Name = "PromjeniStatus";
            PromjeniStatus.ReadOnly = true;
            PromjeniStatus.Text = "Promjeni status";
            PromjeniStatus.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Controls.Add(txtBrojGradova);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(13, 407);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 240);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Broj gradova:";
            // 
            // txtBrojGradova
            // 
            txtBrojGradova.Location = new Point(113, 37);
            txtBrojGradova.Name = "txtBrojGradova";
            txtBrojGradova.Size = new Size(124, 27);
            txtBrojGradova.TabIndex = 1;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(253, 40);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(76, 24);
            cbStatus.TabIndex = 2;
            cbStatus.Text = "Aktivni";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(382, 35);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generisi =>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 88);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(488, 146);
            txtInfo.TabIndex = 4;
            // 
            // frmGradoviIBXXXXXX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 659);
            Controls.Add(groupBox1);
            Controls.Add(dgvGradovi);
            Controls.Add(btnDodaj);
            Controls.Add(txtNaziv);
            Controls.Add(label1);
            Controls.Add(lblDrzavaInfo);
            Controls.Add(pbSlika);
            Name = "frmGradoviIBXXXXXX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGradoviIBXXXXXX";
            FormClosed += frmGradoviIBXXXXXX_FormClosed;
            Load += frmGradoviIBXXXXXX_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblDrzavaInfo;
        private Label label1;
        private TextBox txtNaziv;
        private Button btnDodaj;
        private DataGridView dgvGradovi;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn PromjeniStatus;
        private GroupBox groupBox1;
        private Button btnGenerisi;
        private CheckBox cbStatus;
        private TextBox txtBrojGradova;
        private Label label2;
        private TextBox txtInfo;
    }
}