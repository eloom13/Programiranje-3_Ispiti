namespace DLWMS.WinForms.IspitIBXXXXXX
{
    partial class frmGlavna
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
            btnGodineStudija = new Button();
            btnPolozeniPredmeti = new Button();
            btnThread = new Button();
            txtThread = new TextBox();
            SuspendLayout();
            // 
            // btnGodineStudija
            // 
            btnGodineStudija.Location = new Point(34, 164);
            btnGodineStudija.Name = "btnGodineStudija";
            btnGodineStudija.Size = new Size(175, 76);
            btnGodineStudija.TabIndex = 0;
            btnGodineStudija.Text = "Godine Studija";
            btnGodineStudija.UseVisualStyleBackColor = true;
            btnGodineStudija.Click += btnGodineStudija_Click;
            // 
            // btnPolozeniPredmeti
            // 
            btnPolozeniPredmeti.Location = new Point(300, 164);
            btnPolozeniPredmeti.Name = "btnPolozeniPredmeti";
            btnPolozeniPredmeti.Size = new Size(175, 76);
            btnPolozeniPredmeti.TabIndex = 1;
            btnPolozeniPredmeti.Text = "Polozeni predmeti";
            btnPolozeniPredmeti.UseVisualStyleBackColor = true;
            btnPolozeniPredmeti.Click += btnPolozeniPredmeti_Click;
            // 
            // btnThread
            // 
            btnThread.Location = new Point(545, 203);
            btnThread.Name = "btnThread";
            btnThread.Size = new Size(176, 30);
            btnThread.TabIndex = 2;
            btnThread.Text = "Izracunaj sumu";
            btnThread.UseVisualStyleBackColor = true;
            btnThread.Click += btnThread_Click;
            // 
            // txtThread
            // 
            txtThread.Location = new Point(545, 158);
            txtThread.Name = "txtThread";
            txtThread.Size = new Size(176, 27);
            txtThread.TabIndex = 3;
            // 
            // frmGlavna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 450);
            Controls.Add(txtThread);
            Controls.Add(btnThread);
            Controls.Add(btnPolozeniPredmeti);
            Controls.Add(btnGodineStudija);
            Name = "frmGlavna";
            Text = "frmGlavna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGodineStudija;
        private Button btnPolozeniPredmeti;
        private Button btnThread;
        private TextBox txtThread;
    }
}