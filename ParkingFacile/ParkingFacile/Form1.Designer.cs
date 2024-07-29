namespace ParkingFacile
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connecter = new System.Windows.Forms.Button();
            this.inscrire = new System.Windows.Forms.Button();
            this.admon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-116, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fatigué de chercher une places dans notre parking ? \r\nAvec Parking Facile, vous n" +
    "’êtes pas obligé ! \r\nRéservez simplement une place de parking à temps et\r\nallez " +
    "travailler quand vous en avez besoin. ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // connecter
            // 
            this.connecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.connecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connecter.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connecter.ForeColor = System.Drawing.Color.White;
            this.connecter.Location = new System.Drawing.Point(52, 302);
            this.connecter.Name = "connecter";
            this.connecter.Size = new System.Drawing.Size(209, 81);
            this.connecter.TabIndex = 2;
            this.connecter.Text = "Se Connecter";
            this.connecter.UseVisualStyleBackColor = false;
            this.connecter.Click += new System.EventHandler(this.connecter_Click);
            // 
            // inscrire
            // 
            this.inscrire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.inscrire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inscrire.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscrire.ForeColor = System.Drawing.Color.White;
            this.inscrire.Location = new System.Drawing.Point(309, 302);
            this.inscrire.Name = "inscrire";
            this.inscrire.Size = new System.Drawing.Size(209, 81);
            this.inscrire.TabIndex = 3;
            this.inscrire.Text = "Inscrire";
            this.inscrire.UseVisualStyleBackColor = false;
            this.inscrire.Click += new System.EventHandler(this.inscrire_Click);
            // 
            // admon
            // 
            this.admon.AutoSize = true;
            this.admon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admon.ForeColor = System.Drawing.Color.Blue;
            this.admon.Location = new System.Drawing.Point(172, 402);
            this.admon.Name = "admon";
            this.admon.Size = new System.Drawing.Size(217, 23);
            this.admon.TabIndex = 4;
            this.admon.Text = "Je suis un administrateur !!";
            this.admon.Click += new System.EventHandler(this.admon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 440);
            this.Controls.Add(this.admon);
            this.Controls.Add(this.inscrire);
            this.Controls.Add(this.connecter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Parking_Facile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connecter;
        private System.Windows.Forms.Button inscrire;
        private System.Windows.Forms.Label admon;
    }
}

