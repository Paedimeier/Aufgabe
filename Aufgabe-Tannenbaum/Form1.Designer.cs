namespace Aufgabe_Tannenbaum
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.breite = new System.Windows.Forms.TextBox();
            this.KHöhe = new System.Windows.Forms.TextBox();
            this.SHöhe = new System.Windows.Forms.TextBox();
            this.draw = new System.Windows.Forms.Button();
            this.Ausgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stammbreite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stammhöhe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kronenhöhe";
            // 
            // breite
            // 
            this.breite.Location = new System.Drawing.Point(128, 19);
            this.breite.Name = "breite";
            this.breite.Size = new System.Drawing.Size(129, 26);
            this.breite.TabIndex = 3;
            // 
            // KHöhe
            // 
            this.KHöhe.Location = new System.Drawing.Point(128, 117);
            this.KHöhe.Name = "KHöhe";
            this.KHöhe.Size = new System.Drawing.Size(129, 26);
            this.KHöhe.TabIndex = 4;
            // 
            // SHöhe
            // 
            this.SHöhe.Location = new System.Drawing.Point(128, 65);
            this.SHöhe.Name = "SHöhe";
            this.SHöhe.Size = new System.Drawing.Size(129, 26);
            this.SHöhe.TabIndex = 5;
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(288, 115);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(142, 31);
            this.draw.TabIndex = 6;
            this.draw.Text = "Tanne zeichnen";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ausgabe
            // 
            this.Ausgabe.Location = new System.Drawing.Point(16, 163);
            this.Ausgabe.Multiline = true;
            this.Ausgabe.Name = "Ausgabe";
            this.Ausgabe.ReadOnly = true;
            this.Ausgabe.Size = new System.Drawing.Size(413, 510);
            this.Ausgabe.TabIndex = 7;
            this.Ausgabe.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 685);
            this.Controls.Add(this.Ausgabe);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.SHöhe);
            this.Controls.Add(this.KHöhe);
            this.Controls.Add(this.breite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox breite;
        private System.Windows.Forms.TextBox KHöhe;
        private System.Windows.Forms.TextBox SHöhe;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.TextBox Ausgabe;
    }
}

