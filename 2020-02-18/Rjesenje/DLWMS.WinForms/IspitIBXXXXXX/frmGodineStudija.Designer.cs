namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmGodineStudija
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
            dgvGodineStudija = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            txtNaziv = new TextBox();
            cbAktivna = new CheckBox();
            btnSacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvGodineStudija).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgvGodineStudija
            // 
            dgvGodineStudija.AllowUserToAddRows = false;
            dgvGodineStudija.AllowUserToDeleteRows = false;
            dgvGodineStudija.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGodineStudija.Columns.AddRange(new DataGridViewColumn[] { Naziv, Aktivna });
            dgvGodineStudija.Location = new Point(12, 96);
            dgvGodineStudija.Name = "dgvGodineStudija";
            dgvGodineStudija.ReadOnly = true;
            dgvGodineStudija.RowHeadersWidth = 51;
            dgvGodineStudija.RowTemplate.Height = 29;
            dgvGodineStudija.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGodineStudija.Size = new Size(618, 302);
            dgvGodineStudija.TabIndex = 0;
            dgvGodineStudija.CellContentClick += dgvGodineStudija_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Aktivna
            // 
            Aktivna.DataPropertyName = "Aktivna";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.MinimumWidth = 6;
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            Aktivna.Width = 125;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(12, 42);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(357, 27);
            txtNaziv.TabIndex = 1;
            // 
            // cbAktivna
            // 
            cbAktivna.AutoSize = true;
            cbAktivna.Location = new Point(392, 44);
            cbAktivna.Name = "cbAktivna";
            cbAktivna.Size = new Size(80, 24);
            cbAktivna.TabIndex = 2;
            cbAktivna.Text = "Aktivna";
            cbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(502, 39);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(128, 29);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmGodineStudija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 412);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbAktivna);
            Controls.Add(txtNaziv);
            Controls.Add(dgvGodineStudija);
            Name = "frmGodineStudija";
            Text = "frmGodineStudija";
            Load += frmGodineStudija_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGodineStudija).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGodineStudija;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Aktivna;
        private TextBox txtNaziv;
        private CheckBox cbAktivna;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider1;
    }
}