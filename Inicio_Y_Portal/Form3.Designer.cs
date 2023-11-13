namespace Inicio_Y_Portal
{
    partial class Form3
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
            this.txtbNumeros = new System.Windows.Forms.TextBox();
            this.bttnComprobar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbNumeros
            // 
            this.txtbNumeros.Location = new System.Drawing.Point(351, 135);
            this.txtbNumeros.Name = "txtbNumeros";
            this.txtbNumeros.Size = new System.Drawing.Size(49, 20);
            this.txtbNumeros.TabIndex = 0;
            // 
            // bttnComprobar
            // 
            this.bttnComprobar.BackColor = System.Drawing.SystemColors.Control;
            this.bttnComprobar.Location = new System.Drawing.Point(133, 207);
            this.bttnComprobar.Name = "bttnComprobar";
            this.bttnComprobar.Size = new System.Drawing.Size(106, 33);
            this.bttnComprobar.TabIndex = 1;
            this.bttnComprobar.Text = "Comprobar";
            this.bttnComprobar.UseVisualStyleBackColor = false;
            this.bttnComprobar.Click += new System.EventHandler(this.bttnComprobar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(260, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ordenador";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(388, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Comprobar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(512, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Comprobar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttnComprobar);
            this.Controls.Add(this.txtbNumeros);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNumeros;
        private System.Windows.Forms.Button bttnComprobar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}