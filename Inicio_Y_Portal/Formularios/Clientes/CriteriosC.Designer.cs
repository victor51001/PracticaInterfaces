namespace Inicio_Y_Portal.Formularios.Clientes
{
    partial class CriteriosC
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
            this.chklstbxClientes = new System.Windows.Forms.CheckedListBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancelar.Location = new System.Drawing.Point(260, 181);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(95, 32);
            this.bttnCancelar.TabIndex = 7;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnAceptar
            // 
            this.bttnAceptar.Location = new System.Drawing.Point(76, 181);
            this.bttnAceptar.Name = "bttnAceptar";
            this.bttnAceptar.Size = new System.Drawing.Size(95, 32);
            this.bttnAceptar.TabIndex = 6;
            this.bttnAceptar.Text = "Aceptar";
            this.bttnAceptar.UseVisualStyleBackColor = true;
            this.bttnAceptar.Click += new System.EventHandler(this.bttnAceptar_Click);
            // 
            // chklstbxClientes
            // 
            this.chklstbxClientes.BackColor = System.Drawing.SystemColors.Info;
            this.chklstbxClientes.FormattingEnabled = true;
            this.chklstbxClientes.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Direccion",
            "Telefono",
            "Correo"});
            this.chklstbxClientes.Location = new System.Drawing.Point(56, 61);
            this.chklstbxClientes.Name = "chklstbxClientes";
            this.chklstbxClientes.Size = new System.Drawing.Size(170, 79);
            this.chklstbxClientes.TabIndex = 5;
            this.chklstbxClientes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstbxClientes_ItemCheck);
            this.chklstbxClientes.SelectedIndexChanged += new System.EventHandler(this.chklstbxClientes_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(52, 36);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(303, 22);
            this.lblCriterio.TabIndex = 4;
            this.lblCriterio.Text = "Selecciona el criterio para ordenar:";
            // 
            // CriteriosC
            // 
            this.AcceptButton = this.bttnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.bttnCancelar;
            this.ClientSize = new System.Drawing.Size(420, 238);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnAceptar);
            this.Controls.Add(this.chklstbxClientes);
            this.Controls.Add(this.lblCriterio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CriteriosC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criterios";
            this.Load += new System.EventHandler(this.CriteriosC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnAceptar;
        private System.Windows.Forms.CheckedListBox chklstbxClientes;
        private System.Windows.Forms.Label lblCriterio;
    }
}