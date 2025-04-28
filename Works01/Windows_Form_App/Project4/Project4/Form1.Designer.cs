namespace Project4
{
    partial class Form1
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
            this.btnArti = new System.Windows.Forms.Button();
            this.btnEksi = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnEsittir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnArti
            // 
            this.btnArti.Location = new System.Drawing.Point(338, 168);
            this.btnArti.Name = "btnArti";
            this.btnArti.Size = new System.Drawing.Size(90, 37);
            this.btnArti.TabIndex = 0;
            this.btnArti.Text = "+";
            this.btnArti.UseVisualStyleBackColor = true;
            this.btnArti.Click += new System.EventHandler(this.btnArti_Click);
            // 
            // btnEksi
            // 
            this.btnEksi.Location = new System.Drawing.Point(462, 168);
            this.btnEksi.Name = "btnEksi";
            this.btnEksi.Size = new System.Drawing.Size(90, 37);
            this.btnEksi.TabIndex = 1;
            this.btnEksi.Text = "-";
            this.btnEksi.UseVisualStyleBackColor = true;
            this.btnEksi.Click += new System.EventHandler(this.btnEksi_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(462, 233);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(90, 37);
            this.btnBolme.TabIndex = 3;
            this.btnBolme.Text = "/";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(338, 233);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(90, 37);
            this.btnCarpma.TabIndex = 2;
            this.btnCarpma.Text = "*";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btnEsittir
            // 
            this.btnEsittir.Location = new System.Drawing.Point(574, 170);
            this.btnEsittir.Name = "btnEsittir";
            this.btnEsittir.Size = new System.Drawing.Size(57, 100);
            this.btnEsittir.TabIndex = 4;
            this.btnEsittir.Text = "=";
            this.btnEsittir.UseVisualStyleBackColor = true;
            this.btnEsittir.Click += new System.EventHandler(this.btnEsittir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(338, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 46);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 489);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEsittir);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnEksi);
            this.Controls.Add(this.btnArti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArti;
        private System.Windows.Forms.Button btnEksi;
        private System.Windows.Forms.Button btnBolme;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnEsittir;
        private System.Windows.Forms.TextBox textBox1;
    }
}

