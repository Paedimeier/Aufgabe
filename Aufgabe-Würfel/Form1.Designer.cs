namespace Aufgabe_Würfel
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
            this.Würfel = new System.Windows.Forms.Button();
            this.Last = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Würfel
            // 
            this.Würfel.Location = new System.Drawing.Point(47, 42);
            this.Würfel.Name = "Würfel";
            this.Würfel.Size = new System.Drawing.Size(250, 126);
            this.Würfel.TabIndex = 0;
            this.Würfel.Text = "Würfeln";
            this.Würfel.UseVisualStyleBackColor = true;
            this.Würfel.Click += new System.EventHandler(this.Würfel_Click);
            // 
            // Last
            // 
            this.Last.AutoSize = true;
            this.Last.Location = new System.Drawing.Point(43, 237);
            this.Last.Name = "Last";
            this.Last.Size = new System.Drawing.Size(101, 20);
            this.Last.TabIndex = 1;
            this.Last.Text = "Letzter Wurf:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(152, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(141, 26);
            this.textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Last);
            this.Controls.Add(this.Würfel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Würfel;
        private System.Windows.Forms.Label Last;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

