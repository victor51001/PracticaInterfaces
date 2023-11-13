namespace Inicio_Y_Portal
{
    partial class ListadoProyectos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.bttnImprimir = new System.Windows.Forms.Button();
            this.bttnOrdenar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.gpbxProyectos = new System.Windows.Forms.GroupBox();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(252, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(431, 57);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "LISTADO PROYECTOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // bttnImprimir
            // 
            this.bttnImprimir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnImprimir.Location = new System.Drawing.Point(225, 524);
            this.bttnImprimir.Name = "bttnImprimir";
            this.bttnImprimir.Size = new System.Drawing.Size(98, 32);
            this.bttnImprimir.TabIndex = 2;
            this.bttnImprimir.Text = "Imprimir";
            this.bttnImprimir.UseVisualStyleBackColor = true;
            this.bttnImprimir.Click += new System.EventHandler(this.bttnImprimir_Click);
            // 
            // bttnOrdenar
            // 
            this.bttnOrdenar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttnOrdenar.Location = new System.Drawing.Point(351, 524);
            this.bttnOrdenar.Name = "bttnOrdenar";
            this.bttnOrdenar.Size = new System.Drawing.Size(98, 32);
            this.bttnOrdenar.TabIndex = 3;
            this.bttnOrdenar.Text = "Ordenar";
            this.bttnOrdenar.UseVisualStyleBackColor = true;
            this.bttnOrdenar.Click += new System.EventHandler(this.bttnOrdenar_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttnCancelar.Location = new System.Drawing.Point(624, 524);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(98, 32);
            this.bttnCancelar.TabIndex = 4;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // gpbxProyectos
            // 
            this.gpbxProyectos.Location = new System.Drawing.Point(186, 128);
            this.gpbxProyectos.Name = "gpbxProyectos";
            this.gpbxProyectos.Size = new System.Drawing.Size(561, 356);
            this.gpbxProyectos.TabIndex = 5;
            this.gpbxProyectos.TabStop = false;
            this.gpbxProyectos.Text = "groupBox1";
            this.gpbxProyectos.Enter += new System.EventHandler(this.gpbxProyectos_Enter);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.bttnEliminar.Location = new System.Drawing.Point(495, 524);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(98, 32);
            this.bttnEliminar.TabIndex = 6;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // ListadoProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 698);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.gpbxProyectos);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnOrdenar);
            this.Controls.Add(this.bttnImprimir);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ListadoProyectos";
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.FrmProyectos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button bttnImprimir;
        private System.Windows.Forms.Button bttnOrdenar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.GroupBox gpbxProyectos;
        private System.Windows.Forms.Button bttnEliminar;
    }
}