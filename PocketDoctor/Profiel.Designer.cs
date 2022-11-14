namespace PocketDoctor
{
    partial class Profiel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profiel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.terugKnop = new System.Windows.Forms.Button();
            this.BSNbox = new System.Windows.Forms.TextBox();
            this.Telnrbox = new System.Windows.Forms.TextBox();
            this.geslachtBox = new System.Windows.Forms.ComboBox();
            this.verifWwBox = new System.Windows.Forms.TextBox();
            this.wwBox = new System.Windows.Forms.TextBox();
            this.mailadresBox = new System.Windows.Forms.TextBox();
            this.gebdatumBox = new System.Windows.Forms.TextBox();
            this.achternaamBox = new System.Windows.Forms.TextBox();
            this.voornaamBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveKnop = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(42, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(500, 2);
            this.label10.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(130, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(320, 59);
            this.label11.TabIndex = 38;
            this.label11.Text = "Pocket Doctor";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // terugKnop
            // 
            this.terugKnop.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terugKnop.Location = new System.Drawing.Point(480, 12);
            this.terugKnop.Name = "terugKnop";
            this.terugKnop.Size = new System.Drawing.Size(92, 34);
            this.terugKnop.TabIndex = 37;
            this.terugKnop.Text = "Terug";
            this.terugKnop.UseVisualStyleBackColor = true;
            this.terugKnop.Click += new System.EventHandler(this.terugKnop_Click);
            // 
            // BSNbox
            // 
            this.BSNbox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSNbox.Location = new System.Drawing.Point(302, 442);
            this.BSNbox.Name = "BSNbox";
            this.BSNbox.ReadOnly = true;
            this.BSNbox.Size = new System.Drawing.Size(200, 27);
            this.BSNbox.TabIndex = 58;
            // 
            // Telnrbox
            // 
            this.Telnrbox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telnrbox.Location = new System.Drawing.Point(331, 403);
            this.Telnrbox.MaxLength = 8;
            this.Telnrbox.Name = "Telnrbox";
            this.Telnrbox.Size = new System.Drawing.Size(171, 27);
            this.Telnrbox.TabIndex = 57;
            this.Telnrbox.TextChanged += new System.EventHandler(this.Telnrbox_TextChanged);
            // 
            // geslachtBox
            // 
            this.geslachtBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.geslachtBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geslachtBox.FormattingEnabled = true;
            this.geslachtBox.Items.AddRange(new object[] {
            "Man",
            "Vrouw"});
            this.geslachtBox.Location = new System.Drawing.Point(302, 364);
            this.geslachtBox.Name = "geslachtBox";
            this.geslachtBox.Size = new System.Drawing.Size(121, 27);
            this.geslachtBox.TabIndex = 56;
            // 
            // verifWwBox
            // 
            this.verifWwBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifWwBox.Location = new System.Drawing.Point(302, 325);
            this.verifWwBox.Name = "verifWwBox";
            this.verifWwBox.ReadOnly = true;
            this.verifWwBox.Size = new System.Drawing.Size(200, 27);
            this.verifWwBox.TabIndex = 55;
            this.verifWwBox.UseSystemPasswordChar = true;
            // 
            // wwBox
            // 
            this.wwBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wwBox.Location = new System.Drawing.Point(302, 286);
            this.wwBox.Name = "wwBox";
            this.wwBox.ReadOnly = true;
            this.wwBox.Size = new System.Drawing.Size(200, 27);
            this.wwBox.TabIndex = 54;
            this.wwBox.UseSystemPasswordChar = true;
            // 
            // mailadresBox
            // 
            this.mailadresBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailadresBox.Location = new System.Drawing.Point(302, 247);
            this.mailadresBox.MaxLength = 50;
            this.mailadresBox.Name = "mailadresBox";
            this.mailadresBox.Size = new System.Drawing.Size(200, 27);
            this.mailadresBox.TabIndex = 53;
            // 
            // gebdatumBox
            // 
            this.gebdatumBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebdatumBox.Location = new System.Drawing.Point(302, 208);
            this.gebdatumBox.Name = "gebdatumBox";
            this.gebdatumBox.ReadOnly = true;
            this.gebdatumBox.Size = new System.Drawing.Size(200, 27);
            this.gebdatumBox.TabIndex = 52;
            // 
            // achternaamBox
            // 
            this.achternaamBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achternaamBox.Location = new System.Drawing.Point(302, 169);
            this.achternaamBox.Name = "achternaamBox";
            this.achternaamBox.ReadOnly = true;
            this.achternaamBox.Size = new System.Drawing.Size(200, 27);
            this.achternaamBox.TabIndex = 51;
            // 
            // voornaamBox
            // 
            this.voornaamBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voornaamBox.Location = new System.Drawing.Point(302, 130);
            this.voornaamBox.Name = "voornaamBox";
            this.voornaamBox.ReadOnly = true;
            this.voornaamBox.Size = new System.Drawing.Size(200, 27);
            this.voornaamBox.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 403);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Telefoon-nummer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 442);
            this.label9.Margin = new System.Windows.Forms.Padding(10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 48;
            this.label9.Text = "BSN (?)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 47;
            this.label8.Text = "Voornaam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 46;
            this.label7.Text = "Achternaam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Geboortedatum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Emailadres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Wachtwoord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Herhaal wachtwoord";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Geslacht";
            // 
            // saveKnop
            // 
            this.saveKnop.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveKnop.Location = new System.Drawing.Point(422, 507);
            this.saveKnop.Name = "saveKnop";
            this.saveKnop.Size = new System.Drawing.Size(150, 42);
            this.saveKnop.TabIndex = 60;
            this.saveKnop.Text = "Bewerken";
            this.saveKnop.UseVisualStyleBackColor = true;
            this.saveKnop.Click += new System.EventHandler(this.saveKnop_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 12F);
            this.label12.Location = new System.Drawing.Point(298, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 19);
            this.label12.TabIndex = 61;
            this.label12.Text = "06";
            // 
            // Profiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.saveKnop);
            this.Controls.Add(this.BSNbox);
            this.Controls.Add(this.Telnrbox);
            this.Controls.Add(this.geslachtBox);
            this.Controls.Add(this.verifWwBox);
            this.Controls.Add(this.wwBox);
            this.Controls.Add(this.mailadresBox);
            this.Controls.Add(this.gebdatumBox);
            this.Controls.Add(this.achternaamBox);
            this.Controls.Add(this.voornaamBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.terugKnop);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Profiel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocket Doctor - Profiel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button terugKnop;
        private System.Windows.Forms.TextBox BSNbox;
        private System.Windows.Forms.TextBox Telnrbox;
        private System.Windows.Forms.ComboBox geslachtBox;
        private System.Windows.Forms.TextBox verifWwBox;
        private System.Windows.Forms.TextBox wwBox;
        private System.Windows.Forms.TextBox mailadresBox;
        private System.Windows.Forms.TextBox gebdatumBox;
        private System.Windows.Forms.TextBox achternaamBox;
        private System.Windows.Forms.TextBox voornaamBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveKnop;
        private System.Windows.Forms.Label label12;
    }
}