namespace Inicio_Y_Portal
{
    partial class ListadoEmpleados
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
            this.bttnFiltrar = new System.Windows.Forms.Button();
            this.gpbxEmpleados = new System.Windows.Forms.GroupBox();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnOrdenar = new System.Windows.Forms.Button();
            this.bttnImprimir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnFiltrar
            // 
            this.bttnFiltrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttnFiltrar.Location = new System.Drawing.Point(449, 521);
            this.bttnFiltrar.Name = "bttnFiltrar";
            this.bttnFiltrar.Size = new System.Drawing.Size(98, 32);
            this.bttnFiltrar.TabIndex = 12;
            this.bttnFiltrar.Text = "Filtrar";
            this.bttnFiltrar.UseVisualStyleBackColor = true;
            this.bttnFiltrar.Click += new System.EventHandler(this.bttnFiltrar_Click);
            // 
            // gpbxEmpleados
            // 
            this.gpbxEmpleados.Location = new System.Drawing.Point(110, 121);
            this.gpbxEmpleados.Name = "gpbxEmpleados";
            this.gpbxEmpleados.Size = new System.Drawing.Size(628, 356);
            this.gpbxEmpleados.TabIndex = 11;
            this.gpbxEmpleados.TabStop = false;
            this.gpbxEmpleados.Text = "groupBox1";
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttnCancelar.Location = new System.Drawing.Point(578, 521);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(98, 32);
            this.bttnCancelar.TabIndex = 10;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnOrdenar
            // 
            this.bttnOrdenar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttnOrdenar.Location = new System.Drawing.Point(305, 521);
            this.bttnOrdenar.Name = "bttnOrdenar";
            this.bttnOrdenar.Size = new System.Drawing.Size(98, 32);
            this.bttnOrdenar.TabIndex = 9;
            this.bttnOrdenar.Text = "Ordenar";
            this.bttnOrdenar.UseVisualStyleBackColor = true;
            this.bttnOrdenar.Click += new System.EventHandler(this.bttnOrdenar_Click);
            // 
            // bttnImprimir
            // 
            this.bttnImprimir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnImprimir.Location = new System.Drawing.Point(179, 521);
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
            this.lblTitulo.Location = new System.Drawing.Point(176, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(431, 57);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "LISTADO EMPLEADOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListadoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 698);
            this.Controls.Add(this.bttnFiltrar);
            this.Controls.Add(this.gpbxEmpleados);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnOrdenar);
            this.Controls.Add(this.bttnImprimir);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ListadoEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.ListadoEmpleados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnFiltrar;
        private System.Windows.Forms.GroupBox gpbxEmpleados;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnOrdenar;
        private System.Windows.Forms.Button bttnImprimir;
        private System.Windows.Forms.Label lblTitulo;
    }
}