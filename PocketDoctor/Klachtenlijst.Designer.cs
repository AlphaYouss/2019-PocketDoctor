namespace PocketDoctor
{
    partial class Klachtenlijst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klachtenlijst));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Persoongegevens_wijzigen = new System.Windows.Forms.ToolStripMenuItem();
            this.Uitloggen = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tempBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.moeJa = new System.Windows.Forms.RadioButton();
            this.moeNee = new System.Windows.Forms.RadioButton();
            this.hoofdpijnNee = new System.Windows.Forms.RadioButton();
            this.hoofdpijnJa = new System.Windows.Forms.RadioButton();
            this.misselijkNee = new System.Windows.Forms.RadioButton();
            this.misselijkJa = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.spierpijnJa = new System.Windows.Forms.RadioButton();
            this.spierpijnNee = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(424, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Terug";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.terug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Diagnose";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Persoongegevens_wijzigen,
            this.Uitloggen});
            this.Menu.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(48, 20);
            this.Menu.Text = "Menu";
            // 
            // Persoongegevens_wijzigen
            // 
            this.Persoongegevens_wijzigen.Name = "Persoongegevens_wijzigen";
            this.Persoongegevens_wijzigen.Size = new System.Drawing.Size(210, 22);
            this.Persoongegevens_wijzigen.Text = "Persoongegevens wijzigen";
            this.Persoongegevens_wijzigen.Click += new System.EventHandler(this.persoongegevens_wijzigen_Click);
            // 
            // Uitloggen
            // 
            this.Uitloggen.Name = "Uitloggen";
            this.Uitloggen.Size = new System.Drawing.Size(210, 22);
            this.Uitloggen.Text = "Uitloggen";
            this.Uitloggen.Click += new System.EventHandler(this.uiloggen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Wat is uw lichaamstemperatuur?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Heeft u last van moeheid?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Heeft u last van hoofdpijn?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bent u misselijk?";
            // 
            // tempBox
            // 
            this.tempBox.DecimalPlaces = 1;
            this.tempBox.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tempBox.Location = new System.Drawing.Point(33, 217);
            this.tempBox.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.tempBox.Minimum = new decimal(new int[] {
            33,
            0,
            0,
            0});
            this.tempBox.Name = "tempBox";
            this.tempBox.Size = new System.Drawing.Size(120, 26);
            this.tempBox.TabIndex = 23;
            this.tempBox.Value = new decimal(new int[] {
            34,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(424, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 24;
            this.button1.Text = "Klaar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // moeJa
            // 
            this.moeJa.AutoSize = true;
            this.moeJa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moeJa.Location = new System.Drawing.Point(10, 46);
            this.moeJa.Name = "moeJa";
            this.moeJa.Size = new System.Drawing.Size(42, 23);
            this.moeJa.TabIndex = 26;
            this.moeJa.TabStop = true;
            this.moeJa.Text = "Ja";
            this.moeJa.UseVisualStyleBackColor = true;
            // 
            // moeNee
            // 
            this.moeNee.AutoSize = true;
            this.moeNee.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moeNee.Location = new System.Drawing.Point(100, 46);
            this.moeNee.Name = "moeNee";
            this.moeNee.Size = new System.Drawing.Size(54, 23);
            this.moeNee.TabIndex = 27;
            this.moeNee.TabStop = true;
            this.moeNee.Text = "Nee";
            this.moeNee.UseVisualStyleBackColor = true;
            // 
            // hoofdpijnNee
            // 
            this.hoofdpijnNee.AutoSize = true;
            this.hoofdpijnNee.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoofdpijnNee.Location = new System.Drawing.Point(100, 46);
            this.hoofdpijnNee.Name = "hoofdpijnNee";
            this.hoofdpijnNee.Size = new System.Drawing.Size(54, 23);
            this.hoofdpijnNee.TabIndex = 29;
            this.hoofdpijnNee.TabStop = true;
            this.hoofdpijnNee.Text = "Nee";
            this.hoofdpijnNee.UseVisualStyleBackColor = true;
            // 
            // hoofdpijnJa
            // 
            this.hoofdpijnJa.AutoSize = true;
            this.hoofdpijnJa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoofdpijnJa.Location = new System.Drawing.Point(10, 46);
            this.hoofdpijnJa.Name = "hoofdpijnJa";
            this.hoofdpijnJa.Size = new System.Drawing.Size(42, 23);
            this.hoofdpijnJa.TabIndex = 28;
            this.hoofdpijnJa.TabStop = true;
            this.hoofdpijnJa.Text = "Ja";
            this.hoofdpijnJa.UseVisualStyleBackColor = true;
            // 
            // misselijkNee
            // 
            this.misselijkNee.AutoSize = true;
            this.misselijkNee.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.misselijkNee.Location = new System.Drawing.Point(101, 46);
            this.misselijkNee.Name = "misselijkNee";
            this.misselijkNee.Size = new System.Drawing.Size(54, 23);
            this.misselijkNee.TabIndex = 31;
            this.misselijkNee.TabStop = true;
            this.misselijkNee.Text = "Nee";
            this.misselijkNee.UseVisualStyleBackColor = true;
            // 
            // misselijkJa
            // 
            this.misselijkJa.AutoSize = true;
            this.misselijkJa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.misselijkJa.Location = new System.Drawing.Point(11, 46);
            this.misselijkJa.Name = "misselijkJa";
            this.misselijkJa.Size = new System.Drawing.Size(42, 23);
            this.misselijkJa.TabIndex = 30;
            this.misselijkJa.TabStop = true;
            this.misselijkJa.Text = "Ja";
            this.misselijkJa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.moeJa);
            this.groupBox1.Controls.Add(this.moeNee);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 82);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moeheid";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.hoofdpijnJa);
            this.groupBox2.Controls.Add(this.hoofdpijnNee);
            this.groupBox2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 82);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoofdpijn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.misselijkJa);
            this.groupBox3.Controls.Add(this.misselijkNee);
            this.groupBox3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(293, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 82);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misselijkheid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Heeft u last van spierpijn?";
            // 
            // spierpijnJa
            // 
            this.spierpijnJa.AutoSize = true;
            this.spierpijnJa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spierpijnJa.Location = new System.Drawing.Point(10, 46);
            this.spierpijnJa.Name = "spierpijnJa";
            this.spierpijnJa.Size = new System.Drawing.Size(42, 23);
            this.spierpijnJa.TabIndex = 30;
            this.spierpijnJa.TabStop = true;
            this.spierpijnJa.Text = "Ja";
            this.spierpijnJa.UseVisualStyleBackColor = true;
            // 
            // spierpijnNee
            // 
            this.spierpijnNee.AutoSize = true;
            this.spierpijnNee.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spierpijnNee.Location = new System.Drawing.Point(100, 46);
            this.spierpijnNee.Name = "spierpijnNee";
            this.spierpijnNee.Size = new System.Drawing.Size(54, 23);
            this.spierpijnNee.TabIndex = 31;
            this.spierpijnNee.TabStop = true;
            this.spierpijnNee.Text = "Nee";
            this.spierpijnNee.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.spierpijnJa);
            this.groupBox4.Controls.Add(this.spierpijnNee);
            this.groupBox4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(294, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 82);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spierpijn";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(13, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(557, 2);
            this.label7.TabIndex = 32;
            // 
            // Klachtenlijst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tempBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Klachtenlijst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocket Doctor - Klachtenlijst";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private new System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem Persoongegevens_wijzigen;
        private System.Windows.Forms.ToolStripMenuItem Uitloggen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown tempBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton moeJa;
        private System.Windows.Forms.RadioButton moeNee;
        private System.Windows.Forms.RadioButton hoofdpijnNee;
        private System.Windows.Forms.RadioButton hoofdpijnJa;
        private System.Windows.Forms.RadioButton misselijkNee;
        private System.Windows.Forms.RadioButton misselijkJa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton spierpijnJa;
        private System.Windows.Forms.RadioButton spierpijnNee;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
    }
}