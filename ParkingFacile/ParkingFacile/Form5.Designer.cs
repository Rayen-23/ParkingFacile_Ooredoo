namespace ParkingFacile
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cvv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.payement = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "N°Carte :";
            // 
            // numero
            // 
            this.numero.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.ForeColor = System.Drawing.Color.Blue;
            this.numero.Location = new System.Drawing.Point(133, 156);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(424, 40);
            this.numero.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(118, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date d\'expiration :";
            // 
            // date
            // 
            this.date.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.date.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.date.Font = new System.Drawing.Font("Calibri", 17.25F);
            this.date.Location = new System.Drawing.Point(345, 205);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(212, 36);
            this.date.TabIndex = 4;
            this.date.Value = new System.DateTime(2024, 7, 16, 0, 0, 0, 0);
            // 
            // cvv
            // 
            this.cvv.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvv.ForeColor = System.Drawing.Color.Blue;
            this.cvv.Location = new System.Drawing.Point(345, 250);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(212, 40);
            this.cvv.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(265, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "CVV :";
            // 
            // payement
            // 
            this.payement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(27)))), ((int)(((byte)(36)))));
            this.payement.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payement.ForeColor = System.Drawing.Color.White;
            this.payement.Location = new System.Drawing.Point(19, 337);
            this.payement.Name = "payement";
            this.payement.Size = new System.Drawing.Size(539, 45);
            this.payement.TabIndex = 25;
            this.payement.Text = "Payer";
            this.payement.UseVisualStyleBackColor = false;
            this.payement.Click += new System.EventHandler(this.payement_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(120, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tu doit payer 5 TND pour votre place\r\n";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 394);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.payement);
            this.Controls.Add(this.cvv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Parking_Facile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox cvv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button payement;
        private System.Windows.Forms.Label label4;
    }
}