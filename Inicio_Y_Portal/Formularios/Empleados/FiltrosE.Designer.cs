namespace Inicio_Y_Portal
{
    partial class FiltrosE
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
            this.lblFP = new System.Windows.Forms.Label();
            this.lblFFN = new System.Windows.Forms.Label();
            this.chklstbxPuestos = new System.Windows.Forms.CheckedListBox();
            this.dtpFechaNacim = new System.Windows.Forms.DateTimePicker();
            this.rbtnMayor = new System.Windows.Forms.RadioButton();
            this.rbtnMenor = new System.Windows.Forms.RadioButton();
            this.rbtnIgual = new System.Windows.Forms.RadioButton();
            this.gpbComparar = new System.Windows.Forms.GroupBox();
            this.bttnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbComparar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFP
            // 
            this.lblFP.AutoSize = true;
            this.lblFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFP.Location = new System.Drawing.Point(31, 59);
            this.lblFP.Name = "lblFP";
            this.lblFP.Size = new System.Drawing.Size(133, 20);
            this.lblFP.TabIndex = 0;
            this.lblFP.Text = "Filtrar por puesto:";
            // 
            // lblFFN
            // 
            this.lblFFN.AutoSize = true;
            this.lblFFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFFN.Location = new System.Drawing.Point(31, 250);
            this.lblFFN.Name = "lblFFN";
            this.lblFFN.Size = new System.Drawing.Size(227, 20);
            this.lblFFN.TabIndex = 1;
            this.lblFFN.Text = "Filtrar por fecha de nacimiento:";
            // 
            // chklstbxPuestos
            // 
            this.chklstbxPuestos.FormattingEnabled = true;
            this.chklstbxPuestos.Items.AddRange(new object[] {
            "Jefe",
            "Analista",
            "Asistente",
            "Diseñador",
            "Desarrollador"});
            this.chklstbxPuestos.Location = new System.Drawing.Point(35, 105);
            this.chklstbxPuestos.Name = "chklstbxPuestos";
            this.chklstbxPuestos.Size = new System.Drawing.Size(174, 79);
            this.chklstbxPuestos.TabIndex = 7;
            this.chklstbxPuestos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklstbxPuestos_ItemCheck);
            // 
            // dtpFechaNacim
            // 
            this.dtpFechaNacim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacim.Location = new System.Drawing.Point(262, 334);
            this.dtpFechaNacim.Name = "dtpFechaNacim";
            this.dtpFechaNacim.Size = new System.Drawing.Size(89, 20);
            this.dtpFechaNacim.TabIndex = 9;
            // 
            // rbtnMayor
            // 
            this.rbtnMayor.AutoSize = true;
            this.rbtnMayor.Location = new System.Drawing.Point(6, 19);
            this.rbtnMayor.Name = "rbtnMayor";
            this.rbtnMayor.Size = new System.Drawing.Size(63, 17);
            this.rbtnMayor.TabIndex = 10;
            this.rbtnMayor.TabStop = true;
            this.rbtnMayor.Text = "Mayor a";
            this.rbtnMayor.UseVisualStyleBackColor = true;
            // 
            // rbtnMenor
            // 
            this.rbtnMenor.AutoSize = true;
            this.rbtnMenor.Location = new System.Drawing.Point(6, 52);
            this.rbtnMenor.Name = "rbtnMenor";
            this.rbtnMenor.Size = new System.Drawing.Size(64, 17);
            this.rbtnMenor.TabIndex = 11;
            this.rbtnMenor.TabStop = true;
            this.rbtnMenor.Text = "Menor a";
            this.rbtnMenor.UseVisualStyleBackColor = true;
            // 
            // rbtnIgual
            // 
            this.rbtnIgual.AutoSize = true;
            this.rbtnIgual.Location = new System.Drawing.Point(6, 86);
            this.rbtnIgual.Name = "rbtnIgual";
            this.rbtnIgual.Size = new System.Drawing.Size(57, 17);
            this.rbtnIgual.TabIndex = 12;
            this.rbtnIgual.TabStop = true;
            this.rbtnIgual.Text = "Igual a";
            this.rbtnIgual.UseVisualStyleBackColor = true;
            // 
            // gpbComparar
            // 
            this.gpbComparar.Controls.Add(this.rbtnMayor);
            this.gpbComparar.Controls.Add(this.rbtnIgual);
            this.gpbComparar.Controls.Add(this.rbtnMenor);
            this.gpbComparar.Location = new System.Drawing.Point(35, 286);
            this.gpbComparar.Name = "gpbComparar";
            this.gpbComparar.Size = new System.Drawing.Size(200, 112);
            this.gpbComparar.TabIndex = 13;
            this.gpbComparar.TabStop = false;
            // 
            // bttnAceptar
            // 
            this.bttnAceptar.Location = new System.Drawing.Point(60, 437);
            this.bttnAceptar.Name = "bttnAceptar";
            this.bttnAceptar.Size = new System.Drawing.Size(75, 23);
            this.bttnAceptar.TabIndex = 14;
            this.bttnAceptar.Text = "Aceptar";
            this.bttnAceptar.UseVisualStyleBackColor = true;
            this.bttnAceptar.Click += new System.EventHandler(this.bttnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(226, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FiltrosE
            // 
            this.AcceptButton = this.bttnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(403, 499);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.bttnAceptar);
            this.Controls.Add(this.gpbComparar);
            this.Controls.Add(this.dtpFechaNacim);
            this.Controls.Add(this.chklstbxPuestos);
            this.Controls.Add(this.lblFFN);
            this.Controls.Add(this.lblFP);
            this.Name = "FiltrosE";
            this.Text = "Filtros de Empleados";
            this.gpbComparar.ResumeLayout(false);
            this.gpbComparar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFP;
        private System.Windows.Forms.Label lblFFN;
        private System.Windows.Forms.CheckedListBox chklstbxPuestos;
        private System.Windows.Forms.DateTimePicker dtpFechaNacim;
        private System.Windows.Forms.RadioButton rbtnMayor;
        private System.Windows.Forms.RadioButton rbtnMenor;
        private System.Windows.Forms.RadioButton rbtnIgual;
        private System.Windows.Forms.GroupBox gpbComparar;
        private System.Windows.Forms.Button bttnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}