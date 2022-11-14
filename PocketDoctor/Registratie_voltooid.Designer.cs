namespace PocketDoctor
{
    partial class Registratie_voltooid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registratie_voltooid));
            this.label1 = new System.Windows.Forms.Label();
            this.inlogKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account is succesvol \r\naangemaakt!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inlogKnop
            // 
            this.inlogKnop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.inlogKnop.Font = new System.Drawing.Font("Candara Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inlogKnop.Location = new System.Drawing.Point(66, 166);
            this.inlogKnop.Name = "inlogKnop";
            this.inlogKnop.Size = new System.Drawing.Size(239, 51);
            this.inlogKnop.TabIndex = 3;
            this.inlogKnop.Text = "Inloggen";
            this.inlogKnop.UseVisualStyleBackColor = false;
            this.inlogKnop.Click += new System.EventHandler(this.inlogKnop_Click);
            // 
            // Registratie_voltooid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.inlogKnop);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Registratie_voltooid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocket Doctor - Registratie voltooid!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inlogKnop;
    }
}