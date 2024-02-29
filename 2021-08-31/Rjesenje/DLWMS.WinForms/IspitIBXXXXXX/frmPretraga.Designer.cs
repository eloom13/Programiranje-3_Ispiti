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
            txtImePrezimeFilter = new TextBox();
            dgvPretraga = new DataGridView();
            ImePrezime = new DataGridViewTextBoxColumn();
            PolozeniPredmeti = new DataGridViewTextBoxColumn();
            BrojPolozenih = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            Ispiti = new DataGridViewButtonColumn();
            label2 = new Label();
            lblProsjek = new Label();
            label3 = new Label();
            lblNajveciProsjek = new Label();
            groupBox1 = new GroupBox();
            btnGenerisiInfo = new Button();
            lblBrojZnakova = new Label();
            lblBrojSuglasnika = new Label();
            lblBrojSamoglasnika = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtTekst = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime ili prezime:";
            // 
            // txtImePrezimeFilter
            // 
            txtImePrezimeFilter.Location = new Point(138, 29);
            txtImePrezimeFilter.Name = "txtImePrezimeFilter";
            txtImePrezimeFilter.Size = new Size(841, 27);
            txtImePrezimeFilter.TabIndex = 1;
            txtImePrezimeFilter.TextChanged += txtImePrezimeFilter_TextChanged;
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { ImePrezime, PolozeniPredmeti, BrojPolozenih, Prosjek, Ispiti });
            dgvPretraga.Location = new Point(21, 73);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowHeadersWidth = 51;
            dgvPretraga.RowTemplate.Height = 29;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(958, 287);
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
            // PolozeniPredmeti
            // 
            PolozeniPredmeti.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PolozeniPredmeti.DataPropertyName = "Polozeni";
            PolozeniPredmeti.HeaderText = "Polozeni predmeti";
            PolozeniPredmeti.MinimumWidth = 6;
            PolozeniPredmeti.Name = "PolozeniPredmeti";
            PolozeniPredmeti.ReadOnly = true;
            // 
            // BrojPolozenih
            // 
            BrojPolozenih.DataPropertyName = "Broj";
            BrojPolozenih.HeaderText = "Broj polozenih";
            BrojPolozenih.MinimumWidth = 6;
            BrojPolozenih.Name = "BrojPolozenih";
            BrojPolozenih.ReadOnly = true;
            BrojPolozenih.Width = 125;
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            Prosjek.Width = 125;
            // 
            // Ispiti
            // 
            Ispiti.HeaderText = "";
            Ispiti.MinimumWidth = 6;
            Ispiti.Name = "Ispiti";
            Ispiti.ReadOnly = true;
            Ispiti.Resizable = DataGridViewTriState.True;
            Ispiti.SortMode = DataGridViewColumnSortMode.Automatic;
            Ispiti.Text = "Ispiti";
            Ispiti.UseColumnTextForButtonValue = true;
            Ispiti.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 384);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 3;
            label2.Text = "Prosjek prikazanih ocjena:";
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Location = new Point(206, 384);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(0, 20);
            lblProsjek.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(612, 384);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 5;
            label3.Text = "Najveci prosjek ostvario:";
            // 
            // lblNajveciProsjek
            // 
            lblNajveciProsjek.AutoSize = true;
            lblNajveciProsjek.Location = new Point(788, 384);
            lblNajveciProsjek.Name = "lblNajveciProsjek";
            lblNajveciProsjek.Size = new Size(0, 20);
            lblNajveciProsjek.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGenerisiInfo);
            groupBox1.Controls.Add(lblBrojZnakova);
            groupBox1.Controls.Add(lblBrojSuglasnika);
            groupBox1.Controls.Add(lblBrojSamoglasnika);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTekst);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(21, 421);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(958, 261);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Threading";
            // 
            // btnGenerisiInfo
            // 
            btnGenerisiInfo.Location = new Point(818, 169);
            btnGenerisiInfo.Name = "btnGenerisiInfo";
            btnGenerisiInfo.Size = new Size(134, 29);
            btnGenerisiInfo.TabIndex = 8;
            btnGenerisiInfo.Text = "Generisi info";
            btnGenerisiInfo.UseVisualStyleBackColor = true;
            btnGenerisiInfo.Click += btnGenerisiInfo_Click;
            // 
            // lblBrojZnakova
            // 
            lblBrojZnakova.AutoSize = true;
            lblBrojZnakova.Location = new Point(139, 237);
            lblBrojZnakova.Name = "lblBrojZnakova";
            lblBrojZnakova.Size = new Size(0, 20);
            lblBrojZnakova.TabIndex = 7;
            // 
            // lblBrojSuglasnika
            // 
            lblBrojSuglasnika.AutoSize = true;
            lblBrojSuglasnika.Location = new Point(117, 202);
            lblBrojSuglasnika.Name = "lblBrojSuglasnika";
            lblBrojSuglasnika.Size = new Size(0, 20);
            lblBrojSuglasnika.TabIndex = 6;
            // 
            // lblBrojSamoglasnika
            // 
            lblBrojSamoglasnika.AutoSize = true;
            lblBrojSamoglasnika.Location = new Point(129, 169);
            lblBrojSamoglasnika.Name = "lblBrojSamoglasnika";
            lblBrojSamoglasnika.Size = new Size(0, 20);
            lblBrojSamoglasnika.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 238);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 4;
            label7.Text = "Znakova (!,?,<,>,*)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 202);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 3;
            label6.Text = "Suglasnika:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 169);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 2;
            label5.Text = "Samoglasnika:";
            // 
            // txtTekst
            // 
            txtTekst.Location = new Point(6, 56);
            txtTekst.Multiline = true;
            txtTekst.Name = "txtTekst";
            txtTekst.Size = new Size(946, 96);
            txtTekst.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 33);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 0;
            label4.Text = "Unesite sadrzaj:";
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 706);
            Controls.Add(groupBox1);
            Controls.Add(lblNajveciProsjek);
            Controls.Add(label3);
            Controls.Add(lblProsjek);
            Controls.Add(label2);
            Controls.Add(dgvPretraga);
            Controls.Add(txtImePrezimeFilter);
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
        private TextBox txtImePrezimeFilter;
        private DataGridView dgvPretraga;
        private Label label2;
        private Label lblProsjek;
        private Label label3;
        private Label lblNajveciProsjek;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn PolozeniPredmeti;
        private DataGridViewTextBoxColumn BrojPolozenih;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewButtonColumn Ispiti;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtTekst;
        private Label label4;
        private Button btnGenerisiInfo;
        private Label lblBrojZnakova;
        private Label lblBrojSuglasnika;
        private Label lblBrojSamoglasnika;
        private Label label7;
        private Label label6;
    }
}