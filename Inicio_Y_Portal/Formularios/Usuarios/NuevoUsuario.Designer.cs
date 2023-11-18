namespace Inicio_Y_Portal.Formularios.Usuarios
{
    partial class NuevoUsuario
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
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnAceptar = new System.Windows.Forms.Button();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.txtbxClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnCancelar.Location = new System.Drawing.Point(418, 295);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(102, 30);
            this.bttnCancelar.TabIndex = 23;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnAceptar
            // 
            this.bttnAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnAceptar.Location = new System.Drawing.Point(122, 295);
            this.bttnAceptar.Name = "bttnAceptar";
            this.bttnAceptar.Size = new System.Drawing.Size(102, 30);
            this.bttnAceptar.TabIndex = 22;
            this.bttnAceptar.Text = "Aceptar";
            this.bttnAceptar.UseVisualStyleBackColor = true;
            this.bttnAceptar.Click += new System.EventHandler(this.bttnAceptar_Click);
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Location = new System.Drawing.Point(351, 130);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(150, 20);
            this.txtbxNombre.TabIndex = 21;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblClave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblClave.Location = new System.Drawing.Point(119, 216);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(116, 17);
            this.lblClave.TabIndex = 20;
            this.lblClave.Text = "Clave Numerica:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(119, 135);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(138, 17);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre de Usuario:";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDatos.Location = new System.Drawing.Point(110, 37);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(369, 22);
            this.lblDatos.TabIndex = 16;
            this.lblDatos.Text = "Introduce los datos del nuevo Usuario:";
            // 
            // txtbxClave
            // 
            this.txtbxClave.Location = new System.Drawing.Point(351, 213);
            this.txtbxClave.Name = "txtbxClave";
            this.txtbxClave.PasswordChar = '*';
            this.txtbxClave.Size = new System.Drawing.Size(150, 20);
            this.txtbxClave.TabIndex = 24;
            this.txtbxClave.UseSystemPasswordChar = true;
            this.txtbxClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxClave_KeyPress);
            // 
            // NuevoUsuario
            // 
            this.AcceptButton = this.bttnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.bttnCancelar;
            this.ClientSize = new System.Drawing.Size(622, 350);
            this.Controls.Add(this.txtbxClave);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnAceptar);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDatos);
            this.Name = "NuevoUsuario";
            this.Text = "Nuevo Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnAceptar;
        private System.Windows.Forms.TextBox txtbxNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TextBox txtbxClave;
    }
}