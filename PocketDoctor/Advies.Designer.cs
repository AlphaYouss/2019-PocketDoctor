namespace PocketDoctor
{
    partial class Advies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advies));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Persoonsgegevens_aanpassen = new System.Windows.Forms.ToolStripMenuItem();
            this.Uitloggen = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.beschrijvingBox = new System.Windows.Forms.RichTextBox();
            this.adviesBox = new System.Windows.Forms.RichTextBox();
            this.ziekteLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beschrijving:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wat kan je doen:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(172, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Chat met huisarts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.chat_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(422, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "Terug";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.terug_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Persoonsgegevens_aanpassen,
            this.Uitloggen});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // Persoonsgegevens_aanpassen
            // 
            this.Persoonsgegevens_aanpassen.Name = "Persoonsgegevens_aanpassen";
            this.Persoonsgegevens_aanpassen.Size = new System.Drawing.Size(215, 22);
            this.Persoonsgegevens_aanpassen.Text = "Persoonsgegevens wijzigen";
            this.Persoonsgegevens_aanpassen.Click += new System.EventHandler(this.Persoonsgegevens_aanpassen_Click);
            // 
            // Uitloggen
            // 
            this.Uitloggen.Name = "Uitloggen";
            this.Uitloggen.Size = new System.Drawing.Size(215, 22);
            this.Uitloggen.Text = "Uitloggen";
            this.Uitloggen.Click += new System.EventHandler(this.uitloggen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Diagnose:";
            // 
            // beschrijvingBox
            // 
            this.beschrijvingBox.Enabled = false;
            this.beschrijvingBox.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beschrijvingBox.Location = new System.Drawing.Point(59, 212);
            this.beschrijvingBox.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.beschrijvingBox.Name = "beschrijvingBox";
            this.beschrijvingBox.ReadOnly = true;
            this.beschrijvingBox.Size = new System.Drawing.Size(466, 102);
            this.beschrijvingBox.TabIndex = 15;
            this.beschrijvingBox.Text = "";
            // 
            // adviesBox
            // 
            this.adviesBox.Enabled = false;
            this.adviesBox.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adviesBox.Location = new System.Drawing.Point(59, 362);
            this.adviesBox.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.adviesBox.Name = "adviesBox";
            this.adviesBox.ReadOnly = true;
            this.adviesBox.Size = new System.Drawing.Size(466, 102);
            this.adviesBox.TabIndex = 16;
            this.adviesBox.Text = "";
            // 
            // ziekteLabel
            // 
            this.ziekteLabel.AutoSize = true;
            this.ziekteLabel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ziekteLabel.Location = new System.Drawing.Point(219, 104);
            this.ziekteLabel.Name = "ziekteLabel";
            this.ziekteLabel.Size = new System.Drawing.Size(0, 26);
            this.ziekteLabel.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(13, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(557, 2);
            this.label7.TabIndex = 33;
            // 
            // Advies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ziekteLabel);
            this.Controls.Add(this.adviesBox);
            this.Controls.Add(this.beschrijvingBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Advies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocket Doctor - Advies";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Persoonsgegevens_aanpassen;
        private System.Windows.Forms.ToolStripMenuItem Uitloggen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox beschrijvingBox;
        private System.Windows.Forms.RichTextBox adviesBox;
        private System.Windows.Forms.Label ziekteLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}