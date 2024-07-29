namespace ParkingFacile
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.repasse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enregistrer = new System.Windows.Forms.Button();
            this.chec = new System.Windows.Forms.Button();
            this.envoier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-115, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(177, 124);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(380, 40);
            this.email.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Votre Email :";
            // 
            // code
            // 
            this.code.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.Location = new System.Drawing.Point(232, 174);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(325, 40);
            this.code.TabIndex = 13;
            this.code.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Votre Code Recu :";
            this.label1.Visible = false;
            // 
            // passe
            // 
            this.passe.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passe.Location = new System.Drawing.Point(306, 225);
            this.passe.Name = "passe";
            this.passe.Size = new System.Drawing.Size(251, 40);
            this.passe.TabIndex = 15;
            this.passe.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nouveau Mot De Passe :";
            this.label2.Visible = false;
            // 
            // repasse
            // 
            this.repasse.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repasse.Location = new System.Drawing.Point(306, 276);
            this.repasse.Name = "repasse";
            this.repasse.Size = new System.Drawing.Size(251, 40);
            this.repasse.TabIndex = 17;
            this.repasse.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label4.Location = new System.Drawing.Point(82, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "Re-Mot De Passe :";
            this.label4.Visible = false;
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.Green;
            this.enregistrer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(199, 350);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(175, 53);
            this.enregistrer.TabIndex = 18;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Visible = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // chec
            // 
            this.chec.BackColor = System.Drawing.Color.Teal;
            this.chec.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chec.ForeColor = System.Drawing.Color.White;
            this.chec.Location = new System.Drawing.Point(199, 350);
            this.chec.Name = "chec";
            this.chec.Size = new System.Drawing.Size(175, 53);
            this.chec.TabIndex = 19;
            this.chec.Text = "Check Code";
            this.chec.UseVisualStyleBackColor = false;
            this.chec.Visible = false;
            this.chec.Click += new System.EventHandler(this.chec_Click);
            // 
            // envoier
            // 
            this.envoier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.envoier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.envoier.ForeColor = System.Drawing.Color.White;
            this.envoier.Location = new System.Drawing.Point(199, 350);
            this.envoier.Name = "envoier";
            this.envoier.Size = new System.Drawing.Size(175, 53);
            this.envoier.TabIndex = 20;
            this.envoier.Text = "Envoier Code";
            this.envoier.UseVisualStyleBackColor = false;
            this.envoier.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 440);
            this.Controls.Add(this.envoier);
            this.Controls.Add(this.chec);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.repasse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Parking_Facile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox repasse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button chec;
        private System.Windows.Forms.Button envoier;
    }
}