namespace SerbatoioAcqua
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lamp1 = new System.Windows.Forms.PictureBox();
            this.Siren1 = new System.Windows.Forms.PictureBox();
            this.Lamp2 = new System.Windows.Forms.PictureBox();
            this.Siren2 = new System.Windows.Forms.PictureBox();
            this.Serbatoio1 = new System.Windows.Forms.Label();
            this.Serbatoio2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lamp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Siren1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lamp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Siren2)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.progressBar1.Location = new System.Drawing.Point(9, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(500, 100);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 10;
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.progressBar2.Location = new System.Drawing.Point(6, 276);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(500, 100);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 1;
            this.progressBar2.Value = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Serbatoio2);
            this.tabPage1.Controls.Add(this.Serbatoio1);
            this.tabPage1.Controls.Add(this.Siren2);
            this.tabPage1.Controls.Add(this.Lamp2);
            this.tabPage1.Controls.Add(this.Siren1);
            this.tabPage1.Controls.Add(this.Lamp1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.progressBar2);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Impianto A";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Impianto B";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serbatoio 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serbatoio 2";
            // 
            // Lamp1
            // 
            this.Lamp1.Location = new System.Drawing.Point(515, 35);
            this.Lamp1.Name = "Lamp1";
            this.Lamp1.Size = new System.Drawing.Size(55, 50);
            this.Lamp1.TabIndex = 4;
            this.Lamp1.TabStop = false;
            // 
            // Siren1
            // 
            this.Siren1.Location = new System.Drawing.Point(576, 35);
            this.Siren1.Name = "Siren1";
            this.Siren1.Size = new System.Drawing.Size(55, 50);
            this.Siren1.TabIndex = 5;
            this.Siren1.TabStop = false;
            // 
            // Lamp2
            // 
            this.Lamp2.Location = new System.Drawing.Point(515, 276);
            this.Lamp2.Name = "Lamp2";
            this.Lamp2.Size = new System.Drawing.Size(55, 50);
            this.Lamp2.TabIndex = 6;
            this.Lamp2.TabStop = false;
            // 
            // Siren2
            // 
            this.Siren2.Location = new System.Drawing.Point(576, 276);
            this.Siren2.Name = "Siren2";
            this.Siren2.Size = new System.Drawing.Size(55, 50);
            this.Siren2.TabIndex = 7;
            this.Siren2.TabStop = false;
            // 
            // Serbatoio1
            // 
            this.Serbatoio1.AutoSize = true;
            this.Serbatoio1.Location = new System.Drawing.Point(433, 16);
            this.Serbatoio1.Name = "Serbatoio1";
            this.Serbatoio1.Size = new System.Drawing.Size(19, 16);
            this.Serbatoio1.TabIndex = 8;
            this.Serbatoio1.Text = "xx";
            // 
            // Serbatoio2
            // 
            this.Serbatoio2.AutoSize = true;
            this.Serbatoio2.Location = new System.Drawing.Point(430, 257);
            this.Serbatoio2.Name = "Serbatoio2";
            this.Serbatoio2.Size = new System.Drawing.Size(19, 16);
            this.Serbatoio2.TabIndex = 9;
            this.Serbatoio2.Text = "xx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lamp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Siren1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lamp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Siren2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox Siren2;
        private System.Windows.Forms.PictureBox Lamp2;
        private System.Windows.Forms.PictureBox Siren1;
        private System.Windows.Forms.PictureBox Lamp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Serbatoio2;
        private System.Windows.Forms.Label Serbatoio1;
    }
}

