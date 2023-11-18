namespace Inicio_Y_Portal
{
    partial class NuevoEmpleado
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
            this.components = new System.ComponentModel.Container();
            this.lblDatos = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtbxApellido2 = new System.Windows.Forms.TextBox();
            this.txtbxApellido1 = new System.Windows.Forms.TextBox();
            this.txtbxDni = new System.Windows.Forms.TextBox();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtbxCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtbxComentarios = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblSegSoc = new System.Windows.Forms.Label();
            this.nudTelefono = new System.Windows.Forms.NumericUpDown();
            this.nudNumSegSoc = new System.Windows.Forms.NumericUpDown();
            this.lblComentarios2 = new System.Windows.Forms.Label();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnAceptar = new System.Windows.Forms.Button();
            this.cbxPuestos = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumSegSoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDatos.Location = new System.Drawing.Point(77, 58);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(388, 22);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "Introduce los datos del nuevo empleado:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(592, 156);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(150, 20);
            this.dtpFechaNac.TabIndex = 20;
            this.dtpFechaNac.Value = new System.DateTime(2023, 10, 11, 13, 38, 15, 0);
            // 
            // txtbxApellido2
            // 
            this.txtbxApellido2.Location = new System.Drawing.Point(213, 236);
            this.txtbxApellido2.Name = "txtbxApellido2";
            this.txtbxApellido2.Size = new System.Drawing.Size(150, 20);
            this.txtbxApellido2.TabIndex = 19;
            // 
            // txtbxApellido1
            // 
            this.txtbxApellido1.Location = new System.Drawing.Point(213, 197);
            this.txtbxApellido1.Name = "txtbxApellido1";
            this.txtbxApellido1.Size = new System.Drawing.Size(150, 20);
            this.txtbxApellido1.TabIndex = 18;
            // 
            // txtbxDni
            // 
            this.txtbxDni.Location = new System.Drawing.Point(213, 119);
            this.txtbxDni.Name = "txtbxDni";
            this.txtbxDni.Size = new System.Drawing.Size(150, 20);
            this.txtbxDni.TabIndex = 17;
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblApellido2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblApellido2.Location = new System.Drawing.Point(43, 239);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(129, 17);
            this.lblApellido2.TabIndex = 16;
            this.lblApellido2.Text = "Segundo apellido*:";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblApellido1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblApellido1.Location = new System.Drawing.Point(43, 200);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(115, 17);
            this.lblApellido1.TabIndex = 15;
            this.lblApellido1.Text = "Primer apellido*:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(43, 159);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 17);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre*:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblDni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDni.Location = new System.Drawing.Point(43, 122);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(42, 17);
            this.lblDni.TabIndex = 13;
            this.lblDni.Text = "DNI*:";
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Location = new System.Drawing.Point(213, 156);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(150, 20);
            this.txtbxNombre.TabIndex = 21;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblPuesto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPuesto.Location = new System.Drawing.Point(43, 278);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(64, 17);
            this.lblPuesto.TabIndex = 22;
            this.lblPuesto.Text = "Puesto*:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTelefono.Location = new System.Drawing.Point(43, 325);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(66, 17);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtbxCorreo
            // 
            this.txtbxCorreo.Location = new System.Drawing.Point(592, 116);
            this.txtbxCorreo.Name = "txtbxCorreo";
            this.txtbxCorreo.Size = new System.Drawing.Size(150, 20);
            this.txtbxCorreo.TabIndex = 27;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblCorreo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCorreo.Location = new System.Drawing.Point(422, 119);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(57, 17);
            this.lblCorreo.TabIndex = 26;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblFechaNac.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFechaNac.Location = new System.Drawing.Point(422, 159);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(154, 17);
            this.lblFechaNac.TabIndex = 28;
            this.lblFechaNac.Text = "Fecha de nacimiento*:";
            // 
            // txtbxComentarios
            // 
            this.txtbxComentarios.Location = new System.Drawing.Point(539, 236);
            this.txtbxComentarios.Multiline = true;
            this.txtbxComentarios.Name = "txtbxComentarios";
            this.txtbxComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxComentarios.Size = new System.Drawing.Size(293, 154);
            this.txtbxComentarios.TabIndex = 32;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblComentarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblComentarios.Location = new System.Drawing.Point(422, 239);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(96, 17);
            this.lblComentarios.TabIndex = 31;
            this.lblComentarios.Text = "Comentarios:";
            // 
            // lblSegSoc
            // 
            this.lblSegSoc.AutoSize = true;
            this.lblSegSoc.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblSegSoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSegSoc.Location = new System.Drawing.Point(422, 201);
            this.lblSegSoc.Name = "lblSegSoc";
            this.lblSegSoc.Size = new System.Drawing.Size(147, 17);
            this.lblSegSoc.TabIndex = 29;
            this.lblSegSoc.Text = "Nº Seguridad Social*:";
            // 
            // nudTelefono
            // 
            this.nudTelefono.Location = new System.Drawing.Point(213, 324);
            this.nudTelefono.Name = "nudTelefono";
            this.nudTelefono.Size = new System.Drawing.Size(150, 20);
            this.nudTelefono.TabIndex = 33;
            this.nudTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.numeros_Validating);
            // 
            // nudNumSegSoc
            // 
            this.nudNumSegSoc.Location = new System.Drawing.Point(592, 202);
            this.nudNumSegSoc.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudNumSegSoc.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudNumSegSoc.Name = "nudNumSegSoc";
            this.nudNumSegSoc.Size = new System.Drawing.Size(150, 20);
            this.nudNumSegSoc.TabIndex = 34;
            this.nudNumSegSoc.Value = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudNumSegSoc.Validating += new System.ComponentModel.CancelEventHandler(this.numeros_Validating);
            // 
            // lblComentarios2
            // 
            this.lblComentarios2.AutoSize = true;
            this.lblComentarios2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblComentarios2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblComentarios2.Location = new System.Drawing.Point(422, 273);
            this.lblComentarios2.Name = "lblComentarios2";
            this.lblComentarios2.Size = new System.Drawing.Size(114, 51);
            this.lblComentarios2.TabIndex = 35;
            this.lblComentarios2.Text = "Debes ingresar \r\nun minimo de \r\n1000 caracteres";
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnCancelar.Location = new System.Drawing.Point(506, 451);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(102, 30);
            this.bttnCancelar.TabIndex = 37;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnAceptar
            // 
            this.bttnAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnAceptar.Location = new System.Drawing.Point(270, 451);
            this.bttnAceptar.Name = "bttnAceptar";
            this.bttnAceptar.Size = new System.Drawing.Size(102, 30);
            this.bttnAceptar.TabIndex = 36;
            this.bttnAceptar.Text = "Aceptar";
            this.bttnAceptar.UseVisualStyleBackColor = true;
            this.bttnAceptar.Click += new System.EventHandler(this.bttnAceptar_Click);
            // 
            // cbxPuestos
            // 
            this.cbxPuestos.FormattingEnabled = true;
            this.cbxPuestos.Location = new System.Drawing.Point(213, 278);
            this.cbxPuestos.Name = "cbxPuestos";
            this.cbxPuestos.Size = new System.Drawing.Size(150, 21);
            this.cbxPuestos.TabIndex = 38;
            // 
            // empleadoBindingSource2
            // 
            this.empleadoBindingSource2.DataSource = typeof(Inicio_Y_Portal.Empleado);
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(Inicio_Y_Portal.Empleado);
            // 
            // empleadoBindingSource1
            // 
            this.empleadoBindingSource1.DataSource = typeof(Inicio_Y_Portal.Empleado);
            // 
            // NuevoEmpleado
            // 
            this.AcceptButton = this.bttnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CancelButton = this.bttnCancelar;
            this.ClientSize = new System.Drawing.Size(870, 508);
            this.Controls.Add(this.cbxPuestos);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnAceptar);
            this.Controls.Add(this.lblComentarios2);
            this.Controls.Add(this.nudNumSegSoc);
            this.Controls.Add(this.nudTelefono);
            this.Controls.Add(this.txtbxComentarios);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.lblSegSoc);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.txtbxCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.txtbxNombre);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtbxApellido2);
            this.Controls.Add(this.txtbxApellido1);
            this.Controls.Add(this.txtbxDni);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblDatos);
            this.Name = "NuevoEmpleado";
            this.Text = "Alta Empleado";
            this.Load += new System.EventHandler(this.NuevoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumSegSoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtbxApellido2;
        private System.Windows.Forms.TextBox txtbxApellido1;
        private System.Windows.Forms.TextBox txtbxDni;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtbxNombre;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtbxCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtbxComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblSegSoc;
        private System.Windows.Forms.NumericUpDown nudTelefono;
        private System.Windows.Forms.NumericUpDown nudNumSegSoc;
        private System.Windows.Forms.Label lblComentarios2;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnAceptar;
        private System.Windows.Forms.ComboBox cbxPuestos;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.BindingSource empleadoBindingSource2;
        private System.Windows.Forms.BindingSource empleadoBindingSource1;
    }
}