namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmScanIspita
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
            lblStudent = new Label();
            dgvScan = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Napomena = new DataGridViewTextBoxColumn();
            Scan = new DataGridViewImageColumn();
            Varanje = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            btnDodajScanIspita = new Button();
            btnPrintaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvScan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 0;
            label1.Text = "Pregled ispita za studenta:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudent.Location = new Point(201, 29);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(0, 28);
            lblStudent.TabIndex = 1;
            // 
            // dgvScan
            // 
            dgvScan.AllowUserToAddRows = false;
            dgvScan.AllowUserToDeleteRows = false;
            dgvScan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScan.Columns.AddRange(new DataGridViewColumn[] { Predmet, Napomena, Scan, Varanje, Brisi });
            dgvScan.Location = new Point(12, 75);
            dgvScan.Name = "dgvScan";
            dgvScan.ReadOnly = true;
            dgvScan.RowHeadersWidth = 51;
            dgvScan.RowTemplate.Height = 29;
            dgvScan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvScan.Size = new Size(951, 304);
            dgvScan.TabIndex = 2;
            dgvScan.CellContentClick += dgvScan_CellContentClick;
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
            // Napomena
            // 
            Napomena.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Napomena.DataPropertyName = "Napomena";
            Napomena.HeaderText = "Napomena";
            Napomena.MinimumWidth = 6;
            Napomena.Name = "Napomena";
            Napomena.ReadOnly = true;
            // 
            // Scan
            // 
            Scan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Scan.DataPropertyName = "Scan";
            Scan.HeaderText = "Scan";
            Scan.MinimumWidth = 6;
            Scan.Name = "Scan";
            Scan.ReadOnly = true;
            // 
            // Varanje
            // 
            Varanje.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Varanje.DataPropertyName = "Varanje";
            Varanje.HeaderText = "Varanje";
            Varanje.MinimumWidth = 6;
            Varanje.Name = "Varanje";
            Varanje.ReadOnly = true;
            Varanje.Resizable = DataGridViewTriState.True;
            // 
            // Brisi
            // 
            Brisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Resizable = DataGridViewTriState.True;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // btnDodajScanIspita
            // 
            btnDodajScanIspita.Location = new Point(826, 29);
            btnDodajScanIspita.Name = "btnDodajScanIspita";
            btnDodajScanIspita.Size = new Size(137, 29);
            btnDodajScanIspita.TabIndex = 3;
            btnDodajScanIspita.Text = "Dodaj scan ispita";
            btnDodajScanIspita.UseVisualStyleBackColor = true;
            btnDodajScanIspita.Click += btnDodajScanIspita_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(860, 399);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 4;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // frmScanIspita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 448);
            Controls.Add(btnPrintaj);
            Controls.Add(btnDodajScanIspita);
            Controls.Add(dgvScan);
            Controls.Add(lblStudent);
            Controls.Add(label1);
            Name = "frmScanIspita";
            Text = "frmScanIspita";
            Load += frmScanIspita_Load;
            ((System.ComponentModel.ISupportInitialize)dgvScan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStudent;
        private DataGridView dgvScan;
        private Button btnDodajScanIspita;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Napomena;
        private DataGridViewImageColumn Scan;
        private DataGridViewCheckBoxColumn Varanje;
        private DataGridViewButtonColumn Brisi;
        private Button btnPrintaj;
    }
}