namespace PocketDoctor
{
    partial class Inlogscherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inlogscherm));
            this.bsn = new System.Windows.Forms.TextBox();
            this.ww = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.terugKnop = new System.Windows.Forms.Button();
            this.inlogKnop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registratieKnop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsn
            // 
            this.bsn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsn.Location = new System.Drawing.Point(95, 232);
            this.bsn.MaxLength = 9;
            this.bsn.Name = "bsn";
            this.bsn.Size = new System.Drawing.Size(300, 31);
            this.bsn.TabIndex = 0;
            this.bsn.TextChanged += new System.EventHandler(this.Bsn_TextChanged);
            // 
            // ww
            // 
            this.ww.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ww.Location = new System.Drawing.Point(95, 314);
            this.ww.MaxLength = 20;
            this.ww.Name = "ww";
            this.ww.Size = new System.Drawing.Size(300, 31);
            this.ww.TabIndex = 1;
            this.ww.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "BSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wachtwoord";
            // 
            // terugKnop
            // 
            this.terugKnop.AccessibleName = "";
            this.terugKnop.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terugKnop.Location = new System.Drawing.Point(37, 154);
            this.terugKnop.Name = "terugKnop";
            this.terugKnop.Size = new System.Drawing.Size(92, 34);
            this.terugKnop.TabIndex = 4;
            this.terugKnop.Text = "Terug";
            this.terugKnop.UseVisualStyleBackColor = true;
            this.terugKnop.Click += new System.EventHandler(this.terugKnop_Click);
            // 
            // inlogKnop
            // 
            this.inlogKnop.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inlogKnop.Location = new System.Drawing.Point(270, 381);
            this.inlogKnop.Name = "inlogKnop";
            this.inlogKnop.Size = new System.Drawing.Size(167, 36);
            this.inlogKnop.TabIndex = 5;
            this.inlogKnop.Text = "Inloggen";
            this.inlogKnop.UseVisualStyleBackColor = true;
            this.inlogKnop.Click += new System.EventHandler(this.inlogKnop_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(85, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 59);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pocket Doctor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(37, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 2);
            this.label4.TabIndex = 7;
            // 
            // registratieKnop
            // 
            this.registratieKnop.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registratieKnop.Location = new System.Drawing.Point(37, 381);
            this.registratieKnop.Name = "registratieKnop";
            this.registratieKnop.Size = new System.Drawing.Size(150, 36);
            this.registratieKnop.TabIndex = 8;
            this.registratieKnop.Text = "Geen account?";
            this.registratieKnop.UseVisualStyleBackColor = true;
            this.registratieKnop.Click += new System.EventHandler(this.registratieKnop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Inlogscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registratieKnop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inlogKnop);
            this.Controls.Add(this.terugKnop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ww);
            this.Controls.Add(this.bsn);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inlogscherm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocket Doctor - Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bsn;
        private System.Windows.Forms.TextBox ww;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button terugKnop;
        private System.Windows.Forms.Button inlogKnop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registratieKnop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}