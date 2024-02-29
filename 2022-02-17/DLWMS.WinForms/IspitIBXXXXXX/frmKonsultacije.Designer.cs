namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmKonsultacije
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
            dgvKonsultacije = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            VrijemeOdrzavanja = new DataGridViewTextBoxColumn();
            Napomena = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            btnDodajZahtjev = new Button();
            btnPrintaj = new Button();
            groupBox1 = new GroupBox();
            txtSadrzaj = new TextBox();
            label4 = new Label();
            btnDodajAsync = new Button();
            cmbPredmet = new ComboBox();
            label3 = new Label();
            txtBrojZahtjeva = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKonsultacije).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(263, 20);
            label1.TabIndex = 0;
            label1.Text = "Lista zahtjeva za konsultacije studenta:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(299, 27);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(0, 20);
            lblStudent.TabIndex = 1;
            // 
            // dgvKonsultacije
            // 
            dgvKonsultacije.AllowUserToAddRows = false;
            dgvKonsultacije.AllowUserToDeleteRows = false;
            dgvKonsultacije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKonsultacije.Columns.AddRange(new DataGridViewColumn[] { Student, Predmet, VrijemeOdrzavanja, Napomena, Brisi });
            dgvKonsultacije.Location = new Point(23, 70);
            dgvKonsultacije.Name = "dgvKonsultacije";
            dgvKonsultacije.ReadOnly = true;
            dgvKonsultacije.RowHeadersWidth = 51;
            dgvKonsultacije.RowTemplate.Height = 29;
            dgvKonsultacije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKonsultacije.Size = new Size(1022, 323);
            dgvKonsultacije.TabIndex = 2;
            dgvKonsultacije.CellContentClick += dgvKonsultacije_CellContentClick;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
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
            // VrijemeOdrzavanja
            // 
            VrijemeOdrzavanja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VrijemeOdrzavanja.DataPropertyName = "VrijemeOdrzavanja";
            VrijemeOdrzavanja.HeaderText = "VrijemeOdrzavanja";
            VrijemeOdrzavanja.MinimumWidth = 6;
            VrijemeOdrzavanja.Name = "VrijemeOdrzavanja";
            VrijemeOdrzavanja.ReadOnly = true;
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
            // Brisi
            // 
            Brisi.HeaderText = "Brisi";
            Brisi.MinimumWidth = 6;
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            Brisi.Width = 125;
            // 
            // btnDodajZahtjev
            // 
            btnDodajZahtjev.Location = new Point(941, 27);
            btnDodajZahtjev.Name = "btnDodajZahtjev";
            btnDodajZahtjev.Size = new Size(94, 29);
            btnDodajZahtjev.TabIndex = 3;
            btnDodajZahtjev.Text = "Dodaj zahtjev";
            btnDodajZahtjev.UseVisualStyleBackColor = true;
            btnDodajZahtjev.Click += btnDodajZahtjev_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(958, 437);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 4;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSadrzaj);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnDodajAsync);
            groupBox1.Controls.Add(cmbPredmet);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBrojZahtjeva);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(23, 421);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(922, 266);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva";
            // 
            // txtSadrzaj
            // 
            txtSadrzaj.Location = new Point(276, 72);
            txtSadrzaj.Multiline = true;
            txtSadrzaj.Name = "txtSadrzaj";
            txtSadrzaj.ScrollBars = ScrollBars.Vertical;
            txtSadrzaj.Size = new Size(640, 188);
            txtSadrzaj.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 49);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 5;
            label4.Text = "Info:";
            // 
            // btnDodajAsync
            // 
            btnDodajAsync.Location = new Point(93, 215);
            btnDodajAsync.Name = "btnDodajAsync";
            btnDodajAsync.Size = new Size(108, 28);
            btnDodajAsync.TabIndex = 4;
            btnDodajAsync.Text = "Dodaj =>";
            btnDodajAsync.UseVisualStyleBackColor = true;
            btnDodajAsync.Click += btnDodajAsync_Click;
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(7, 155);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(194, 28);
            cmbPredmet.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 132);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Predmet:";
            // 
            // txtBrojZahtjeva
            // 
            txtBrojZahtjeva.Location = new Point(7, 72);
            txtBrojZahtjeva.Name = "txtBrojZahtjeva";
            txtBrojZahtjeva.Size = new Size(194, 27);
            txtBrojZahtjeva.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 49);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Broj zahtjeva:";
            // 
            // frmKonsultacije
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 699);
            Controls.Add(groupBox1);
            Controls.Add(btnPrintaj);
            Controls.Add(btnDodajZahtjev);
            Controls.Add(dgvKonsultacije);
            Controls.Add(lblStudent);
            Controls.Add(label1);
            Name = "frmKonsultacije";
            Text = "frmKonsultacije";
            Load += frmKonsultacije_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKonsultacije).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStudent;
        private DataGridView dgvKonsultacije;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn VrijemeOdrzavanja;
        private DataGridViewTextBoxColumn Napomena;
        private DataGridViewButtonColumn Brisi;
        private Button btnDodajZahtjev;
        private Button btnPrintaj;
        private GroupBox groupBox1;
        private TextBox txtSadrzaj;
        private Label label4;
        private Button btnDodajAsync;
        private ComboBox cmbPredmet;
        private Label label3;
        private TextBox txtBrojZahtjeva;
        private Label label2;
    }
}