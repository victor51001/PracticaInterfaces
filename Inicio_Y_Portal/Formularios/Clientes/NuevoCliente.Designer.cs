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
            this.components = new System.ComponentModel.Container();
            this.lblAlta = new System.Windows.Forms.Label();
            this.tbcntrlAlta = new System.Windows.Forms.TabControl();
            this.tbpgGenerales = new System.Windows.Forms.TabPage();
            this.cmbxPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.msktxtbxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.msktxtbxCif = new System.Windows.Forms.MaskedTextBox();
            this.lblCif = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtbxNomRep = new System.Windows.Forms.TextBox();
            this.lblNomRep = new System.Windows.Forms.Label();
            this.txtbxCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtbxDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtbxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbpgPrivados = new System.Windows.Forms.TabPage();
            this.rchtxtbxComentarios = new System.Windows.Forms.RichTextBox();
            this.cmsComentarios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.grpbxTipo = new System.Windows.Forms.GroupBox();
            this.rdbttnMultinacional = new System.Windows.Forms.RadioButton();
            this.rdbttnGrande = new System.Windows.Forms.RadioButton();
            this.rdbttnMediana = new System.Windows.Forms.RadioButton();
            this.tdbttnPequeña = new System.Windows.Forms.RadioButton();
            this.tbpgSector = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dudDominio = new System.Windows.Forms.DomainUpDown();
            this.lstbxLista = new System.Windows.Forms.ListBox();
            this.tbpgLogo = new System.Windows.Forms.TabPage();
            this.prgsbrProgreso = new System.Windows.Forms.ProgressBar();
            this.pctbxLogo = new System.Windows.Forms.PictureBox();
            this.bttnArchivo = new System.Windows.Forms.Button();
            this.txtbxLogo = new System.Windows.Forms.TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.tbpgCitas = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bttnAceptar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.tmTemporizador = new System.Windows.Forms.Timer(this.components);
            this.pfdLogo = new System.Windows.Forms.OpenFileDialog();
            this.bttnColor = new System.Windows.Forms.Button();
            this.bttnFuente = new System.Windows.Forms.Button();
            this.bttnExportar = new System.Windows.Forms.Button();
            this.tbcntrlAlta.SuspendLayout();
            this.tbpgGenerales.SuspendLayout();
            this.tbpgPrivados.SuspendLayout();
            this.cmsComentarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpbxTipo.SuspendLayout();
            this.tbpgSector.SuspendLayout();
            this.tbpgLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).BeginInit();
            this.tbpgCitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlta.Location = new System.Drawing.Point(455, 89);
            this.lblAlta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(297, 35);
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
            this.tbcntrlAlta.Location = new System.Drawing.Point(69, 167);
            this.tbcntrlAlta.Margin = new System.Windows.Forms.Padding(4);
            this.tbcntrlAlta.Name = "tbcntrlAlta";
            this.tbcntrlAlta.SelectedIndex = 0;
            this.tbcntrlAlta.Size = new System.Drawing.Size(1199, 527);
            this.tbcntrlAlta.TabIndex = 1;
            // 
            // tbpgGenerales
            // 
            this.tbpgGenerales.Controls.Add(this.cmbxPais);
            this.tbpgGenerales.Controls.Add(this.lblPais);
            this.tbpgGenerales.Controls.Add(this.msktxtbxTelefono);
            this.tbpgGenerales.Controls.Add(this.lblTelefono);
            this.tbpgGenerales.Controls.Add(this.msktxtbxCif);
            this.tbpgGenerales.Controls.Add(this.lblCif);
            this.tbpgGenerales.Controls.Add(this.textBox2);
            this.tbpgGenerales.Controls.Add(this.lblCorreo);
            this.tbpgGenerales.Controls.Add(this.txtbxNomRep);
            this.tbpgGenerales.Controls.Add(this.lblNomRep);
            this.tbpgGenerales.Controls.Add(this.txtbxCiudad);
            this.tbpgGenerales.Controls.Add(this.lblCiudad);
            this.tbpgGenerales.Controls.Add(this.txtbxDireccion);
            this.tbpgGenerales.Controls.Add(this.lblDireccion);
            this.tbpgGenerales.Controls.Add(this.txtbxNombre);
            this.tbpgGenerales.Controls.Add(this.lblNombre);
            this.tbpgGenerales.Location = new System.Drawing.Point(4, 25);
            this.tbpgGenerales.Margin = new System.Windows.Forms.Padding(4);
            this.tbpgGenerales.Name = "tbpgGenerales";
            this.tbpgGenerales.Padding = new System.Windows.Forms.Padding(4);
            this.tbpgGenerales.Size = new System.Drawing.Size(1191, 498);
            this.tbpgGenerales.TabIndex = 1;
            this.tbpgGenerales.Text = "Datos Generales";
            this.tbpgGenerales.UseVisualStyleBackColor = true;
            // 
            // cmbxPais
            // 
            this.cmbxPais.FormattingEnabled = true;
            this.cmbxPais.Location = new System.Drawing.Point(919, 245);
            this.cmbxPais.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxPais.Name = "cmbxPais";
            this.cmbxPais.Size = new System.Drawing.Size(160, 24);
            this.cmbxPais.TabIndex = 15;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(808, 245);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(45, 22);
            this.lblPais.TabIndex = 14;
            this.lblPais.Text = "Pais";
            // 
            // msktxtbxTelefono
            // 
            this.msktxtbxTelefono.Location = new System.Drawing.Point(919, 159);
            this.msktxtbxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.msktxtbxTelefono.Mask = "(999)000-0000";
            this.msktxtbxTelefono.Name = "msktxtbxTelefono";
            this.msktxtbxTelefono.Size = new System.Drawing.Size(132, 22);
            this.msktxtbxTelefono.TabIndex = 13;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(808, 159);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(81, 22);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Telefono";
            // 
            // msktxtbxCif
            // 
            this.msktxtbxCif.Location = new System.Drawing.Point(919, 102);
            this.msktxtbxCif.Margin = new System.Windows.Forms.Padding(4);
            this.msktxtbxCif.Mask = "_-________";
            this.msktxtbxCif.Name = "msktxtbxCif";
            this.msktxtbxCif.Size = new System.Drawing.Size(132, 22);
            this.msktxtbxCif.TabIndex = 11;
            // 
            // lblCif
            // 
            this.lblCif.AutoSize = true;
            this.lblCif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCif.Location = new System.Drawing.Point(808, 106);
            this.lblCif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCif.Name = "lblCif";
            this.lblCif.Size = new System.Drawing.Size(38, 22);
            this.lblCif.TabIndex = 10;
            this.lblCif.Text = "CIF";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 345);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(365, 22);
            this.textBox2.TabIndex = 9;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(85, 345);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(65, 22);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo";
            // 
            // txtbxNomRep
            // 
            this.txtbxNomRep.Location = new System.Drawing.Point(323, 297);
            this.txtbxNomRep.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNomRep.Name = "txtbxNomRep";
            this.txtbxNomRep.Size = new System.Drawing.Size(365, 22);
            this.txtbxNomRep.TabIndex = 7;
            // 
            // lblNomRep
            // 
            this.lblNomRep.AutoSize = true;
            this.lblNomRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomRep.Location = new System.Drawing.Point(85, 297);
            this.lblNomRep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomRep.Name = "lblNomRep";
            this.lblNomRep.Size = new System.Drawing.Size(196, 22);
            this.lblNomRep.TabIndex = 6;
            this.lblNomRep.Text = "Nombre Representante";
            // 
            // txtbxCiudad
            // 
            this.txtbxCiudad.Location = new System.Drawing.Point(323, 245);
            this.txtbxCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxCiudad.Name = "txtbxCiudad";
            this.txtbxCiudad.Size = new System.Drawing.Size(365, 22);
            this.txtbxCiudad.TabIndex = 5;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(85, 245);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(67, 22);
            this.lblCiudad.TabIndex = 4;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtbxDireccion
            // 
            this.txtbxDireccion.Location = new System.Drawing.Point(323, 159);
            this.txtbxDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxDireccion.Multiline = true;
            this.txtbxDireccion.Name = "txtbxDireccion";
            this.txtbxDireccion.Size = new System.Drawing.Size(365, 54);
            this.txtbxDireccion.TabIndex = 3;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(85, 160);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(85, 22);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtbxNombre
            // 
            this.txtbxNombre.Location = new System.Drawing.Point(323, 106);
            this.txtbxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNombre.Name = "txtbxNombre";
            this.txtbxNombre.Size = new System.Drawing.Size(365, 22);
            this.txtbxNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(85, 106);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // tbpgPrivados
            // 
            this.tbpgPrivados.Controls.Add(this.bttnExportar);
            this.tbpgPrivados.Controls.Add(this.bttnFuente);
            this.tbpgPrivados.Controls.Add(this.bttnColor);
            this.tbpgPrivados.Controls.Add(this.rchtxtbxComentarios);
            this.tbpgPrivados.Controls.Add(this.lblComentarios);
            this.tbpgPrivados.Controls.Add(this.numericUpDown1);
            this.tbpgPrivados.Controls.Add(this.lblDescuento);
            this.tbpgPrivados.Controls.Add(this.grpbxTipo);
            this.tbpgPrivados.Location = new System.Drawing.Point(4, 25);
            this.tbpgPrivados.Margin = new System.Windows.Forms.Padding(4);
            this.tbpgPrivados.Name = "tbpgPrivados";
            this.tbpgPrivados.Padding = new System.Windows.Forms.Padding(4);
            this.tbpgPrivados.Size = new System.Drawing.Size(1191, 498);
            this.tbpgPrivados.TabIndex = 2;
            this.tbpgPrivados.Text = "Datos Privados";
            this.tbpgPrivados.UseVisualStyleBackColor = true;
            // 
            // rchtxtbxComentarios
            // 
            this.rchtxtbxComentarios.ContextMenuStrip = this.cmsComentarios;
            this.rchtxtbxComentarios.Location = new System.Drawing.Point(240, 310);
            this.rchtxtbxComentarios.Margin = new System.Windows.Forms.Padding(4);
            this.rchtxtbxComentarios.Name = "rchtxtbxComentarios";
            this.rchtxtbxComentarios.Size = new System.Drawing.Size(484, 162);
            this.rchtxtbxComentarios.TabIndex = 4;
            this.rchtxtbxComentarios.Text = "";
            // 
            // cmsComentarios
            // 
            this.cmsComentarios.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsComentarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fuenteToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.cmsComentarios.Name = "cmsComentarios";
            this.cmsComentarios.Size = new System.Drawing.Size(135, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 24);
            this.toolStripMenuItem1.Text = "Color";
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(73, 311);
            this.lblComentarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(83, 16);
            this.lblComentarios.TabIndex = 3;
            this.lblComentarios.Text = "Comentarios";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(249, 252);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(73, 255);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(72, 16);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "Descuento";
            // 
            // grpbxTipo
            // 
            this.grpbxTipo.Controls.Add(this.rdbttnMultinacional);
            this.grpbxTipo.Controls.Add(this.rdbttnGrande);
            this.grpbxTipo.Controls.Add(this.rdbttnMediana);
            this.grpbxTipo.Controls.Add(this.tdbttnPequeña);
            this.grpbxTipo.Location = new System.Drawing.Point(77, 73);
            this.grpbxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.grpbxTipo.Name = "grpbxTipo";
            this.grpbxTipo.Padding = new System.Windows.Forms.Padding(4);
            this.grpbxTipo.Size = new System.Drawing.Size(356, 128);
            this.grpbxTipo.TabIndex = 0;
            this.grpbxTipo.TabStop = false;
            this.grpbxTipo.Text = "Tipo de Cliente";
            // 
            // rdbttnMultinacional
            // 
            this.rdbttnMultinacional.AutoSize = true;
            this.rdbttnMultinacional.Location = new System.Drawing.Point(172, 80);
            this.rdbttnMultinacional.Margin = new System.Windows.Forms.Padding(4);
            this.rdbttnMultinacional.Name = "rdbttnMultinacional";
            this.rdbttnMultinacional.Size = new System.Drawing.Size(106, 20);
            this.rdbttnMultinacional.TabIndex = 3;
            this.rdbttnMultinacional.TabStop = true;
            this.rdbttnMultinacional.Text = "Multinacional";
            this.rdbttnMultinacional.UseVisualStyleBackColor = true;
            // 
            // rdbttnGrande
            // 
            this.rdbttnGrande.AutoSize = true;
            this.rdbttnGrande.Location = new System.Drawing.Point(172, 39);
            this.rdbttnGrande.Margin = new System.Windows.Forms.Padding(4);
            this.rdbttnGrande.Name = "rdbttnGrande";
            this.rdbttnGrande.Size = new System.Drawing.Size(73, 20);
            this.rdbttnGrande.TabIndex = 2;
            this.rdbttnGrande.TabStop = true;
            this.rdbttnGrande.Text = "Grande";
            this.rdbttnGrande.UseVisualStyleBackColor = true;
            // 
            // rdbttnMediana
            // 
            this.rdbttnMediana.AutoSize = true;
            this.rdbttnMediana.Location = new System.Drawing.Point(27, 80);
            this.rdbttnMediana.Margin = new System.Windows.Forms.Padding(4);
            this.rdbttnMediana.Name = "rdbttnMediana";
            this.rdbttnMediana.Size = new System.Drawing.Size(81, 20);
            this.rdbttnMediana.TabIndex = 1;
            this.rdbttnMediana.TabStop = true;
            this.rdbttnMediana.Text = "Mediana";
            this.rdbttnMediana.UseVisualStyleBackColor = true;
            // 
            // tdbttnPequeña
            // 
            this.tdbttnPequeña.AutoSize = true;
            this.tdbttnPequeña.Location = new System.Drawing.Point(27, 39);
            this.tdbttnPequeña.Margin = new System.Windows.Forms.Padding(4);
            this.tdbttnPequeña.Name = "tdbttnPequeña";
            this.tdbttnPequeña.Size = new System.Drawing.Size(83, 20);
            this.tdbttnPequeña.TabIndex = 0;
            this.tdbttnPequeña.TabStop = true;
            this.tdbttnPequeña.Text = "Pequeña";
            this.tdbttnPequeña.UseVisualStyleBackColor = true;
            // 
            // tbpgSector
            // 
            this.tbpgSector.Controls.Add(this.listView1);
            this.tbpgSector.Controls.Add(this.dudDominio);
            this.tbpgSector.Controls.Add(this.lstbxLista);
            this.tbpgSector.Location = new System.Drawing.Point(4, 25);
            this.tbpgSector.Margin = new System.Windows.Forms.Padding(4);
            this.tbpgSector.Name = "tbpgSector";
            this.tbpgSector.Padding = new System.Windows.Forms.Padding(4);
            this.tbpgSector.Size = new System.Drawing.Size(1191, 498);
            this.tbpgSector.TabIndex = 3;
            this.tbpgSector.Text = "Sector";
            this.tbpgSector.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(742, 167);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(361, 237);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dudDominio
            // 
            this.dudDominio.Location = new System.Drawing.Point(824, 67);
            this.dudDominio.Margin = new System.Windows.Forms.Padding(4);
            this.dudDominio.Name = "dudDominio";
            this.dudDominio.Size = new System.Drawing.Size(160, 22);
            this.dudDominio.TabIndex = 1;
            // 
            // lstbxLista
            // 
            this.lstbxLista.FormattingEnabled = true;
            this.lstbxLista.ItemHeight = 16;
            this.lstbxLista.Location = new System.Drawing.Point(149, 98);
            this.lstbxLista.Margin = new System.Windows.Forms.Padding(4);
            this.lstbxLista.Name = "lstbxLista";
            this.lstbxLista.Size = new System.Drawing.Size(407, 228);
            this.lstbxLista.TabIndex = 0;
            // 
            // tbpgLogo
            // 
            this.tbpgLogo.Controls.Add(this.prgsbrProgreso);
            this.tbpgLogo.Controls.Add(this.pctbxLogo);
            this.tbpgLogo.Controls.Add(this.bttnArchivo);
            this.tbpgLogo.Controls.Add(this.txtbxLogo);
            this.tbpgLogo.Controls.Add(this.lblLogo);
            this.tbpgLogo.Location = new System.Drawing.Point(4, 25);
            this.tbpgLogo.Margin = new System.Windows.Forms.Padding(4);
            this.tbpgLogo.Name = "tbpgLogo";
            this.tbpgLogo.Padding = new System.Windows.Forms.Padding(4);
            this.tbpgLogo.Size = new System.Drawing.Size(1191, 498);
            this.tbpgLogo.TabIndex = 4;
            this.tbpgLogo.Text = "Logo";
            this.tbpgLogo.UseVisualStyleBackColor = true;
            // 
            // prgsbrProgreso
            // 
            this.prgsbrProgreso.Location = new System.Drawing.Point(233, 428);
            this.prgsbrProgreso.Margin = new System.Windows.Forms.Padding(4);
            this.prgsbrProgreso.Name = "prgsbrProgreso";
            this.prgsbrProgreso.Size = new System.Drawing.Size(527, 32);
            this.prgsbrProgreso.TabIndex = 4;
            // 
            // pctbxLogo
            // 
            this.pctbxLogo.Location = new System.Drawing.Point(240, 207);
            this.pctbxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pctbxLogo.Name = "pctbxLogo";
            this.pctbxLogo.Size = new System.Drawing.Size(444, 202);
            this.pctbxLogo.TabIndex = 3;
            this.pctbxLogo.TabStop = false;
            // 
            // bttnArchivo
            // 
            this.bttnArchivo.Font = new System.Drawing.Font("Calibri", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnArchivo.Location = new System.Drawing.Point(569, 156);
            this.bttnArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.bttnArchivo.Name = "bttnArchivo";
            this.bttnArchivo.Size = new System.Drawing.Size(76, 25);
            this.bttnArchivo.TabIndex = 2;
            this.bttnArchivo.Text = "...";
            this.bttnArchivo.UseVisualStyleBackColor = true;
            this.bttnArchivo.Click += new System.EventHandler(this.bttnArchivo_Click);
            // 
            // txtbxLogo
            // 
            this.txtbxLogo.Location = new System.Drawing.Point(243, 158);
            this.txtbxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxLogo.Name = "txtbxLogo";
            this.txtbxLogo.Size = new System.Drawing.Size(288, 22);
            this.txtbxLogo.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(157, 161);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(38, 16);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Logo";
            // 
            // tbpgCitas
            // 
            this.tbpgCitas.Controls.Add(this.monthCalendar1);
            this.tbpgCitas.Controls.Add(this.dateTimePicker1);
            this.tbpgCitas.Location = new System.Drawing.Point(4, 25);
            this.tbpgCitas.Margin = new System.Windows.Forms.Padding(4);
            this.tbpgCitas.Name = "tbpgCitas";
            this.tbpgCitas.Padding = new System.Windows.Forms.Padding(4);
            this.tbpgCitas.Size = new System.Drawing.Size(1191, 498);
            this.tbpgCitas.TabIndex = 5;
            this.tbpgCitas.Text = "Citas";
            this.tbpgCitas.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(427, 178);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(427, 100);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(289, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // bttnAceptar
            // 
            this.bttnAceptar.Location = new System.Drawing.Point(179, 713);
            this.bttnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.bttnAceptar.Name = "bttnAceptar";
            this.bttnAceptar.Size = new System.Drawing.Size(263, 46);
            this.bttnAceptar.TabIndex = 2;
            this.bttnAceptar.Text = "Aceptar";
            this.bttnAceptar.UseVisualStyleBackColor = true;
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Location = new System.Drawing.Point(927, 713);
            this.bttnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(263, 46);
            this.bttnCancelar.TabIndex = 3;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            // 
            // tmTemporizador
            // 
            this.tmTemporizador.Tick += new System.EventHandler(this.tmTemporizador_Tick);
            // 
            // pfdLogo
            // 
            this.pfdLogo.FileName = "openFileDialog1";
            this.pfdLogo.InitialDirectory = "C:\\Users\\alumno\\source\\repos\\Inicio_Y_Portal\\Inicio_Y_Portal\\Logos";
            // 
            // bttnColor
            // 
            this.bttnColor.Location = new System.Drawing.Point(802, 311);
            this.bttnColor.Name = "bttnColor";
            this.bttnColor.Size = new System.Drawing.Size(92, 29);
            this.bttnColor.TabIndex = 5;
            this.bttnColor.Text = "Color";
            this.bttnColor.UseVisualStyleBackColor = true;
            this.bttnColor.Click += new System.EventHandler(this.bttnColor_Click);
            // 
            // bttnFuente
            // 
            this.bttnFuente.Location = new System.Drawing.Point(802, 367);
            this.bttnFuente.Name = "bttnFuente";
            this.bttnFuente.Size = new System.Drawing.Size(92, 29);
            this.bttnFuente.TabIndex = 6;
            this.bttnFuente.Text = "Fuente";
            this.bttnFuente.UseVisualStyleBackColor = true;
            this.bttnFuente.Click += new System.EventHandler(this.bttnFuente_Click);
            // 
            // bttnExportar
            // 
            this.bttnExportar.Location = new System.Drawing.Point(802, 415);
            this.bttnExportar.Name = "bttnExportar";
            this.bttnExportar.Size = new System.Drawing.Size(92, 29);
            this.bttnExportar.TabIndex = 7;
            this.bttnExportar.Text = "Exportar";
            this.bttnExportar.UseVisualStyleBackColor = true;
            this.bttnExportar.Click += new System.EventHandler(this.bttnExportar_Click);
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1339, 789);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnAceptar);
            this.Controls.Add(this.tbcntrlAlta);
            this.Controls.Add(this.lblAlta);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NuevoCliente";
            this.Text = "NuevoCliente";
            this.tbcntrlAlta.ResumeLayout(false);
            this.tbpgGenerales.ResumeLayout(false);
            this.tbpgGenerales.PerformLayout();
            this.tbpgPrivados.ResumeLayout(false);
            this.tbpgPrivados.PerformLayout();
            this.cmsComentarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpbxTipo.ResumeLayout(false);
            this.grpbxTipo.PerformLayout();
            this.tbpgSector.ResumeLayout(false);
            this.tbpgLogo.ResumeLayout(false);
            this.tbpgLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).EndInit();
            this.tbpgCitas.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtbxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtbxDireccion;
        private System.Windows.Forms.TextBox txtbxNomRep;
        private System.Windows.Forms.Label lblNomRep;
        private System.Windows.Forms.TextBox txtbxCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.MaskedTextBox msktxtbxTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox msktxtbxCif;
        private System.Windows.Forms.Label lblCif;
        private System.Windows.Forms.ComboBox cmbxPais;
        private System.Windows.Forms.GroupBox grpbxTipo;
        private System.Windows.Forms.RadioButton rdbttnMultinacional;
        private System.Windows.Forms.RadioButton rdbttnGrande;
        private System.Windows.Forms.RadioButton rdbttnMediana;
        private System.Windows.Forms.RadioButton tdbttnPequeña;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button bttnArchivo;
        private System.Windows.Forms.TextBox txtbxLogo;
        private System.Windows.Forms.ProgressBar prgsbrProgreso;
        private System.Windows.Forms.PictureBox pctbxLogo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox rchtxtbxComentarios;
        private System.Windows.Forms.Timer tmTemporizador;
        private System.Windows.Forms.DomainUpDown dudDominio;
        private System.Windows.Forms.ListBox lstbxLista;
        private System.Windows.Forms.ContextMenuStrip cmsComentarios;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog pfdLogo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button bttnFuente;
        private System.Windows.Forms.Button bttnColor;
        private System.Windows.Forms.Button bttnExportar;
    }
}