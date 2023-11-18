namespace Inicio_Y_Portal.Formularios.Clientes
{
    partial class ListadoClientes
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
            this.gpbxClientes = new System.Windows.Forms.GroupBox();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnOrdenar = new System.Windows.Forms.Button();
            this.bttnImprimir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gpbxClientes
            // 
            this.gpbxClientes.Location = new System.Drawing.Point(100, 109);
            this.gpbxClientes.Name = "gpbxClientes";
            this.gpbxClientes.Size = new System.Drawing.Size(628, 356);
            this.gpbxClientes.TabIndex = 17;
            this.gpbxClientes.TabStop = false;
            this.gpbxClientes.Text = "groupBox1";
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttnCancelar.Location = new System.Drawing.Point(572, 501);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(98, 32);
            this.bttnCancelar.TabIndex = 16;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnOrdenar
            // 
            this.bttnOrdenar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnOrdenar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttnOrdenar.Location = new System.Drawing.Point(298, 501);
            this.bttnOrdenar.Name = "bttnOrdenar";
            this.bttnOrdenar.Size = new System.Drawing.Size(98, 32);
            this.bttnOrdenar.TabIndex = 15;
            this.bttnOrdenar.Text = "Ordenar";
            this.bttnOrdenar.UseVisualStyleBackColor = true;
            this.bttnOrdenar.Click += new System.EventHandler(this.bttnOrdenar_Click);
            // 
            // bttnImprimir
            // 
            this.bttnImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnImprimir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnImprimir.Location = new System.Drawing.Point(148, 501);
            this.bttnImprimir.Name = "bttnImprimir";
            this.bttnImprimir.Size = new System.Drawing.Size(98, 32);
            this.bttnImprimir.TabIndex = 14;
            this.bttnImprimir.Text = "Imprimir";
            this.bttnImprimir.UseVisualStyleBackColor = true;
            this.bttnImprimir.Click += new System.EventHandler(this.bttnImprimir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(166, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(431, 57);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "LISTADO CLIENTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(434, 501);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 32);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 591);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gpbxClientes);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnOrdenar);
            this.Controls.Add(this.bttnImprimir);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListadoClientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbxClientes;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnOrdenar;
        private System.Windows.Forms.Button bttnImprimir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEliminar;
    }
}