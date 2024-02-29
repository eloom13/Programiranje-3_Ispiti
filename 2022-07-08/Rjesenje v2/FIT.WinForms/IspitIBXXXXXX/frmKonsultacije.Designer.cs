namespace FIT.WinForms.IspitIBXXXXXX
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
            btnDodajZahtjev = new Button();
            dgvKonsultacije = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            Predmet = new DataGridViewTextBoxColumn();
            VrijemeOdrzavanja = new DataGridViewTextBoxColumn();
            Napomena = new DataGridViewTextBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            btnPrintaj = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtBrojZahtjeva = new TextBox();
            label3 = new Label();
            cmbPredmet = new ComboBox();
            label4 = new Label();
            txtInfo = new TextBox();
            btnDodajAsync = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKonsultacije).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 40);
            label1.Name = "label1";
            label1.Size = new Size(282, 20);
            label1.TabIndex = 0;
            label1.Text = "Lista zahtjeva za konsultacija za studenta:";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudent.Location = new Point(324, 40);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(0, 20);
            lblStudent.TabIndex = 1;
            // 
            // btnDodajZahtjev
            // 
            btnDodajZahtjev.Location = new Point(872, 40);
            btnDodajZahtjev.Name = "btnDodajZahtjev";
            btnDodajZahtjev.Size = new Size(118, 29);
            btnDodajZahtjev.TabIndex = 2;
            btnDodajZahtjev.Text = "Dodaj zahtjev";
            btnDodajZahtjev.UseVisualStyleBackColor = true;
            btnDodajZahtjev.Click += btnDodajZahtjev_Click;
            // 
            // dgvKonsultacije
            // 
            dgvKonsultacije.AllowUserToAddRows = false;
            dgvKonsultacije.AllowUserToDeleteRows = false;
            dgvKonsultacije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKonsultacije.Columns.AddRange(new DataGridViewColumn[] { Student, Predmet, VrijemeOdrzavanja, Napomena, Brisi });
            dgvKonsultacije.Location = new Point(27, 95);
            dgvKonsultacije.Name = "dgvKonsultacije";
            dgvKonsultacije.ReadOnly = true;
            dgvKonsultacije.RowHeadersWidth = 51;
            dgvKonsultacije.RowTemplate.Height = 29;
            dgvKonsultacije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKonsultacije.Size = new Size(963, 304);
            dgvKonsultacije.TabIndex = 3;
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
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(896, 417);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 4;
            btnPrintaj.Text = "Print";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDodajAsync);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbPredmet);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBrojZahtjeva);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(27, 464);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(974, 270);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 51);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Broj zahtjeva:";
            // 
            // txtBrojZahtjeva
            // 
            txtBrojZahtjeva.Location = new Point(17, 74);
            txtBrojZahtjeva.Name = "txtBrojZahtjeva";
            txtBrojZahtjeva.Size = new Size(188, 27);
            txtBrojZahtjeva.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 123);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Predmet:";
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(17, 159);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(188, 28);
            cmbPredmet.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 32);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 4;
            label4.Text = "Info:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(329, 55);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(634, 198);
            txtInfo.TabIndex = 5;
            // 
            // btnDodajAsync
            // 
            btnDodajAsync.Location = new Point(111, 212);
            btnDodajAsync.Name = "btnDodajAsync";
            btnDodajAsync.Size = new Size(94, 29);
            btnDodajAsync.TabIndex = 6;
            btnDodajAsync.Text = "Dodaj =>";
            btnDodajAsync.UseVisualStyleBackColor = true;
            btnDodajAsync.Click += btnDodajAsync_Click;
            // 
            // frmKonsultacije
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 746);
            Controls.Add(groupBox1);
            Controls.Add(btnPrintaj);
            Controls.Add(dgvKonsultacije);
            Controls.Add(btnDodajZahtjev);
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
        private Button btnDodajZahtjev;
        private DataGridView dgvKonsultacije;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn VrijemeOdrzavanja;
        private DataGridViewTextBoxColumn Napomena;
        private DataGridViewButtonColumn Brisi;
        private Button btnPrintaj;
        private GroupBox groupBox1;
        private Button btnDodajAsync;
        private TextBox txtInfo;
        private Label label4;
        private ComboBox cmbPredmet;
        private Label label3;
        private TextBox txtBrojZahtjeva;
        private Label label2;
    }
}