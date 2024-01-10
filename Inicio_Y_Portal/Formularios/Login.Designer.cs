namespace Inicio_Y_Portal
{
    partial class FrmRegistro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.txtbClave = new System.Windows.Forms.TextBox();
            this.bttAceptar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.lnklblCentro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(92, 108);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(92, 156);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(62, 19);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave: ";
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.Location = new System.Drawing.Point(224, 108);
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Size = new System.Drawing.Size(160, 20);
            this.txtbUsuario.TabIndex = 2;
            // 
            // txtbClave
            // 
            this.txtbClave.Location = new System.Drawing.Point(224, 155);
            this.txtbClave.Name = "txtbClave";
            this.txtbClave.PasswordChar = '*';
            this.txtbClave.Size = new System.Drawing.Size(160, 20);
            this.txtbClave.TabIndex = 3;
            // 
            // bttAceptar
            // 
            this.bttAceptar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAceptar.Location = new System.Drawing.Point(121, 230);
            this.bttAceptar.Name = "bttAceptar";
            this.bttAceptar.Size = new System.Drawing.Size(75, 28);
            this.bttAceptar.TabIndex = 4;
            this.bttAceptar.Text = "Aceptar";
            this.bttAceptar.UseVisualStyleBackColor = true;
            this.bttAceptar.Click += new System.EventHandler(this.bttAceptar_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancelar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancelar.Location = new System.Drawing.Point(264, 230);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(75, 28);
            this.bttnCancelar.TabIndex = 5;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // lnklblCentro
            // 
            this.lnklblCentro.AutoSize = true;
            this.lnklblCentro.Location = new System.Drawing.Point(44, 324);
            this.lnklblCentro.Name = "lnklblCentro";
            this.lnklblCentro.Size = new System.Drawing.Size(55, 13);
            this.lnklblCentro.TabIndex = 6;
            this.lnklblCentro.TabStop = true;
            this.lnklblCentro.Text = "AcercaDe";
            this.lnklblCentro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblCentro_LinkClicked);
            // 
            // FrmRegistro
            // 
            this.AcceptButton = this.bttAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.bttnCancelar;
            this.ClientSize = new System.Drawing.Size(456, 398);
            this.Controls.Add(this.lnklblCentro);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttAceptar);
            this.Controls.Add(this.txtbClave);
            this.Controls.Add(this.txtbUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Name = "FrmRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtbUsuario;
        private System.Windows.Forms.TextBox txtbClave;
        private System.Windows.Forms.Button bttAceptar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.LinkLabel lnklblCentro;
    }
}

