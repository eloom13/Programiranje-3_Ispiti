namespace FIT.WinForms.IspitIBXXXXXX
{
    partial class frmStudentInfo
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
            lblStudent = new Label();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(48, 40);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(301, 255);
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudent.Location = new Point(81, 329);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(97, 41);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "label1";
            lblStudent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Location = new Point(169, 391);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(50, 20);
            lblProsjek.TabIndex = 2;
            lblProsjek.Text = "label1";
            // 
            // frmStudentInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 450);
            Controls.Add(lblProsjek);
            Controls.Add(lblStudent);
            Controls.Add(pbSlika);
            Name = "frmStudentInfo";
            Text = "frmStudentInfo";
            Load += frmStudentInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblStudent;
        private Label lblProsjek;
    }
}