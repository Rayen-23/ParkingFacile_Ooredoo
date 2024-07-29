namespace ParkingFacile
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.repasse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inscrire = new System.Windows.Forms.Button();
            this.connecter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-116, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(242, 140);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(315, 40);
            this.nom.TabIndex = 3;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(242, 190);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(315, 40);
            this.email.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(146, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email :";
            // 
            // passe
            // 
            this.passe.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passe.Location = new System.Drawing.Point(242, 240);
            this.passe.Name = "passe";
            this.passe.Size = new System.Drawing.Size(315, 40);
            this.passe.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(57, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mot de passe :";
            // 
            // repasse
            // 
            this.repasse.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repasse.Location = new System.Drawing.Point(242, 290);
            this.repasse.Name = "repasse";
            this.repasse.Size = new System.Drawing.Size(315, 40);
            this.repasse.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label4.Location = new System.Drawing.Point(22, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Re-mot de passe :";
            // 
            // inscrire
            // 
            this.inscrire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.inscrire.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscrire.ForeColor = System.Drawing.Color.White;
            this.inscrire.Location = new System.Drawing.Point(169, 349);
            this.inscrire.Name = "inscrire";
            this.inscrire.Size = new System.Drawing.Size(267, 43);
            this.inscrire.TabIndex = 10;
            this.inscrire.Text = "Inscrire";
            this.inscrire.UseVisualStyleBackColor = false;
            this.inscrire.Click += new System.EventHandler(this.inscrire_Click);
            // 
            // connecter
            // 
            this.connecter.AutoSize = true;
            this.connecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connecter.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connecter.ForeColor = System.Drawing.Color.Blue;
            this.connecter.Location = new System.Drawing.Point(213, 408);
            this.connecter.Name = "connecter";
            this.connecter.Size = new System.Drawing.Size(172, 23);
            this.connecter.TabIndex = 11;
            this.connecter.Text = "J\'ai déja un compte !!";
            this.connecter.Click += new System.EventHandler(this.connecter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 440);
            this.Controls.Add(this.connecter);
            this.Controls.Add(this.inscrire);
            this.Controls.Add(this.repasse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Parking_Facile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox repasse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button inscrire;
        private System.Windows.Forms.Label connecter;
    }
}