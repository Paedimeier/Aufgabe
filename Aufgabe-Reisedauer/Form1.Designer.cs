namespace Aufgabe_Reisedauer
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
            this.Days = new System.Windows.Forms.RadioButton();
            this.Hours = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Eingabe = new System.Windows.Forms.TextBox();
            this.berechenen = new System.Windows.Forms.Button();
            this.Dauer = new System.Windows.Forms.Label();
            this.Ausgabe = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Days
            // 
            this.Days.AutoSize = true;
            this.Days.Location = new System.Drawing.Point(31, 40);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(95, 24);
            this.Days.TabIndex = 0;
            this.Days.TabStop = true;
            this.Days.Text = "in Tagen";
            this.Days.UseVisualStyleBackColor = true;
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Location = new System.Drawing.Point(160, 40);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(111, 24);
            this.Hours.TabIndex = 1;
            this.Hours.TabStop = true;
            this.Hours.Text = "in Stunden";
            this.Hours.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Geschwindigkeit km/h";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Eingabe
            // 
            this.Eingabe.Location = new System.Drawing.Point(196, 87);
            this.Eingabe.Name = "Eingabe";
            this.Eingabe.Size = new System.Drawing.Size(95, 26);
            this.Eingabe.TabIndex = 3;
            // 
            // berechenen
            // 
            this.berechenen.Location = new System.Drawing.Point(31, 128);
            this.berechenen.Name = "berechenen";
            this.berechenen.Size = new System.Drawing.Size(263, 46);
            this.berechenen.TabIndex = 4;
            this.berechenen.Text = "Reisedauer berechnen";
            this.berechenen.UseVisualStyleBackColor = true;
            this.berechenen.Click += new System.EventHandler(this.berechenen_Click);
            // 
            // Dauer
            // 
            this.Dauer.AutoSize = true;
            this.Dauer.Location = new System.Drawing.Point(29, 244);
            this.Dauer.Name = "Dauer";
            this.Dauer.Size = new System.Drawing.Size(159, 20);
            this.Dauer.TabIndex = 5;
            this.Dauer.Text = "Ausgabe Reisedauer";
            // 
            // Ausgabe
            // 
            this.Ausgabe.Location = new System.Drawing.Point(194, 244);
            this.Ausgabe.Name = "Ausgabe";
            this.Ausgabe.ReadOnly = true;
            this.Ausgabe.Size = new System.Drawing.Size(126, 26);
            this.Ausgabe.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Days);
            this.groupBox1.Controls.Add(this.Hours);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.berechenen);
            this.groupBox1.Controls.Add(this.Eingabe);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 205);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reisedauer zum Mond berechnen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 315);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Ausgabe);
            this.Controls.Add(this.Dauer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Days;
        private System.Windows.Forms.RadioButton Hours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Eingabe;
        private System.Windows.Forms.Button berechenen;
        private System.Windows.Forms.Label Dauer;
        private System.Windows.Forms.TextBox Ausgabe;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

