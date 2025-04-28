namespace Calculator
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
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.btnArti = new System.Windows.Forms.Button();
            this.btnCıkar = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(392, 98);
            this.txtSayi2.Multiline = true;
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(172, 53);
            this.txtSayi2.TabIndex = 0;
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(182, 98);
            this.txtSayi1.Multiline = true;
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(172, 53);
            this.txtSayi1.TabIndex = 0;
            this.txtSayi1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnArti
            // 
            this.btnArti.Location = new System.Drawing.Point(182, 192);
            this.btnArti.Name = "btnArti";
            this.btnArti.Size = new System.Drawing.Size(172, 50);
            this.btnArti.TabIndex = 1;
            this.btnArti.Text = "+";
            this.btnArti.UseVisualStyleBackColor = true;
            this.btnArti.Click += new System.EventHandler(this.btnArti_Click);
            // 
            // btnCıkar
            // 
            this.btnCıkar.Location = new System.Drawing.Point(392, 192);
            this.btnCıkar.Name = "btnCıkar";
            this.btnCıkar.Size = new System.Drawing.Size(172, 50);
            this.btnCıkar.TabIndex = 1;
            this.btnCıkar.Text = "-";
            this.btnCıkar.UseVisualStyleBackColor = true;
            this.btnCıkar.Click += new System.EventHandler(this.btnCıkar_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(182, 258);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(172, 50);
            this.btnCarp.TabIndex = 1;
            this.btnCarp.Text = "*";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(392, 258);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(172, 50);
            this.btnBolme.TabIndex = 1;
            this.btnBolme.Text = "/";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnCıkar);
            this.Controls.Add(this.btnArti);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.txtSayi2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Button btnArti;
        private System.Windows.Forms.Button btnCıkar;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBolme;
    }
}

