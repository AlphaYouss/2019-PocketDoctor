namespace PocketDoctor
{
    partial class Huisarts_chat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Huisarts_chat));
            this.Terug = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.ListBox();
            this.invoerBox = new System.Windows.Forms.TextBox();
            this.Verzend_bericht = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Persoonsgegevens_wijzigen = new System.Windows.Forms.ToolStripMenuItem();
            this.Uitloggen = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datum_chatBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Terug
            // 
            this.Terug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Terug.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terug.Location = new System.Drawing.Point(421, 37);
            this.Terug.Name = "Terug";
            this.Terug.Size = new System.Drawing.Size(151, 43);
            this.Terug.TabIndex = 1;
            this.Terug.Text = "Terug";
            this.Terug.UseVisualStyleBackColor = true;
            this.Terug.Click += new System.EventHandler(this.terug_Click);
            // 
            // chatBox
            // 
            this.chatBox.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBox.FormattingEnabled = true;
            this.chatBox.ItemHeight = 18;
            this.chatBox.Location = new System.Drawing.Point(136, 131);
            this.chatBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.chatBox.Name = "chatBox";
            this.chatBox.ScrollAlwaysVisible = true;
            this.chatBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.chatBox.Size = new System.Drawing.Size(436, 310);
            this.chatBox.TabIndex = 2;
            // 
            // invoerBox
            // 
            this.invoerBox.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoerBox.Location = new System.Drawing.Point(13, 447);
            this.invoerBox.Name = "invoerBox";
            this.invoerBox.Size = new System.Drawing.Size(559, 31);
            this.invoerBox.TabIndex = 3;
            // 
            // Verzend_bericht
            // 
            this.Verzend_bericht.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verzend_bericht.Location = new System.Drawing.Point(422, 507);
            this.Verzend_bericht.Name = "Verzend_bericht";
            this.Verzend_bericht.Size = new System.Drawing.Size(150, 42);
            this.Verzend_bericht.TabIndex = 4;
            this.Verzend_bericht.Text = "Verzenden";
            this.Verzend_bericht.UseVisualStyleBackColor = true;
            this.Verzend_bericht.Click += new System.EventHandler(this.verzend_bericht_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chat met huisarts";
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
            this.Persoonsgegevens_wijzigen,
            this.Uitloggen});
            this.Menu.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(48, 20);
            this.Menu.Text = "Menu";
            // 
            // Persoonsgegevens_wijzigen
            // 
            this.Persoonsgegevens_wijzigen.Name = "Persoonsgegevens_wijzigen";
            this.Persoonsgegevens_wijzigen.Size = new System.Drawing.Size(215, 22);
            this.Persoonsgegevens_wijzigen.Text = "Persoonsgegevens wijzigen";
            this.Persoonsgegevens_wijzigen.Click += new System.EventHandler(this.Persoonsgegevens_wijzigen_Click);
            // 
            // Uitloggen
            // 
            this.Uitloggen.Name = "Uitloggen";
            this.Uitloggen.Size = new System.Drawing.Size(215, 22);
            this.Uitloggen.Text = "Uitloggen";
            this.Uitloggen.Click += new System.EventHandler(this.uitloggen_Click);
            // 
            // datum_chatBox
            // 
            this.datum_chatBox.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datum_chatBox.FormattingEnabled = true;
            this.datum_chatBox.ItemHeight = 18;
            this.datum_chatBox.Location = new System.Drawing.Point(13, 131);
            this.datum_chatBox.Margin = new System.Windows.Forms.Padding(0);
            this.datum_chatBox.Name = "datum_chatBox";
            this.datum_chatBox.Size = new System.Drawing.Size(123, 310);
            this.datum_chatBox.TabIndex = 13;
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
            // 
            // Huisarts_chat
            // 
            this.AcceptButton = this.Verzend_bericht;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.datum_chatBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Verzend_bericht);
            this.Controls.Add(this.invoerBox);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.Terug);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Huisarts_chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocket Doctor - Huisarts chat";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Terug;
        private System.Windows.Forms.ListBox chatBox;
        private System.Windows.Forms.TextBox invoerBox;
        private System.Windows.Forms.Button Verzend_bericht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private new System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem Persoonsgegevens_wijzigen;
        private System.Windows.Forms.ToolStripMenuItem Uitloggen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox datum_chatBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}