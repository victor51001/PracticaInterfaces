namespace Inicio_Y_Portal.Formularios.Clientes
{
    partial class NuevoCliente
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
            this.lblAlta = new System.Windows.Forms.Label();
            this.tbcntrlAlta = new System.Windows.Forms.TabControl();
            this.tbpgGenerales = new System.Windows.Forms.TabPage();
            this.bttnAceptar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.tbpgPrivados = new System.Windows.Forms.TabPage();
            this.tbpgSector = new System.Windows.Forms.TabPage();
            this.tbpgLogo = new System.Windows.Forms.TabPage();
            this.tbpgCitas = new System.Windows.Forms.TabPage();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtbxDireccion = new System.Windows.Forms.TextBox();
            this.tbcntrlAlta.SuspendLayout();
            this.tbpgGenerales.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlta.Location = new System.Drawing.Point(341, 72);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(245, 29);
            this.lblAlta.TabIndex = 0;
            this.lblAlta.Text = "ALTA DE CLIENTE";
            // 
            // tbcntrlAlta
            // 
            this.tbcntrlAlta.Controls.Add(this.tbpgGenerales);
            this.tbcntrlAlta.Controls.Add(this.tbpgPrivados);
            this.tbcntrlAlta.Controls.Add(this.tbpgSector);
            this.tbcntrlAlta.Controls.Add(this.tbpgLogo);
            this.tbcntrlAlta.Controls.Add(this.tbpgCitas);
            this.tbcntrlAlta.Location = new System.Drawing.Point(52, 136);
            this.tbcntrlAlta.Name = "tbcntrlAlta";
            this.tbcntrlAlta.SelectedIndex = 0;
            this.tbcntrlAlta.Size = new System.Drawing.Size(899, 428);
            this.tbcntrlAlta.TabIndex = 1;
            // 
            // tbpgGenerales
            // 
            this.tbpgGenerales.Controls.Add(this.txtbxDireccion);
            this.tbpgGenerales.Controls.Add(this.lblDireccion);
            this.tbpgGenerales.Controls.Add(this.textBox1);
            this.tbpgGenerales.Controls.Add(this.lblNombre);
            this.tbpgGenerales.Location = new System.Drawing.Point(4, 22);
            this.tbpgGenerales.Name = "tbpgGenerales";
            this.tbpgGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgGenerales.Size = new System.Drawing.Size(891, 402);
            this.tbpgGenerales.TabIndex = 1;
            this.tbpgGenerales.Text = "Datos Generales";
            this.tbpgGenerales.UseVisualStyleBackColor = true;
            // 
            // bttnAceptar
            // 
            this.bttnAceptar.Location = new System.Drawing.Point(134, 579);
            this.bttnAceptar.Name = "bttnAceptar";
            this.bttnAceptar.Size = new System.Drawing.Size(197, 37);
            this.bttnAceptar.TabIndex = 2;
            this.bttnAceptar.Text = "Aceptar";
            this.bttnAceptar.UseVisualStyleBackColor = true;
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Location = new System.Drawing.Point(695, 579);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(197, 37);
            this.bttnCancelar.TabIndex = 3;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbpgPrivados
            // 
            this.tbpgPrivados.Location = new System.Drawing.Point(4, 22);
            this.tbpgPrivados.Name = "tbpgPrivados";
            this.tbpgPrivados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgPrivados.Size = new System.Drawing.Size(891, 402);
            this.tbpgPrivados.TabIndex = 2;
            this.tbpgPrivados.Text = "Datos Privados";
            this.tbpgPrivados.UseVisualStyleBackColor = true;
            // 
            // tbpgSector
            // 
            this.tbpgSector.Location = new System.Drawing.Point(4, 22);
            this.tbpgSector.Name = "tbpgSector";
            this.tbpgSector.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgSector.Size = new System.Drawing.Size(891, 402);
            this.tbpgSector.TabIndex = 3;
            this.tbpgSector.Text = "Sector";
            this.tbpgSector.UseVisualStyleBackColor = true;
            // 
            // tbpgLogo
            // 
            this.tbpgLogo.Location = new System.Drawing.Point(4, 22);
            this.tbpgLogo.Name = "tbpgLogo";
            this.tbpgLogo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgLogo.Size = new System.Drawing.Size(891, 402);
            this.tbpgLogo.TabIndex = 4;
            this.tbpgLogo.Text = "Logo";
            this.tbpgLogo.UseVisualStyleBackColor = true;
            // 
            // tbpgCitas
            // 
            this.tbpgCitas.Location = new System.Drawing.Point(4, 22);
            this.tbpgCitas.Name = "tbpgCitas";
            this.tbpgCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgCitas.Size = new System.Drawing.Size(891, 402);
            this.tbpgCitas.TabIndex = 5;
            this.tbpgCitas.Text = "Citas";
            this.tbpgCitas.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(75, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(75, 163);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtbxDireccion
            // 
            this.txtbxDireccion.Location = new System.Drawing.Point(221, 160);
            this.txtbxDireccion.Multiline = true;
            this.txtbxDireccion.Name = "txtbxDireccion";
            this.txtbxDireccion.Size = new System.Drawing.Size(275, 45);
            this.txtbxDireccion.TabIndex = 3;
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1004, 641);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnAceptar);
            this.Controls.Add(this.tbcntrlAlta);
            this.Controls.Add(this.lblAlta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NuevoCliente";
            this.Text = "NuevoCliente";
            this.Load += new System.EventHandler(this.NuevoCliente_Load);
            this.tbcntrlAlta.ResumeLayout(false);
            this.tbpgGenerales.ResumeLayout(false);
            this.tbpgGenerales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlta;
        private System.Windows.Forms.TabControl tbcntrlAlta;
        private System.Windows.Forms.TabPage tbpgGenerales;
        private System.Windows.Forms.TabPage tbpgPrivados;
        private System.Windows.Forms.TabPage tbpgSector;
        private System.Windows.Forms.TabPage tbpgLogo;
        private System.Windows.Forms.TabPage tbpgCitas;
        private System.Windows.Forms.Button bttnAceptar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtbxDireccion;
    }
}