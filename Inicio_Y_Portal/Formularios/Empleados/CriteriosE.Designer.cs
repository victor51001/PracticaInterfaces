namespace Inicio_Y_Portal
{
    partial class CriteriosE
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
            this.lblCriterio = new System.Windows.Forms.Label();
            this.chklstbxCriterios = new System.Windows.Forms.CheckedListBox();
            this.bttnAceptar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(28, 46);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(303, 22);
            this.lblCriterio.TabIndex = 0;
            this.lblCriterio.Text = "Selecciona el criterio para ordenar:";
            // 
            // chklstbxCriterios
            // 
            this.chklstbxCriterios.BackColor = System.Drawing.SystemColors.Info;
            this.chklstbxCriterios.FormattingEnabled = true;
            this.chklstbxCriterios.Items.AddRange(new object[] {
            "Codigo",
            "DNI",
            "Nombre",
            "Apellido1",
            "Apellido2",
            "Puesto",
            "Telefono",
            "Correo",
            "Fecha de nacimiento",
            "Numero de la Seguridad Social",
            "Comentarios"});
            this.chklstbxCriterios.Location = new System.Drawing.Point(32, 71);
            this.chklstbxCriterios.Name = "chklstbxCriterios";
            this.chklstbxCriterios.Size = new System.Drawing.Size(170, 169);
            this.chklstbxCriterios.TabIndex = 1;
            this.chklstbxCriterios.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstbxCriterios_ItemCheck);
            this.chklstbxCriterios.SelectedIndexChanged += new System.EventHandler(this.chklstbxCriterios_SelectedIndexChanged);
            // 
            // bttnAceptar
            // 
            this.bttnAceptar.Enabled = false;
            this.bttnAceptar.Location = new System.Drawing.Point(52, 268);
            this.bttnAceptar.Name = "bttnAceptar";
            this.bttnAceptar.Size = new System.Drawing.Size(95, 32);
            this.bttnAceptar.TabIndex = 2;
            this.bttnAceptar.Text = "Aceptar";
            this.bttnAceptar.UseVisualStyleBackColor = true;
            this.bttnAceptar.Click += new System.EventHandler(this.bttnAceptar_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancelar.Location = new System.Drawing.Point(236, 268);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(95, 32);
            this.bttnCancelar.TabIndex = 3;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // CriteriosE
            // 
            this.AcceptButton = this.bttnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.bttnCancelar;
            this.ClientSize = new System.Drawing.Size(420, 331);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnAceptar);
            this.Controls.Add(this.chklstbxCriterios);
            this.Controls.Add(this.lblCriterio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CriteriosE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criterios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.CheckedListBox chklstbxCriterios;
        private System.Windows.Forms.Button bttnAceptar;
        private System.Windows.Forms.Button bttnCancelar;
    }
}