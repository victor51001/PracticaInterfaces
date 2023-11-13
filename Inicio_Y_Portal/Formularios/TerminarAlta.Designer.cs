namespace Inicio_Y_Portal
{
    partial class TerminarAlta
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.bttnSi = new System.Windows.Forms.Button();
            this.bttnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(99, 63);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(288, 22);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "Quieres continuar dando de alta?";
            // 
            // bttnSi
            // 
            this.bttnSi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSi.Location = new System.Drawing.Point(155, 144);
            this.bttnSi.Name = "bttnSi";
            this.bttnSi.Size = new System.Drawing.Size(75, 23);
            this.bttnSi.TabIndex = 1;
            this.bttnSi.Text = "Si";
            this.bttnSi.UseVisualStyleBackColor = true;
            this.bttnSi.Click += new System.EventHandler(this.bttnSi_Click);
            // 
            // bttnNo
            // 
            this.bttnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNo.Location = new System.Drawing.Point(291, 144);
            this.bttnNo.Name = "bttnNo";
            this.bttnNo.Size = new System.Drawing.Size(75, 23);
            this.bttnNo.TabIndex = 2;
            this.bttnNo.Text = "No";
            this.bttnNo.UseVisualStyleBackColor = true;
            this.bttnNo.Click += new System.EventHandler(this.bttnNo_Click);
            // 
            // TerminarAlta
            // 
            this.AcceptButton = this.bttnSi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.CancelButton = this.bttnNo;
            this.ClientSize = new System.Drawing.Size(530, 222);
            this.Controls.Add(this.bttnNo);
            this.Controls.Add(this.bttnSi);
            this.Controls.Add(this.lblPregunta);
            this.Name = "TerminarAlta";
            this.Text = "Terminar Alta de Proyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button bttnSi;
        private System.Windows.Forms.Button bttnNo;
    }
}