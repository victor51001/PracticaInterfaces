namespace Inicio_Y_Portal
{
    partial class NuevoProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoProyecto));
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPresupuestoInicial = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.txtbxDescripcion = new System.Windows.Forms.TextBox();
            this.bttnAceptar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.nudPresupuesto = new System.Windows.Forms.NumericUpDown();
            this.cmbxCliente = new System.Windows.Forms.ComboBox();
            this.nuevoProyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controladorProyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terminarAltaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevoProyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controladorProyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminarAltaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpFechaFin, "dtpFechaFin");
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Value = new System.DateTime(2023, 10, 11, 13, 38, 15, 0);
            // 
            // lblDatos
            // 
            resources.ApplyResources(this.lblDatos, "lblDatos");
            this.lblDatos.Name = "lblDatos";
            // 
            // lblDescripcion
            // 
            resources.ApplyResources(this.lblDescripcion, "lblDescripcion");
            this.lblDescripcion.Name = "lblDescripcion";
            // 
            // lblFecha
            // 
            resources.ApplyResources(this.lblFecha, "lblFecha");
            this.lblFecha.Name = "lblFecha";
            // 
            // lblPresupuestoInicial
            // 
            resources.ApplyResources(this.lblPresupuestoInicial, "lblPresupuestoInicial");
            this.lblPresupuestoInicial.Name = "lblPresupuestoInicial";
            // 
            // lblCodigoCliente
            // 
            resources.ApplyResources(this.lblCodigoCliente, "lblCodigoCliente");
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            // 
            // txtbxDescripcion
            // 
            resources.ApplyResources(this.txtbxDescripcion, "txtbxDescripcion");
            this.txtbxDescripcion.Name = "txtbxDescripcion";
            // 
            // bttnAceptar
            // 
            resources.ApplyResources(this.bttnAceptar, "bttnAceptar");
            this.bttnAceptar.Name = "bttnAceptar";
            this.bttnAceptar.UseVisualStyleBackColor = true;
            this.bttnAceptar.Click += new System.EventHandler(this.bttnAceptar_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.bttnCancelar, "bttnCancelar");
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // nudPresupuesto
            // 
            resources.ApplyResources(this.nudPresupuesto, "nudPresupuesto");
            this.nudPresupuesto.Name = "nudPresupuesto";
            // 
            // cmbxCliente
            // 
            this.cmbxCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.terminarAltaBindingSource, "AutoScroll", true));
            this.cmbxCliente.DataSource = this.controladorProyectoBindingSource;
            this.cmbxCliente.FormattingEnabled = true;
            resources.ApplyResources(this.cmbxCliente, "cmbxCliente");
            this.cmbxCliente.Name = "cmbxCliente";
            // 
            // nuevoProyectoBindingSource
            // 
            this.nuevoProyectoBindingSource.DataSource = typeof(Inicio_Y_Portal.NuevoProyecto);
            // 
            // controladorProyectoBindingSource
            // 
            this.controladorProyectoBindingSource.DataSource = typeof(Inicio_Y_Portal.Controladores.ControladorProyecto);
            // 
            // terminarAltaBindingSource
            // 
            this.terminarAltaBindingSource.DataSource = typeof(Inicio_Y_Portal.TerminarAlta);
            // 
            // NuevoProyecto
            // 
            this.AcceptButton = this.bttnAceptar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CancelButton = this.bttnCancelar;
            this.Controls.Add(this.cmbxCliente);
            this.Controls.Add(this.nudPresupuesto);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnAceptar);
            this.Controls.Add(this.txtbxDescripcion);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.lblPresupuestoInicial);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblDatos);
            this.Name = "NuevoProyecto";
            this.Load += new System.EventHandler(this.NuevoProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevoProyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controladorProyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminarAltaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPresupuestoInicial;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.TextBox txtbxDescripcion;
        private System.Windows.Forms.Button bttnAceptar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.NumericUpDown nudPresupuesto;
        private System.Windows.Forms.ComboBox cmbxCliente;
        private System.Windows.Forms.BindingSource nuevoProyectoBindingSource;
        private System.Windows.Forms.BindingSource controladorProyectoBindingSource;
        private System.Windows.Forms.BindingSource terminarAltaBindingSource;
    }
}