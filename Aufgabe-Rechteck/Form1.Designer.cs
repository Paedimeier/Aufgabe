namespace Aufgabe_Rechteck
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
            this.Berechnen = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Breitetxt = new System.Windows.Forms.TextBox();
            this.Breite = new System.Windows.Forms.Label();
            this.Höhetxt = new System.Windows.Forms.TextBox();
            this.Höhe = new System.Windows.Forms.Label();
            this.Ausgabe = new System.Windows.Forms.Label();
            this.Ergebnis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Berechnen
            // 
            this.Berechnen.Location = new System.Drawing.Point(689, 70);
            this.Berechnen.Name = "Berechnen";
            this.Berechnen.Size = new System.Drawing.Size(275, 51);
            this.Berechnen.TabIndex = 0;
            this.Berechnen.Text = "Berechnen";
            this.Berechnen.UseVisualStyleBackColor = true;
            this.Berechnen.Click += new System.EventHandler(this.Berechnen_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(689, 356);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(271, 59);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Beenden";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Breitetxt
            // 
            this.Breitetxt.Location = new System.Drawing.Point(279, 70);
            this.Breitetxt.Name = "Breitetxt";
            this.Breitetxt.Size = new System.Drawing.Size(313, 26);
            this.Breitetxt.TabIndex = 2;
            this.Breitetxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Breite
            // 
            this.Breite.AutoSize = true;
            this.Breite.Location = new System.Drawing.Point(34, 70);
            this.Breite.Name = "Breite";
            this.Breite.Size = new System.Drawing.Size(161, 20);
            this.Breite.TabIndex = 3;
            this.Breite.Text = "Breite des Rechtecks";
            this.Breite.Click += new System.EventHandler(this.label1_Click);
            // 
            // Höhetxt
            // 
            this.Höhetxt.Location = new System.Drawing.Point(279, 166);
            this.Höhetxt.Name = "Höhetxt";
            this.Höhetxt.Size = new System.Drawing.Size(313, 26);
            this.Höhetxt.TabIndex = 4;
            // 
            // Höhe
            // 
            this.Höhe.AutoSize = true;
            this.Höhe.Location = new System.Drawing.Point(34, 169);
            this.Höhe.Name = "Höhe";
            this.Höhe.Size = new System.Drawing.Size(158, 20);
            this.Höhe.TabIndex = 6;
            this.Höhe.Text = "Höhe des Rechtecks";
            // 
            // Ausgabe
            // 
            this.Ausgabe.AutoSize = true;
            this.Ausgabe.Location = new System.Drawing.Point(34, 375);
            this.Ausgabe.Name = "Ausgabe";
            this.Ausgabe.Size = new System.Drawing.Size(135, 20);
            this.Ausgabe.TabIndex = 7;
            this.Ausgabe.Text = "Ausgabe (Fläche)";
            // 
            // Ergebnis
            // 
            this.Ergebnis.Location = new System.Drawing.Point(279, 369);
            this.Ergebnis.Name = "Ergebnis";
            this.Ergebnis.ReadOnly = true;
            this.Ergebnis.Size = new System.Drawing.Size(313, 26);
            this.Ergebnis.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 612);
            this.Controls.Add(this.Ergebnis);
            this.Controls.Add(this.Ausgabe);
            this.Controls.Add(this.Höhe);
            this.Controls.Add(this.Höhetxt);
            this.Controls.Add(this.Breite);
            this.Controls.Add(this.Breitetxt);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Berechnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Berechnen;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox Breitetxt;
        private System.Windows.Forms.Label Breite;
        private System.Windows.Forms.TextBox Höhetxt;
        private System.Windows.Forms.Label Höhe;
        private System.Windows.Forms.Label Ausgabe;
        private System.Windows.Forms.TextBox Ergebnis;
    }
}

