namespace FIT.WinForms.IspitIBXXXXXX
{
    partial class frmDrzaveIBXXXXXX
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            btnNovaDrzava = new Button();
            dgvDrzave = new DataGridView();
            btnPrintaj = new Button();
            Zastava = new DataGridViewImageColumn();
            Drzava = new DataGridViewTextBoxColumn();
            BrojGradova = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            Gradovi = new DataGridViewButtonColumn();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 449);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(931, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(796, 22);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(123, 29);
            btnNovaDrzava.TabIndex = 1;
            btnNovaDrzava.Text = "Nova drzava";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            btnNovaDrzava.Click += btnNovaDrzava_Click;
            // 
            // dgvDrzave
            // 
            dgvDrzave.AllowUserToAddRows = false;
            dgvDrzave.AllowUserToDeleteRows = false;
            dgvDrzave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzave.Columns.AddRange(new DataGridViewColumn[] { Zastava, Drzava, BrojGradova, Aktivna, Gradovi });
            dgvDrzave.Location = new Point(12, 74);
            dgvDrzave.Name = "dgvDrzave";
            dgvDrzave.ReadOnly = true;
            dgvDrzave.RowHeadersWidth = 51;
            dgvDrzave.RowTemplate.Height = 29;
            dgvDrzave.Size = new Size(907, 320);
            dgvDrzave.TabIndex = 2;
            dgvDrzave.CellClick += dgvDrzave_CellClick;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(817, 408);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 3;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // Zastava
            // 
            Zastava.DataPropertyName = "Zastava";
            Zastava.FillWeight = 347.593567F;
            Zastava.HeaderText = "Zastava";
            Zastava.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Zastava.MinimumWidth = 6;
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            Zastava.Width = 130;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Naziv";
            Drzava.FillWeight = 38.10161F;
            Drzava.HeaderText = "Drzava";
            Drzava.MinimumWidth = 6;
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            Drzava.Resizable = DataGridViewTriState.True;
            Drzava.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // BrojGradova
            // 
            BrojGradova.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojGradova.DataPropertyName = "BrojGradova";
            BrojGradova.FillWeight = 38.10161F;
            BrojGradova.HeaderText = "Broj gradova";
            BrojGradova.MinimumWidth = 6;
            BrojGradova.Name = "BrojGradova";
            BrojGradova.ReadOnly = true;
            BrojGradova.Resizable = DataGridViewTriState.True;
            BrojGradova.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Aktivna
            // 
            Aktivna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivna.DataPropertyName = "Status";
            Aktivna.FillWeight = 38.10161F;
            Aktivna.HeaderText = "Aktivna";
            Aktivna.MinimumWidth = 6;
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            // 
            // Gradovi
            // 
            Gradovi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Gradovi.FillWeight = 38.10161F;
            Gradovi.HeaderText = "";
            Gradovi.MinimumWidth = 6;
            Gradovi.Name = "Gradovi";
            Gradovi.ReadOnly = true;
            Gradovi.Text = "Gradovi";
            Gradovi.UseColumnTextForButtonValue = true;
            // 
            // frmDrzaveIBXXXXXX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 475);
            Controls.Add(btnPrintaj);
            Controls.Add(dgvDrzave);
            Controls.Add(btnNovaDrzava);
            Controls.Add(statusStrip1);
            Name = "frmDrzaveIBXXXXXX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDrzaveIBXXXXXX";
            Load += frmDrzaveIBXXXXXX_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private Button btnNovaDrzava;
        private DataGridView dgvDrzave;
        private Button btnPrintaj;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn BrojGradova;
        private DataGridViewCheckBoxColumn Aktivna;
        private DataGridViewButtonColumn Gradovi;
    }
}