namespace FIT.WinForms.IspitIBXXXXXX
{
    partial class frmUvjerenja
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
            dgvUvjerenja = new DataGridView();
            Datum = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            btnNoviZahtjev = new Button();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            btnDodaj = new Button();
            txtBroj = new TextBox();
            label3 = new Label();
            txtSvrha = new TextBox();
            label2 = new Label();
            cmbVrsta = new ComboBox();
            label1 = new Label();
            dsdlwms1 = new Report.dsDLWMS();
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dsdlwms1).BeginInit();
            SuspendLayout();
            // 
            // dgvUvjerenja
            // 
            dgvUvjerenja.AllowUserToAddRows = false;
            dgvUvjerenja.AllowUserToDeleteRows = false;
            dgvUvjerenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjerenja.Columns.AddRange(new DataGridViewColumn[] { Datum, Vrsta, Svrha, Uplatnica, Printano, Brisi, Printaj });
            dgvUvjerenja.Location = new Point(12, 83);
            dgvUvjerenja.Name = "dgvUvjerenja";
            dgvUvjerenja.ReadOnly = true;
            dgvUvjerenja.RowHeadersWidth = 51;
            dgvUvjerenja.RowTemplate.Height = 29;
            dgvUvjerenja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUvjerenja.Size = new Size(997, 310);
            dgvUvjerenja.TabIndex = 0;
            dgvUvjerenja.CellContentClick += dgvUvjerenja_CellContentClick;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "VrijemeKreiranja";
            Datum.HeaderText = "Datum";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Vrsta
            // 
            Vrsta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.MinimumWidth = 6;
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            // 
            // Svrha
            // 
            Svrha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.MinimumWidth = 6;
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            // 
            // Uplatnica
            // 
            Uplatnica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.MinimumWidth = 6;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            // 
            // Printano
            // 
            Printano.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.MinimumWidth = 6;
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.HeaderText = "";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Resizable = DataGridViewTriState.True;
            Brisi.SortMode = DataGridViewColumnSortMode.Automatic;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            Brisi.Width = 125;
            // 
            // Printaj
            // 
            Printaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printaj.HeaderText = "";
            Printaj.MinimumWidth = 6;
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Resizable = DataGridViewTriState.True;
            Printaj.SortMode = DataGridViewColumnSortMode.Automatic;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            // 
            // btnNoviZahtjev
            // 
            btnNoviZahtjev.Location = new Point(843, 25);
            btnNoviZahtjev.Name = "btnNoviZahtjev";
            btnNoviZahtjev.Size = new Size(155, 29);
            btnNoviZahtjev.TabIndex = 1;
            btnNoviZahtjev.Text = "Novi zahtjev";
            btnNoviZahtjev.UseVisualStyleBackColor = true;
            btnNoviZahtjev.Click += btnNoviZahtjev_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSvrha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbVrsta);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 417);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(997, 269);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva za izdavanjem uvjerenja";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 112);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.ScrollBars = ScrollBars.Vertical;
            txtInfo.Size = new Size(985, 151);
            txtInfo.TabIndex = 7;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(790, 59);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(179, 29);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj=>";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(652, 62);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(102, 27);
            txtBroj.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(652, 39);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "Broj:";
            // 
            // txtSvrha
            // 
            txtSvrha.Location = new Point(292, 61);
            txtSvrha.Name = "txtSvrha";
            txtSvrha.Size = new Size(336, 27);
            txtSvrha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 38);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 2;
            label2.Text = "Svrha izdavanja:";
            // 
            // cmbVrsta
            // 
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "Uvjerenje o statusu studenta" });
            cmbVrsta.Location = new Point(6, 62);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(247, 28);
            cmbVrsta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // dsdlwms1
            // 
            dsdlwms1.DataSetName = "dsDLWMS";
            dsdlwms1.Namespace = "http://tempuri.org/dsDLWMS.xsd";
            dsdlwms1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmUvjerenja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 698);
            Controls.Add(groupBox1);
            Controls.Add(btnNoviZahtjev);
            Controls.Add(dgvUvjerenja);
            Name = "frmUvjerenja";
            Text = "frmUvjerenja";
            Load += frmUvjerenja_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dsdlwms1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUvjerenja;
        private Button btnNoviZahtjev;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
        private GroupBox groupBox1;
        private Button btnDodaj;
        private TextBox txtBroj;
        private Label label3;
        private TextBox txtSvrha;
        private Label label2;
        private ComboBox cmbVrsta;
        private Label label1;
        private Report.dsDLWMS dsdlwms1;
        private TextBox txtInfo;
    }
}