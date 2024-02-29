namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmPotvrde
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
            txtBrojPotvrda = new TextBox();
            btnGenerisiPotvrde = new Button();
            btnObrisiPotvrde = new Button();
            btnSpasiUFajl = new Button();
            dgvStudentiPoruke = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Izdata = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            lblTrenutnoPotvrda = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPoruke).BeginInit();
            SuspendLayout();
            // 
            // txtBrojPotvrda
            // 
            txtBrojPotvrda.Location = new Point(12, 35);
            txtBrojPotvrda.Name = "txtBrojPotvrda";
            txtBrojPotvrda.Size = new Size(158, 27);
            txtBrojPotvrda.TabIndex = 0;
            // 
            // btnGenerisiPotvrde
            // 
            btnGenerisiPotvrde.Location = new Point(192, 35);
            btnGenerisiPotvrde.Name = "btnGenerisiPotvrde";
            btnGenerisiPotvrde.Size = new Size(147, 29);
            btnGenerisiPotvrde.TabIndex = 1;
            btnGenerisiPotvrde.Text = "Generisi potvrde";
            btnGenerisiPotvrde.UseVisualStyleBackColor = true;
            btnGenerisiPotvrde.Click += btnGenerisiPotvrde_Click;
            // 
            // btnObrisiPotvrde
            // 
            btnObrisiPotvrde.Location = new Point(423, 35);
            btnObrisiPotvrde.Name = "btnObrisiPotvrde";
            btnObrisiPotvrde.Size = new Size(121, 29);
            btnObrisiPotvrde.TabIndex = 2;
            btnObrisiPotvrde.Text = "Obrisi potvrde";
            btnObrisiPotvrde.UseVisualStyleBackColor = true;
            btnObrisiPotvrde.Click += btnObrisiPotvrde_Click;
            // 
            // btnSpasiUFajl
            // 
            btnSpasiUFajl.Location = new Point(659, 33);
            btnSpasiUFajl.Name = "btnSpasiUFajl";
            btnSpasiUFajl.Size = new Size(129, 29);
            btnSpasiUFajl.TabIndex = 3;
            btnSpasiUFajl.Text = "Spasi u fajl";
            btnSpasiUFajl.UseVisualStyleBackColor = true;
            btnSpasiUFajl.Click += btnSpasiUFajl_Click;
            // 
            // dgvStudentiPoruke
            // 
            dgvStudentiPoruke.AllowUserToAddRows = false;
            dgvStudentiPoruke.AllowUserToDeleteRows = false;
            dgvStudentiPoruke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentiPoruke.Columns.AddRange(new DataGridViewColumn[] { Student, Datum, Svrha, Izdata });
            dgvStudentiPoruke.Location = new Point(12, 83);
            dgvStudentiPoruke.Name = "dgvStudentiPoruke";
            dgvStudentiPoruke.ReadOnly = true;
            dgvStudentiPoruke.RowHeadersWidth = 51;
            dgvStudentiPoruke.RowTemplate.Height = 29;
            dgvStudentiPoruke.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentiPoruke.Size = new Size(776, 326);
            dgvStudentiPoruke.TabIndex = 4;
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
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
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
            // Izdata
            // 
            Izdata.DataPropertyName = "Izdata";
            Izdata.HeaderText = "Izdata";
            Izdata.MinimumWidth = 6;
            Izdata.Name = "Izdata";
            Izdata.ReadOnly = true;
            Izdata.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 421);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 5;
            label1.Text = "Trenutno potvrda:";
            // 
            // lblTrenutnoPotvrda
            // 
            lblTrenutnoPotvrda.AutoSize = true;
            lblTrenutnoPotvrda.Location = new Point(144, 421);
            lblTrenutnoPotvrda.Name = "lblTrenutnoPotvrda";
            lblTrenutnoPotvrda.Size = new Size(0, 20);
            lblTrenutnoPotvrda.TabIndex = 6;
            // 
            // frmPotvrde
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTrenutnoPotvrda);
            Controls.Add(label1);
            Controls.Add(dgvStudentiPoruke);
            Controls.Add(btnSpasiUFajl);
            Controls.Add(btnObrisiPotvrde);
            Controls.Add(btnGenerisiPotvrde);
            Controls.Add(txtBrojPotvrda);
            Name = "frmPotvrde";
            Text = "frmPotvrde";
            Load += frmPotvrde_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentiPoruke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBrojPotvrda;
        private Button btnGenerisiPotvrde;
        private Button btnObrisiPotvrde;
        private Button btnSpasiUFajl;
        private DataGridView dgvStudentiPoruke;
        private Label label1;
        private Label lblTrenutnoPotvrda;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewCheckBoxColumn Izdata;
    }
}