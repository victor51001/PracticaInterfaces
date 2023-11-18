namespace Inicio_Y_Portal.Formularios.Usuarios
{
    partial class ListadoUsuarios
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
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.gpbxUsuarios = new System.Windows.Forms.GroupBox();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnImprimir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttnEliminar.Location = new System.Drawing.Point(355, 528);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(98, 32);
            this.bttnEliminar.TabIndex = 12;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gpbxUsuarios
            // 
            this.gpbxUsuarios.Location = new System.Drawing.Point(127, 132);
            this.gpbxUsuarios.Name = "gpbxUsuarios";
            this.gpbxUsuarios.Size = new System.Drawing.Size(561, 356);
            this.gpbxUsuarios.TabIndex = 11;
            this.gpbxUsuarios.TabStop = false;
            this.gpbxUsuarios.Text = "groupBox1";
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttnCancelar.Location = new System.Drawing.Point(484, 528);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(98, 32);
            this.bttnCancelar.TabIndex = 10;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnImprimir
            // 
            this.bttnImprimir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnImprimir.Location = new System.Drawing.Point(234, 528);
            this.bttnImprimir.Name = "bttnImprimir";
            this.bttnImprimir.Size = new System.Drawing.Size(98, 32);
            this.bttnImprimir.TabIndex = 8;
            this.bttnImprimir.Text = "Imprimir";
            this.bttnImprimir.UseVisualStyleBackColor = true;
            this.bttnImprimir.Click += new System.EventHandler(this.bttnImprimir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(193, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(431, 57);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "LISTADO PROYECTOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.gpbxUsuarios);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnImprimir);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ListadoUsuarios";
            this.Text = "Usuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.GroupBox gpbxUsuarios;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnImprimir;
        private System.Windows.Forms.Label lblTitulo;
    }
}