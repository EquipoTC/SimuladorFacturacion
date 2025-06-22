/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 6/5/2024
 * Time: 20:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SimuladorFacturacion
{
	partial class FormDatosOperacion
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Label lblProductoServicio;
		private System.Windows.Forms.Label lblCant;
		private System.Windows.Forms.Label lblUmedida;
		private System.Windows.Forms.Label lblPrecUnitario;
		private System.Windows.Forms.Label lblBon;
		private System.Windows.Forms.Label lblImporteBon;
		private System.Windows.Forms.Label lblSubtotal;
		private System.Windows.Forms.Label lblAlicuotaIVA;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblProductoServicio = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblUmedida = new System.Windows.Forms.Label();
            this.lblPrecUnitario = new System.Windows.Forms.Label();
            this.lblBon = new System.Windows.Forms.Label();
            this.lblImporteBon = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblAlicuotaIVA = new System.Windows.Forms.Label();
            this.lblDatosOperacion = new System.Windows.Forms.Label();
            this.txtCodigo1 = new System.Windows.Forms.TextBox();
            this.txtProductoServicio1 = new System.Windows.Forms.TextBox();
            this.txtCant1 = new System.Windows.Forms.TextBox();
            this.cbxUmedida1 = new System.Windows.Forms.ComboBox();
            this.txtPrecUnitario1 = new System.Windows.Forms.TextBox();
            this.txtPorcentajeBon1 = new System.Windows.Forms.TextBox();
            this.txtImporteBon1 = new System.Windows.Forms.TextBox();
            this.txtSubtotal1 = new System.Windows.Forms.TextBox();
            this.txtCodigo3 = new System.Windows.Forms.TextBox();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.txtProductoServicio3 = new System.Windows.Forms.TextBox();
            this.txtProductoServicio2 = new System.Windows.Forms.TextBox();
            this.txtCant3 = new System.Windows.Forms.TextBox();
            this.txtCant2 = new System.Windows.Forms.TextBox();
            this.cbxUmedida2 = new System.Windows.Forms.ComboBox();
            this.cbxUmedida3 = new System.Windows.Forms.ComboBox();
            this.txtPrecUnitario3 = new System.Windows.Forms.TextBox();
            this.txtPrecUnitario2 = new System.Windows.Forms.TextBox();
            this.txtPorcentajeBon3 = new System.Windows.Forms.TextBox();
            this.txtPorcentajeBon2 = new System.Windows.Forms.TextBox();
            this.txtImporteBon3 = new System.Windows.Forms.TextBox();
            this.txtImporteBon2 = new System.Windows.Forms.TextBox();
            this.txtSubtotal3 = new System.Windows.Forms.TextBox();
            this.txtSubtotal2 = new System.Windows.Forms.TextBox();
            this.cbxAlicuotaIVA1 = new System.Windows.Forms.ComboBox();
            this.cbxAlicuotaIVA2 = new System.Windows.Forms.ComboBox();
            this.cbxAlicuotaIVA3 = new System.Windows.Forms.ComboBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblPerRetGanancias = new System.Windows.Forms.Label();
            this.lblPerRetIVA = new System.Windows.Forms.Label();
            this.lblImpuestosMunicipales = new System.Windows.Forms.Label();
            this.lblImpuestosInternos = new System.Windows.Forms.Label();
            this.lblPerRetIngresosBrutos = new System.Windows.Forms.Label();
            this.txtPerRetIVA_Importe = new System.Windows.Forms.TextBox();
            this.txtPerRetIVA_Alicuota = new System.Windows.Forms.TextBox();
            this.txtPerRetIVA_BaseImp = new System.Windows.Forms.TextBox();
            this.txtPerRetIVA_Detalle = new System.Windows.Forms.TextBox();
            this.txtPerRetGanancias_Importe = new System.Windows.Forms.TextBox();
            this.txtPerRetGanancias_Alicuota = new System.Windows.Forms.TextBox();
            this.txtPerRetGanancias_BaseImp = new System.Windows.Forms.TextBox();
            this.txtPerRetGanancias_Detalle = new System.Windows.Forms.TextBox();
            this.txtPerRetIngresosBrutos_Importe = new System.Windows.Forms.TextBox();
            this.txtPerRetIngresosBrutos_Alicuota = new System.Windows.Forms.TextBox();
            this.txtPerRetIngresosBrutos_BaseImp = new System.Windows.Forms.TextBox();
            this.txtPerRetIngresosBrutos_Detalle = new System.Windows.Forms.TextBox();
            this.txtImpuestosInternos_Importe = new System.Windows.Forms.TextBox();
            this.txtImpuestosInternos_Alicuota = new System.Windows.Forms.TextBox();
            this.txtImpuestosInternos_BaseImp = new System.Windows.Forms.TextBox();
            this.txtImpuestosInternos_Detalle = new System.Windows.Forms.TextBox();
            this.txtImpuestosMunicipales_Importe = new System.Windows.Forms.TextBox();
            this.txtImpuestosMunicipales_Alicuota = new System.Windows.Forms.TextBox();
            this.txtImpuestosMunicipales_BaseImp = new System.Windows.Forms.TextBox();
            this.txtImpuestosMunicipales_Detalle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblBaseImp = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblAlicuotaPorciento = new System.Windows.Forms.Label();
            this.lblImporteOtrosTributos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImporteOtrosTributos = new System.Windows.Forms.TextBox();
            this.lblImpNetoNoGravado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImpNetoNoGravado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImpExento = new System.Windows.Forms.TextBox();
            this.lblImporteExtento = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtImpNetoGravado = new System.Windows.Forms.TextBox();
            this.lblImpNetoGravado = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIVA27 = new System.Windows.Forms.TextBox();
            this.lblIVA27 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIVA21 = new System.Windows.Forms.TextBox();
            this.lblIVA21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIVA10 = new System.Windows.Forms.TextBox();
            this.lblIVA10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIVA5 = new System.Windows.Forms.TextBox();
            this.lblIVA5 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtIVA2 = new System.Windows.Forms.TextBox();
            this.lblIVA25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtIVA0 = new System.Windows.Forms.TextBox();
            this.lblIVA0 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtImpOtrosTributos = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImpTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtImporteIVA2 = new System.Windows.Forms.TextBox();
            this.txtImporteIVA3 = new System.Windows.Forms.TextBox();
            this.txtImporteIVA1 = new System.Windows.Forms.TextBox();
            this.lblImporteIVA = new System.Windows.Forms.Label();
            this.txtSubtotalIVA2 = new System.Windows.Forms.TextBox();
            this.txtSubtotalIVA3 = new System.Windows.Forms.TextBox();
            this.txtSubtotalIVA1 = new System.Windows.Forms.TextBox();
            this.lblSubtotalconIVA = new System.Windows.Forms.Label();
            this.btnBorrar1 = new System.Windows.Forms.Button();
            this.lblBorrar = new System.Windows.Forms.Label();
            this.btnBorrar2 = new System.Windows.Forms.Button();
            this.btnBorrar3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(37, 69);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(68, 23);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblProductoServicio
            // 
            this.lblProductoServicio.BackColor = System.Drawing.Color.Transparent;
            this.lblProductoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoServicio.Location = new System.Drawing.Point(155, 69);
            this.lblProductoServicio.Name = "lblProductoServicio";
            this.lblProductoServicio.Size = new System.Drawing.Size(135, 23);
            this.lblProductoServicio.TabIndex = 1;
            this.lblProductoServicio.Text = "Producto/Servicio";
            // 
            // lblCant
            // 
            this.lblCant.BackColor = System.Drawing.Color.Transparent;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(336, 69);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(46, 23);
            this.lblCant.TabIndex = 2;
            this.lblCant.Text = "Cant.";
            // 
            // lblUmedida
            // 
            this.lblUmedida.BackColor = System.Drawing.Color.Transparent;
            this.lblUmedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUmedida.Location = new System.Drawing.Point(419, 69);
            this.lblUmedida.Name = "lblUmedida";
            this.lblUmedida.Size = new System.Drawing.Size(85, 23);
            this.lblUmedida.TabIndex = 3;
            this.lblUmedida.Text = "U. Medida";
            // 
            // lblPrecUnitario
            // 
            this.lblPrecUnitario.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecUnitario.Location = new System.Drawing.Point(526, 69);
            this.lblPrecUnitario.Name = "lblPrecUnitario";
            this.lblPrecUnitario.Size = new System.Drawing.Size(105, 23);
            this.lblPrecUnitario.TabIndex = 4;
            this.lblPrecUnitario.Text = "Prec. Unitario";
            // 
            // lblBon
            // 
            this.lblBon.BackColor = System.Drawing.Color.Transparent;
            this.lblBon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBon.Location = new System.Drawing.Point(634, 69);
            this.lblBon.Name = "lblBon";
            this.lblBon.Size = new System.Drawing.Size(59, 18);
            this.lblBon.TabIndex = 5;
            this.lblBon.Text = "% Bon.";
            // 
            // lblImporteBon
            // 
            this.lblImporteBon.BackColor = System.Drawing.Color.Transparent;
            this.lblImporteBon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteBon.Location = new System.Drawing.Point(698, 69);
            this.lblImporteBon.Name = "lblImporteBon";
            this.lblImporteBon.Size = new System.Drawing.Size(101, 23);
            this.lblImporteBon.TabIndex = 6;
            this.lblImporteBon.Text = "Importe Bon.";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(805, 69);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(67, 23);
            this.lblSubtotal.TabIndex = 7;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblAlicuotaIVA
            // 
            this.lblAlicuotaIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblAlicuotaIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlicuotaIVA.Location = new System.Drawing.Point(886, 69);
            this.lblAlicuotaIVA.Name = "lblAlicuotaIVA";
            this.lblAlicuotaIVA.Size = new System.Drawing.Size(93, 23);
            this.lblAlicuotaIVA.TabIndex = 8;
            this.lblAlicuotaIVA.Text = "Alicuota IVA";
            // 
            // lblDatosOperacion
            // 
            this.lblDatosOperacion.AutoSize = true;
            this.lblDatosOperacion.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosOperacion.Location = new System.Drawing.Point(568, 23);
            this.lblDatosOperacion.Name = "lblDatosOperacion";
            this.lblDatosOperacion.Size = new System.Drawing.Size(275, 20);
            this.lblDatosOperacion.TabIndex = 9;
            this.lblDatosOperacion.Text = "Datos de la Operación (Paso 4/4)";
            // 
            // txtCodigo1
            // 
            this.txtCodigo1.Location = new System.Drawing.Point(18, 92);
            this.txtCodigo1.Name = "txtCodigo1";
            this.txtCodigo1.Size = new System.Drawing.Size(81, 20);
            this.txtCodigo1.TabIndex = 10;
            // 
            // txtProductoServicio1
            // 
            this.txtProductoServicio1.Location = new System.Drawing.Point(112, 92);
            this.txtProductoServicio1.Name = "txtProductoServicio1";
            this.txtProductoServicio1.Size = new System.Drawing.Size(198, 20);
            this.txtProductoServicio1.TabIndex = 11;
            // 
            // txtCant1
            // 
            this.txtCant1.Location = new System.Drawing.Point(324, 92);
            this.txtCant1.Name = "txtCant1";
            this.txtCant1.Size = new System.Drawing.Size(52, 20);
            this.txtCant1.TabIndex = 12;
            this.txtCant1.TextChanged += new System.EventHandler(this.TextChangedRenglon1);
            // 
            // cbxUmedida1
            // 
            this.cbxUmedida1.BackColor = System.Drawing.SystemColors.Control;
            this.cbxUmedida1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUmedida1.FormattingEnabled = true;
            this.cbxUmedida1.Items.AddRange(new object[] {
            "Kilogramos",
            "Metros",
            "Metros Cuadrados",
            "Metros Cubicos",
            "Litros",
            "1000 kWh",
            "Unidades",
            "Pares",
            "Docenas",
            "Quilates",
            "Millares",
            "Gramos",
            "Milimetros",
            "MM Cubicos",
            "Kilometro",
            "Hectolitros",
            "Centímetros",
            "Jgo. Pqt. Mazo Naipes",
            "CM Cubicos ",
            "Kilogramos",
            "Metros",
            "Metros Cuadrados",
            "Metros Cubicos",
            "Litros",
            "1000 kWh",
            "Unidades",
            "Pares",
            "Docenas",
            "Quilates",
            "Millares",
            "Gramos",
            "Milimetros",
            "MM Cubicos",
            "Kilometro",
            "Hectolitros",
            "Centímetros",
            "Jgo. Pqt. Mazo Naipes",
            "CM Cubicos "});
            this.cbxUmedida1.Location = new System.Drawing.Point(390, 91);
            this.cbxUmedida1.Name = "cbxUmedida1";
            this.cbxUmedida1.Size = new System.Drawing.Size(121, 21);
            this.cbxUmedida1.TabIndex = 100;
            // 
            // txtPrecUnitario1
            // 
            this.txtPrecUnitario1.Location = new System.Drawing.Point(527, 91);
            this.txtPrecUnitario1.Name = "txtPrecUnitario1";
            this.txtPrecUnitario1.Size = new System.Drawing.Size(85, 20);
            this.txtPrecUnitario1.TabIndex = 13;
            this.txtPrecUnitario1.TextChanged += new System.EventHandler(this.TextChangedRenglon1);
            // 
            // txtPorcentajeBon1
            // 
            this.txtPorcentajeBon1.Location = new System.Drawing.Point(631, 91);
            this.txtPorcentajeBon1.Name = "txtPorcentajeBon1";
            this.txtPorcentajeBon1.Size = new System.Drawing.Size(47, 20);
            this.txtPorcentajeBon1.TabIndex = 14;
            this.txtPorcentajeBon1.TextChanged += new System.EventHandler(this.TextChangedRenglon1);
            // 
            // txtImporteBon1
            // 
            this.txtImporteBon1.BackColor = System.Drawing.Color.LightGray;
            this.txtImporteBon1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImporteBon1.Location = new System.Drawing.Point(695, 91);
            this.txtImporteBon1.Name = "txtImporteBon1";
            this.txtImporteBon1.ReadOnly = true;
            this.txtImporteBon1.Size = new System.Drawing.Size(80, 20);
            this.txtImporteBon1.TabIndex = 100;
            // 
            // txtSubtotal1
            // 
            this.txtSubtotal1.BackColor = System.Drawing.Color.LightGray;
            this.txtSubtotal1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSubtotal1.Location = new System.Drawing.Point(793, 91);
            this.txtSubtotal1.Name = "txtSubtotal1";
            this.txtSubtotal1.ReadOnly = true;
            this.txtSubtotal1.Size = new System.Drawing.Size(70, 20);
            this.txtSubtotal1.TabIndex = 100;
            this.txtSubtotal1.TextChanged += new System.EventHandler(this.mostrarTotalizadores);
            // 
            // txtCodigo3
            // 
            this.txtCodigo3.Location = new System.Drawing.Point(18, 166);
            this.txtCodigo3.Name = "txtCodigo3";
            this.txtCodigo3.Size = new System.Drawing.Size(81, 20);
            this.txtCodigo3.TabIndex = 20;
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Location = new System.Drawing.Point(18, 128);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(81, 20);
            this.txtCodigo2.TabIndex = 15;
            // 
            // txtProductoServicio3
            // 
            this.txtProductoServicio3.Location = new System.Drawing.Point(112, 166);
            this.txtProductoServicio3.Name = "txtProductoServicio3";
            this.txtProductoServicio3.Size = new System.Drawing.Size(198, 20);
            this.txtProductoServicio3.TabIndex = 21;
            // 
            // txtProductoServicio2
            // 
            this.txtProductoServicio2.Location = new System.Drawing.Point(112, 128);
            this.txtProductoServicio2.Name = "txtProductoServicio2";
            this.txtProductoServicio2.Size = new System.Drawing.Size(198, 20);
            this.txtProductoServicio2.TabIndex = 16;
            // 
            // txtCant3
            // 
            this.txtCant3.Location = new System.Drawing.Point(324, 166);
            this.txtCant3.Name = "txtCant3";
            this.txtCant3.Size = new System.Drawing.Size(52, 20);
            this.txtCant3.TabIndex = 22;
            this.txtCant3.TextChanged += new System.EventHandler(this.TextChangedRenglon3);
            // 
            // txtCant2
            // 
            this.txtCant2.Location = new System.Drawing.Point(324, 128);
            this.txtCant2.Name = "txtCant2";
            this.txtCant2.Size = new System.Drawing.Size(52, 20);
            this.txtCant2.TabIndex = 17;
            this.txtCant2.TextChanged += new System.EventHandler(this.TextChangedRenglon2);
            // 
            // cbxUmedida2
            // 
            this.cbxUmedida2.BackColor = System.Drawing.SystemColors.Control;
            this.cbxUmedida2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUmedida2.FormattingEnabled = true;
            this.cbxUmedida2.Items.AddRange(new object[] {
            "Kilogramos",
            "Metros",
            "Metros Cuadrados",
            "Metros Cubicos",
            "Litros",
            "1000 kWh",
            "Unidades",
            "Pares",
            "Docenas",
            "Quilates",
            "Millares",
            "Gramos",
            "Milimetros",
            "MM Cubicos",
            "Kilometro",
            "Hectolitros",
            "Centímetros",
            "Jgo. Pqt. Mazo Naipes",
            "CM Cubicos ",
            "Kilogramos",
            "Metros",
            "Metros Cuadrados",
            "Metros Cubicos",
            "Litros",
            "1000 kWh",
            "Unidades",
            "Pares",
            "Docenas",
            "Quilates",
            "Millares",
            "Gramos",
            "Milimetros",
            "MM Cubicos",
            "Kilometro",
            "Hectolitros",
            "Centímetros",
            "Jgo. Pqt. Mazo Naipes",
            "CM Cubicos "});
            this.cbxUmedida2.Location = new System.Drawing.Point(390, 128);
            this.cbxUmedida2.Name = "cbxUmedida2";
            this.cbxUmedida2.Size = new System.Drawing.Size(121, 21);
            this.cbxUmedida2.TabIndex = 100;
            // 
            // cbxUmedida3
            // 
            this.cbxUmedida3.BackColor = System.Drawing.SystemColors.Control;
            this.cbxUmedida3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUmedida3.FormattingEnabled = true;
            this.cbxUmedida3.Items.AddRange(new object[] {
            "Kilogramos",
            "Metros",
            "Metros Cuadrados",
            "Metros Cubicos",
            "Litros",
            "1000 kWh",
            "Unidades",
            "Pares",
            "Docenas",
            "Quilates",
            "Millares",
            "Gramos",
            "Milimetros",
            "MM Cubicos",
            "Kilometro",
            "Hectolitros",
            "Centímetros",
            "Jgo. Pqt. Mazo Naipes",
            "CM Cubicos ",
            "Kilogramos",
            "Metros",
            "Metros Cuadrados",
            "Metros Cubicos",
            "Litros",
            "1000 kWh",
            "Unidades",
            "Pares",
            "Docenas",
            "Quilates",
            "Millares",
            "Gramos",
            "Milimetros",
            "MM Cubicos",
            "Kilometro",
            "Hectolitros",
            "Centímetros",
            "Jgo. Pqt. Mazo Naipes",
            "CM Cubicos "});
            this.cbxUmedida3.Location = new System.Drawing.Point(390, 167);
            this.cbxUmedida3.Name = "cbxUmedida3";
            this.cbxUmedida3.Size = new System.Drawing.Size(121, 21);
            this.cbxUmedida3.TabIndex = 100;
            // 
            // txtPrecUnitario3
            // 
            this.txtPrecUnitario3.Location = new System.Drawing.Point(527, 166);
            this.txtPrecUnitario3.Name = "txtPrecUnitario3";
            this.txtPrecUnitario3.Size = new System.Drawing.Size(85, 20);
            this.txtPrecUnitario3.TabIndex = 23;
            this.txtPrecUnitario3.TextChanged += new System.EventHandler(this.TextChangedRenglon3);
            // 
            // txtPrecUnitario2
            // 
            this.txtPrecUnitario2.Location = new System.Drawing.Point(527, 128);
            this.txtPrecUnitario2.Name = "txtPrecUnitario2";
            this.txtPrecUnitario2.Size = new System.Drawing.Size(85, 20);
            this.txtPrecUnitario2.TabIndex = 18;
            this.txtPrecUnitario2.TextChanged += new System.EventHandler(this.TextChangedRenglon2);
            // 
            // txtPorcentajeBon3
            // 
            this.txtPorcentajeBon3.Location = new System.Drawing.Point(631, 166);
            this.txtPorcentajeBon3.Name = "txtPorcentajeBon3";
            this.txtPorcentajeBon3.Size = new System.Drawing.Size(47, 20);
            this.txtPorcentajeBon3.TabIndex = 24;
            this.txtPorcentajeBon3.TextChanged += new System.EventHandler(this.TextChangedRenglon3);
            // 
            // txtPorcentajeBon2
            // 
            this.txtPorcentajeBon2.Location = new System.Drawing.Point(631, 128);
            this.txtPorcentajeBon2.Name = "txtPorcentajeBon2";
            this.txtPorcentajeBon2.Size = new System.Drawing.Size(47, 20);
            this.txtPorcentajeBon2.TabIndex = 19;
            this.txtPorcentajeBon2.TextChanged += new System.EventHandler(this.TextChangedRenglon2);
            // 
            // txtImporteBon3
            // 
            this.txtImporteBon3.BackColor = System.Drawing.Color.LightGray;
            this.txtImporteBon3.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImporteBon3.Location = new System.Drawing.Point(695, 166);
            this.txtImporteBon3.Name = "txtImporteBon3";
            this.txtImporteBon3.ReadOnly = true;
            this.txtImporteBon3.Size = new System.Drawing.Size(80, 20);
            this.txtImporteBon3.TabIndex = 100;
            // 
            // txtImporteBon2
            // 
            this.txtImporteBon2.BackColor = System.Drawing.Color.LightGray;
            this.txtImporteBon2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImporteBon2.Location = new System.Drawing.Point(695, 128);
            this.txtImporteBon2.Name = "txtImporteBon2";
            this.txtImporteBon2.ReadOnly = true;
            this.txtImporteBon2.Size = new System.Drawing.Size(80, 20);
            this.txtImporteBon2.TabIndex = 100;
            // 
            // txtSubtotal3
            // 
            this.txtSubtotal3.BackColor = System.Drawing.Color.LightGray;
            this.txtSubtotal3.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSubtotal3.Location = new System.Drawing.Point(793, 166);
            this.txtSubtotal3.Name = "txtSubtotal3";
            this.txtSubtotal3.ReadOnly = true;
            this.txtSubtotal3.Size = new System.Drawing.Size(70, 20);
            this.txtSubtotal3.TabIndex = 100;
            this.txtSubtotal3.TextChanged += new System.EventHandler(this.mostrarTotalizadores);
            // 
            // txtSubtotal2
            // 
            this.txtSubtotal2.BackColor = System.Drawing.Color.LightGray;
            this.txtSubtotal2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSubtotal2.Location = new System.Drawing.Point(793, 128);
            this.txtSubtotal2.Name = "txtSubtotal2";
            this.txtSubtotal2.ReadOnly = true;
            this.txtSubtotal2.Size = new System.Drawing.Size(70, 20);
            this.txtSubtotal2.TabIndex = 100;
            this.txtSubtotal2.TextChanged += new System.EventHandler(this.mostrarTotalizadores);
            // 
            // cbxAlicuotaIVA1
            // 
            this.cbxAlicuotaIVA1.BackColor = System.Drawing.SystemColors.Control;
            this.cbxAlicuotaIVA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlicuotaIVA1.FormattingEnabled = true;
            this.cbxAlicuotaIVA1.Items.AddRange(new object[] {
            "No gravado",
            "Exento",
            "0",
            "2,5",
            "5",
            "10,5",
            "21",
            "27"});
            this.cbxAlicuotaIVA1.Location = new System.Drawing.Point(878, 90);
            this.cbxAlicuotaIVA1.Name = "cbxAlicuotaIVA1";
            this.cbxAlicuotaIVA1.Size = new System.Drawing.Size(91, 21);
            this.cbxAlicuotaIVA1.TabIndex = 100;
            this.cbxAlicuotaIVA1.TextChanged += new System.EventHandler(this.TextChangedRenglon1);
            // 
            // cbxAlicuotaIVA2
            // 
            this.cbxAlicuotaIVA2.BackColor = System.Drawing.SystemColors.Control;
            this.cbxAlicuotaIVA2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlicuotaIVA2.FormattingEnabled = true;
            this.cbxAlicuotaIVA2.Items.AddRange(new object[] {
            "No gravado",
            "Exento",
            "0",
            "2,5",
            "5",
            "10,5",
            "21",
            "27"});
            this.cbxAlicuotaIVA2.Location = new System.Drawing.Point(878, 128);
            this.cbxAlicuotaIVA2.Name = "cbxAlicuotaIVA2";
            this.cbxAlicuotaIVA2.Size = new System.Drawing.Size(91, 21);
            this.cbxAlicuotaIVA2.TabIndex = 100;
            this.cbxAlicuotaIVA2.TextChanged += new System.EventHandler(this.TextChangedRenglon2);
            // 
            // cbxAlicuotaIVA3
            // 
            this.cbxAlicuotaIVA3.BackColor = System.Drawing.SystemColors.Control;
            this.cbxAlicuotaIVA3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlicuotaIVA3.FormattingEnabled = true;
            this.cbxAlicuotaIVA3.Items.AddRange(new object[] {
            "No gravado",
            "Exento",
            "0",
            "2,5",
            "5",
            "10,5",
            "21",
            "27"});
            this.cbxAlicuotaIVA3.Location = new System.Drawing.Point(878, 165);
            this.cbxAlicuotaIVA3.Name = "cbxAlicuotaIVA3";
            this.cbxAlicuotaIVA3.Size = new System.Drawing.Size(91, 21);
            this.cbxAlicuotaIVA3.TabIndex = 100;
            this.cbxAlicuotaIVA3.TextChanged += new System.EventHandler(this.TextChangedRenglon3);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.Location = new System.Drawing.Point(30, 699);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 41;
            this.btnAnterior.Text = "< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.Location = new System.Drawing.Point(1210, 699);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 40;
            this.btnSiguiente.Text = "Finalizar >";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblPerRetGanancias
            // 
            this.lblPerRetGanancias.AutoSize = true;
            this.lblPerRetGanancias.BackColor = System.Drawing.Color.Transparent;
            this.lblPerRetGanancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerRetGanancias.Location = new System.Drawing.Point(16, 262);
            this.lblPerRetGanancias.Name = "lblPerRetGanancias";
            this.lblPerRetGanancias.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPerRetGanancias.Size = new System.Drawing.Size(247, 16);
            this.lblPerRetGanancias.TabIndex = 42;
            this.lblPerRetGanancias.Text = "Per. / Ret. de Imp. a las Ganancias";
            // 
            // lblPerRetIVA
            // 
            this.lblPerRetIVA.AutoSize = true;
            this.lblPerRetIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblPerRetIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerRetIVA.Location = new System.Drawing.Point(135, 298);
            this.lblPerRetIVA.Name = "lblPerRetIVA";
            this.lblPerRetIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPerRetIVA.Size = new System.Drawing.Size(126, 16);
            this.lblPerRetIVA.TabIndex = 43;
            this.lblPerRetIVA.Text = "Per. / Ret. de IVA";
            // 
            // lblImpuestosMunicipales
            // 
            this.lblImpuestosMunicipales.AutoSize = true;
            this.lblImpuestosMunicipales.BackColor = System.Drawing.Color.Transparent;
            this.lblImpuestosMunicipales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestosMunicipales.Location = new System.Drawing.Point(96, 418);
            this.lblImpuestosMunicipales.Name = "lblImpuestosMunicipales";
            this.lblImpuestosMunicipales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblImpuestosMunicipales.Size = new System.Drawing.Size(165, 16);
            this.lblImpuestosMunicipales.TabIndex = 44;
            this.lblImpuestosMunicipales.Text = "Impuestos Municipales";
            // 
            // lblImpuestosInternos
            // 
            this.lblImpuestosInternos.AutoSize = true;
            this.lblImpuestosInternos.BackColor = System.Drawing.Color.Transparent;
            this.lblImpuestosInternos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestosInternos.Location = new System.Drawing.Point(124, 378);
            this.lblImpuestosInternos.Name = "lblImpuestosInternos";
            this.lblImpuestosInternos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblImpuestosInternos.Size = new System.Drawing.Size(137, 16);
            this.lblImpuestosInternos.TabIndex = 45;
            this.lblImpuestosInternos.Text = "Impuestos Internos";
            // 
            // lblPerRetIngresosBrutos
            // 
            this.lblPerRetIngresosBrutos.AutoSize = true;
            this.lblPerRetIngresosBrutos.BackColor = System.Drawing.Color.Transparent;
            this.lblPerRetIngresosBrutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerRetIngresosBrutos.Location = new System.Drawing.Point(73, 339);
            this.lblPerRetIngresosBrutos.Name = "lblPerRetIngresosBrutos";
            this.lblPerRetIngresosBrutos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPerRetIngresosBrutos.Size = new System.Drawing.Size(188, 16);
            this.lblPerRetIngresosBrutos.TabIndex = 46;
            this.lblPerRetIngresosBrutos.Text = "Per. / Ret. Ingresos Brutos";
            // 
            // txtPerRetIVA_Importe
            // 
            this.txtPerRetIVA_Importe.BackColor = System.Drawing.Color.LightGray;
            this.txtPerRetIVA_Importe.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPerRetIVA_Importe.Location = new System.Drawing.Point(694, 297);
            this.txtPerRetIVA_Importe.Name = "txtPerRetIVA_Importe";
            this.txtPerRetIVA_Importe.ReadOnly = true;
            this.txtPerRetIVA_Importe.Size = new System.Drawing.Size(125, 20);
            this.txtPerRetIVA_Importe.TabIndex = 100;
            // 
            // txtPerRetIVA_Alicuota
            // 
            this.txtPerRetIVA_Alicuota.Location = new System.Drawing.Point(605, 296);
            this.txtPerRetIVA_Alicuota.Name = "txtPerRetIVA_Alicuota";
            this.txtPerRetIVA_Alicuota.Size = new System.Drawing.Size(70, 20);
            this.txtPerRetIVA_Alicuota.TabIndex = 30;
            this.txtPerRetIVA_Alicuota.TextChanged += new System.EventHandler(this.calcularImporteOtrosTributos);
            // 
            // txtPerRetIVA_BaseImp
            // 
            this.txtPerRetIVA_BaseImp.Location = new System.Drawing.Point(472, 296);
            this.txtPerRetIVA_BaseImp.Name = "txtPerRetIVA_BaseImp";
            this.txtPerRetIVA_BaseImp.Size = new System.Drawing.Size(127, 20);
            this.txtPerRetIVA_BaseImp.TabIndex = 29;
            this.txtPerRetIVA_BaseImp.TextChanged += new System.EventHandler(this.calcularImporteOtrosTributos);
            // 
            // txtPerRetIVA_Detalle
            // 
            this.txtPerRetIVA_Detalle.Location = new System.Drawing.Point(260, 296);
            this.txtPerRetIVA_Detalle.Name = "txtPerRetIVA_Detalle";
            this.txtPerRetIVA_Detalle.Size = new System.Drawing.Size(206, 20);
            this.txtPerRetIVA_Detalle.TabIndex = 28;
            // 
            // txtPerRetGanancias_Importe
            // 
            this.txtPerRetGanancias_Importe.BackColor = System.Drawing.Color.LightGray;
            this.txtPerRetGanancias_Importe.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPerRetGanancias_Importe.Location = new System.Drawing.Point(694, 260);
            this.txtPerRetGanancias_Importe.Name = "txtPerRetGanancias_Importe";
            this.txtPerRetGanancias_Importe.ReadOnly = true;
            this.txtPerRetGanancias_Importe.Size = new System.Drawing.Size(125, 20);
            this.txtPerRetGanancias_Importe.TabIndex = 100;
            // 
            // txtPerRetGanancias_Alicuota
            // 
            this.txtPerRetGanancias_Alicuota.Location = new System.Drawing.Point(605, 260);
            this.txtPerRetGanancias_Alicuota.Name = "txtPerRetGanancias_Alicuota";
            this.txtPerRetGanancias_Alicuota.Size = new System.Drawing.Size(70, 20);
            this.txtPerRetGanancias_Alicuota.TabIndex = 27;
            this.txtPerRetGanancias_Alicuota.TextChanged += new System.EventHandler(this.calcularImporteOtrosTributos);
            // 
            // txtPerRetGanancias_BaseImp
            // 
            this.txtPerRetGanancias_BaseImp.Location = new System.Drawing.Point(472, 260);
            this.txtPerRetGanancias_BaseImp.Name = "txtPerRetGanancias_BaseImp";
            this.txtPerRetGanancias_BaseImp.Size = new System.Drawing.Size(127, 20);
            this.txtPerRetGanancias_BaseImp.TabIndex = 26;
            this.txtPerRetGanancias_BaseImp.TextChanged += new System.EventHandler(this.calcularImporteOtrosTributos);
            // 
            // txtPerRetGanancias_Detalle
            // 
            this.txtPerRetGanancias_Detalle.Location = new System.Drawing.Point(260, 260);
            this.txtPerRetGanancias_Detalle.Name = "txtPerRetGanancias_Detalle";
            this.txtPerRetGanancias_Detalle.Size = new System.Drawing.Size(206, 20);
            this.txtPerRetGanancias_Detalle.TabIndex = 25;
            // 
            // txtPerRetIngresosBrutos_Importe
            // 
            this.txtPerRetIngresosBrutos_Importe.BackColor = System.Drawing.Color.LightGray;
            this.txtPerRetIngresosBrutos_Importe.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPerRetIngresosBrutos_Importe.Location = new System.Drawing.Point(694, 337);
            this.txtPerRetIngresosBrutos_Importe.Name = "txtPerRetIngresosBrutos_Importe";
            this.txtPerRetIngresosBrutos_Importe.ReadOnly = true;
            this.txtPerRetIngresosBrutos_Importe.Size = new System.Drawing.Size(125, 20);
            this.txtPerRetIngresosBrutos_Importe.TabIndex = 100;
            // 
            // txtPerRetIngresosBrutos_Alicuota
            // 
            this.txtPerRetIngresosBrutos_Alicuota.Location = new System.Drawing.Point(605, 337);
            this.txtPerRetIngresosBrutos_Alicuota.Name = "txtPerRetIngresosBrutos_Alicuota";
            this.txtPerRetIngresosBrutos_Alicuota.Size = new System.Drawing.Size(70, 20);
            this.txtPerRetIngresosBrutos_Alicuota.TabIndex = 33;
            this.txtPerRetIngresosBrutos_Alicuota.TextChanged += new System.EventHandler(this.calcularImporteOtrosTributos);
            // 
            // txtPerRetIngresosBrutos_BaseImp
            // 
            this.txtPerRetIngresosBrutos_BaseImp.Location = new System.Drawing.Point(472, 337);
            this.txtPerRetIngresosBrutos_BaseImp.Name = "txtPerRetIngresosBrutos_BaseImp";
            this.txtPerRetIngresosBrutos_BaseImp.Size = new System.Drawing.Size(127, 20);
            this.txtPerRetIngresosBrutos_BaseImp.TabIndex = 32;
            this.txtPerRetIngresosBrutos_BaseImp.TextChanged += new System.EventHandler(this.calcularImporteOtrosTributos);
            // 
            // txtPerRetIngresosBrutos_Detalle
            // 
            this.txtPerRetIngresosBrutos_Detalle.Location = new System.Drawing.Point(260, 337);
            this.txtPerRetIngresosBrutos_Detalle.Name = "txtPerRetIngresosBrutos_Detalle";
            this.txtPerRetIngresosBrutos_Detalle.Size = new System.Drawing.Size(206, 20);
            this.txtPerRetIngresosBrutos_Detalle.TabIndex = 31;
            // 
            // txtImpuestosInternos_Importe
            // 
            this.txtImpuestosInternos_Importe.BackColor = System.Drawing.Color.LightGray;
            this.txtImpuestosInternos_Importe.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImpuestosInternos_Importe.Location = new System.Drawing.Point(694, 376);
            this.txtImpuestosInternos_Importe.Name = "txtImpuestosInternos_Importe";
            this.txtImpuestosInternos_Importe.ReadOnly = true;
            this.txtImpuestosInternos_Importe.Size = new System.Drawing.Size(125, 20);
            this.txtImpuestosInternos_Importe.TabIndex = 100;
            // 
            // txtImpuestosInternos_Alicuota
            // 
            this.txtImpuestosInternos_Alicuota.Location = new System.Drawing.Point(605, 376);
            this.txtImpuestosInternos_Alicuota.Name = "txtImpuestosInternos_Alicuota";
            this.txtImpuestosInternos_Alicuota.Size = new System.Drawing.Size(70, 20);
            this.txtImpuestosInternos_Alicuota.TabIndex = 36;
            this.txtImpuestosInternos_Alicuota.TextChanged += new System.EventHandler(this.calcularImporteOtrosTributos);
            // 
            // txtImpuestosInternos_BaseImp
            // 
            this.txtImpuestosInternos_BaseImp.Location = new System.Drawing.Point(472, 376);
            this.txtImpuestosInternos_BaseImp.Name = "txtImpuestosInternos_BaseImp";
            this.txtImpuestosInternos_BaseImp.Size = new System.Drawing.Size(127, 20);
            this.txtImpuestosInternos_BaseImp.TabIndex = 35;
            this.txtImpuestosInternos_BaseImp.TextChanged += new System.EventHandler(this.calcularImporteOtrosTributos);
            // 
            // txtImpuestosInternos_Detalle
            // 
            this.txtImpuestosInternos_Detalle.Location = new System.Drawing.Point(260, 376);
            this.txtImpuestosInternos_Detalle.Name = "txtImpuestosInternos_Detalle";
            this.txtImpuestosInternos_Detalle.Size = new System.Drawing.Size(206, 20);
            this.txtImpuestosInternos_Detalle.TabIndex = 34;
            // 
            // txtImpuestosMunicipales_Importe
            // 
            this.txtImpuestosMunicipales_Importe.BackColor = System.Drawing.Color.LightGray;
            this.txtImpuestosMunicipales_Importe.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImpuestosMunicipales_Importe.Location = new System.Drawing.Point(694, 416);
            this.txtImpuestosMunicipales_Importe.Name = "txtImpuestosMunicipales_Importe";
            this.txtImpuestosMunicipales_Importe.ReadOnly = true;
            this.txtImpuestosMunicipales_Importe.Size = new System.Drawing.Size(125, 20);
            this.txtImpuestosMunicipales_Importe.TabIndex = 100;
            // 
            // txtImpuestosMunicipales_Alicuota
            // 
            this.txtImpuestosMunicipales_Alicuota.Location = new System.Drawing.Point(605, 416);
            this.txtImpuestosMunicipales_Alicuota.Name = "txtImpuestosMunicipales_Alicuota";
            this.txtImpuestosMunicipales_Alicuota.Size = new System.Drawing.Size(70, 20);
            this.txtImpuestosMunicipales_Alicuota.TabIndex = 39;
            this.txtImpuestosMunicipales_Alicuota.TextChanged += new System.EventHandler(this.calcularImporteOtrosTributos);
            // 
            // txtImpuestosMunicipales_BaseImp
            // 
            this.txtImpuestosMunicipales_BaseImp.Location = new System.Drawing.Point(472, 416);
            this.txtImpuestosMunicipales_BaseImp.Name = "txtImpuestosMunicipales_BaseImp";
            this.txtImpuestosMunicipales_BaseImp.Size = new System.Drawing.Size(127, 20);
            this.txtImpuestosMunicipales_BaseImp.TabIndex = 38;
            this.txtImpuestosMunicipales_BaseImp.TextChanged += new System.EventHandler(this.calcularImporteOtrosTributos);
            // 
            // txtImpuestosMunicipales_Detalle
            // 
            this.txtImpuestosMunicipales_Detalle.Location = new System.Drawing.Point(260, 416);
            this.txtImpuestosMunicipales_Detalle.Name = "txtImpuestosMunicipales_Detalle";
            this.txtImpuestosMunicipales_Detalle.Size = new System.Drawing.Size(206, 20);
            this.txtImpuestosMunicipales_Detalle.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(683, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(683, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(683, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(683, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(683, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 75;
            this.label5.Text = "$";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(346, 242);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(57, 16);
            this.lblDetalle.TabIndex = 76;
            this.lblDetalle.Text = "Detalle";
            // 
            // lblBaseImp
            // 
            this.lblBaseImp.AutoSize = true;
            this.lblBaseImp.BackColor = System.Drawing.Color.Transparent;
            this.lblBaseImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseImp.Location = new System.Drawing.Point(480, 242);
            this.lblBaseImp.Name = "lblBaseImp";
            this.lblBaseImp.Size = new System.Drawing.Size(115, 16);
            this.lblBaseImp.TabIndex = 77;
            this.lblBaseImp.Text = "Base Imponible";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.BackColor = System.Drawing.Color.Transparent;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(732, 242);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(59, 16);
            this.lblImporte.TabIndex = 78;
            this.lblImporte.Text = "Importe";
            // 
            // lblAlicuotaPorciento
            // 
            this.lblAlicuotaPorciento.AutoSize = true;
            this.lblAlicuotaPorciento.BackColor = System.Drawing.Color.Transparent;
            this.lblAlicuotaPorciento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlicuotaPorciento.Location = new System.Drawing.Point(608, 242);
            this.lblAlicuotaPorciento.Name = "lblAlicuotaPorciento";
            this.lblAlicuotaPorciento.Size = new System.Drawing.Size(80, 16);
            this.lblAlicuotaPorciento.TabIndex = 79;
            this.lblAlicuotaPorciento.Text = "Alícuota %";
            // 
            // lblImporteOtrosTributos
            // 
            this.lblImporteOtrosTributos.AutoSize = true;
            this.lblImporteOtrosTributos.BackColor = System.Drawing.Color.Transparent;
            this.lblImporteOtrosTributos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteOtrosTributos.Location = new System.Drawing.Point(521, 458);
            this.lblImporteOtrosTributos.Name = "lblImporteOtrosTributos";
            this.lblImporteOtrosTributos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblImporteOtrosTributos.Size = new System.Drawing.Size(161, 16);
            this.lblImporteOtrosTributos.TabIndex = 80;
            this.lblImporteOtrosTributos.Text = "Importe Otros Tributos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(683, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "$";
            // 
            // txtImporteOtrosTributos
            // 
            this.txtImporteOtrosTributos.BackColor = System.Drawing.Color.LightGray;
            this.txtImporteOtrosTributos.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImporteOtrosTributos.Location = new System.Drawing.Point(694, 453);
            this.txtImporteOtrosTributos.Name = "txtImporteOtrosTributos";
            this.txtImporteOtrosTributos.ReadOnly = true;
            this.txtImporteOtrosTributos.Size = new System.Drawing.Size(125, 20);
            this.txtImporteOtrosTributos.TabIndex = 100;
            // 
            // lblImpNetoNoGravado
            // 
            this.lblImpNetoNoGravado.AutoSize = true;
            this.lblImpNetoNoGravado.BackColor = System.Drawing.Color.Transparent;
            this.lblImpNetoNoGravado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpNetoNoGravado.Location = new System.Drawing.Point(934, 242);
            this.lblImpNetoNoGravado.Name = "lblImpNetoNoGravado";
            this.lblImpNetoNoGravado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblImpNetoNoGravado.Size = new System.Drawing.Size(184, 16);
            this.lblImpNetoNoGravado.TabIndex = 83;
            this.lblImpNetoNoGravado.Text = "Importe Neto No Gravado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1128, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 87;
            this.label9.Text = "$";
            // 
            // txtImpNetoNoGravado
            // 
            this.txtImpNetoNoGravado.BackColor = System.Drawing.Color.LightGray;
            this.txtImpNetoNoGravado.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImpNetoNoGravado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtImpNetoNoGravado.Location = new System.Drawing.Point(1140, 237);
            this.txtImpNetoNoGravado.Name = "txtImpNetoNoGravado";
            this.txtImpNetoNoGravado.ReadOnly = true;
            this.txtImpNetoNoGravado.Size = new System.Drawing.Size(154, 20);
            this.txtImpNetoNoGravado.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1128, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 90;
            this.label8.Text = "$";
            // 
            // txtImpExento
            // 
            this.txtImpExento.BackColor = System.Drawing.Color.LightGray;
            this.txtImpExento.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImpExento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtImpExento.Location = new System.Drawing.Point(1140, 270);
            this.txtImpExento.Name = "txtImpExento";
            this.txtImpExento.ReadOnly = true;
            this.txtImpExento.Size = new System.Drawing.Size(154, 20);
            this.txtImpExento.TabIndex = 100;
            // 
            // lblImporteExtento
            // 
            this.lblImporteExtento.AutoSize = true;
            this.lblImporteExtento.BackColor = System.Drawing.Color.Transparent;
            this.lblImporteExtento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteExtento.Location = new System.Drawing.Point(1004, 275);
            this.lblImporteExtento.Name = "lblImporteExtento";
            this.lblImporteExtento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblImporteExtento.Size = new System.Drawing.Size(110, 16);
            this.lblImporteExtento.TabIndex = 88;
            this.lblImporteExtento.Text = "Importe Exento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1128, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 16);
            this.label11.TabIndex = 93;
            this.label11.Text = "$";
            // 
            // txtImpNetoGravado
            // 
            this.txtImpNetoGravado.BackColor = System.Drawing.Color.LightGray;
            this.txtImpNetoGravado.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImpNetoGravado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtImpNetoGravado.Location = new System.Drawing.Point(1140, 306);
            this.txtImpNetoGravado.Name = "txtImpNetoGravado";
            this.txtImpNetoGravado.ReadOnly = true;
            this.txtImpNetoGravado.Size = new System.Drawing.Size(154, 20);
            this.txtImpNetoGravado.TabIndex = 92;
            // 
            // lblImpNetoGravado
            // 
            this.lblImpNetoGravado.AutoSize = true;
            this.lblImpNetoGravado.BackColor = System.Drawing.Color.Transparent;
            this.lblImpNetoGravado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpNetoGravado.Location = new System.Drawing.Point(958, 311);
            this.lblImpNetoGravado.Name = "lblImpNetoGravado";
            this.lblImpNetoGravado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblImpNetoGravado.Size = new System.Drawing.Size(160, 16);
            this.lblImpNetoGravado.TabIndex = 91;
            this.lblImpNetoGravado.Text = "Importe Neto Gravado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1128, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 16);
            this.label13.TabIndex = 96;
            this.label13.Text = "$";
            // 
            // txtIVA27
            // 
            this.txtIVA27.BackColor = System.Drawing.Color.LightGray;
            this.txtIVA27.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIVA27.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIVA27.Location = new System.Drawing.Point(1140, 346);
            this.txtIVA27.Name = "txtIVA27";
            this.txtIVA27.ReadOnly = true;
            this.txtIVA27.Size = new System.Drawing.Size(154, 20);
            this.txtIVA27.TabIndex = 95;
            // 
            // lblIVA27
            // 
            this.lblIVA27.AutoSize = true;
            this.lblIVA27.BackColor = System.Drawing.Color.Transparent;
            this.lblIVA27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA27.Location = new System.Drawing.Point(1054, 350);
            this.lblIVA27.Name = "lblIVA27";
            this.lblIVA27.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIVA27.Size = new System.Drawing.Size(64, 16);
            this.lblIVA27.TabIndex = 94;
            this.lblIVA27.Text = "IVA 27%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1128, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 16);
            this.label15.TabIndex = 99;
            this.label15.Text = "$";
            // 
            // txtIVA21
            // 
            this.txtIVA21.BackColor = System.Drawing.Color.LightGray;
            this.txtIVA21.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIVA21.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIVA21.Location = new System.Drawing.Point(1140, 386);
            this.txtIVA21.Name = "txtIVA21";
            this.txtIVA21.ReadOnly = true;
            this.txtIVA21.Size = new System.Drawing.Size(154, 20);
            this.txtIVA21.TabIndex = 98;
            // 
            // lblIVA21
            // 
            this.lblIVA21.AutoSize = true;
            this.lblIVA21.BackColor = System.Drawing.Color.Transparent;
            this.lblIVA21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA21.Location = new System.Drawing.Point(1054, 390);
            this.lblIVA21.Name = "lblIVA21";
            this.lblIVA21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIVA21.Size = new System.Drawing.Size(64, 16);
            this.lblIVA21.TabIndex = 97;
            this.lblIVA21.Text = "IVA 21%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1128, 430);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 16);
            this.label17.TabIndex = 102;
            this.label17.Text = "$";
            // 
            // txtIVA10
            // 
            this.txtIVA10.BackColor = System.Drawing.Color.LightGray;
            this.txtIVA10.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIVA10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIVA10.Location = new System.Drawing.Point(1140, 426);
            this.txtIVA10.Name = "txtIVA10";
            this.txtIVA10.ReadOnly = true;
            this.txtIVA10.Size = new System.Drawing.Size(154, 20);
            this.txtIVA10.TabIndex = 101;
            // 
            // lblIVA10
            // 
            this.lblIVA10.AutoSize = true;
            this.lblIVA10.BackColor = System.Drawing.Color.Transparent;
            this.lblIVA10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA10.Location = new System.Drawing.Point(1042, 430);
            this.lblIVA10.Name = "lblIVA10";
            this.lblIVA10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIVA10.Size = new System.Drawing.Size(76, 16);
            this.lblIVA10.TabIndex = 100;
            this.lblIVA10.Text = "IVA 10.5%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1128, 468);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 16);
            this.label19.TabIndex = 105;
            this.label19.Text = "$";
            // 
            // txtIVA5
            // 
            this.txtIVA5.BackColor = System.Drawing.Color.LightGray;
            this.txtIVA5.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIVA5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIVA5.Location = new System.Drawing.Point(1140, 464);
            this.txtIVA5.Name = "txtIVA5";
            this.txtIVA5.ReadOnly = true;
            this.txtIVA5.Size = new System.Drawing.Size(154, 20);
            this.txtIVA5.TabIndex = 104;
            // 
            // lblIVA5
            // 
            this.lblIVA5.AutoSize = true;
            this.lblIVA5.BackColor = System.Drawing.Color.Transparent;
            this.lblIVA5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA5.Location = new System.Drawing.Point(1062, 468);
            this.lblIVA5.Name = "lblIVA5";
            this.lblIVA5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIVA5.Size = new System.Drawing.Size(56, 16);
            this.lblIVA5.TabIndex = 103;
            this.lblIVA5.Text = "IVA 5%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1128, 505);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 16);
            this.label21.TabIndex = 108;
            this.label21.Text = "$";
            // 
            // txtIVA2
            // 
            this.txtIVA2.BackColor = System.Drawing.Color.LightGray;
            this.txtIVA2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIVA2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIVA2.Location = new System.Drawing.Point(1140, 501);
            this.txtIVA2.Name = "txtIVA2";
            this.txtIVA2.ReadOnly = true;
            this.txtIVA2.Size = new System.Drawing.Size(154, 20);
            this.txtIVA2.TabIndex = 107;
            // 
            // lblIVA25
            // 
            this.lblIVA25.AutoSize = true;
            this.lblIVA25.BackColor = System.Drawing.Color.Transparent;
            this.lblIVA25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA25.Location = new System.Drawing.Point(1050, 505);
            this.lblIVA25.Name = "lblIVA25";
            this.lblIVA25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIVA25.Size = new System.Drawing.Size(68, 16);
            this.lblIVA25.TabIndex = 106;
            this.lblIVA25.Text = "IVA 2.5%";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1128, 543);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 16);
            this.label23.TabIndex = 111;
            this.label23.Text = "$";
            // 
            // txtIVA0
            // 
            this.txtIVA0.BackColor = System.Drawing.Color.LightGray;
            this.txtIVA0.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIVA0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIVA0.Location = new System.Drawing.Point(1140, 539);
            this.txtIVA0.Name = "txtIVA0";
            this.txtIVA0.ReadOnly = true;
            this.txtIVA0.Size = new System.Drawing.Size(154, 20);
            this.txtIVA0.TabIndex = 110;
            // 
            // lblIVA0
            // 
            this.lblIVA0.AutoSize = true;
            this.lblIVA0.BackColor = System.Drawing.Color.Transparent;
            this.lblIVA0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA0.Location = new System.Drawing.Point(1062, 543);
            this.lblIVA0.Name = "lblIVA0";
            this.lblIVA0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIVA0.Size = new System.Drawing.Size(56, 16);
            this.lblIVA0.TabIndex = 109;
            this.lblIVA0.Text = "IVA 0%";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(1128, 618);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 16);
            this.label25.TabIndex = 114;
            this.label25.Text = "$";
            // 
            // txtImpOtrosTributos
            // 
            this.txtImpOtrosTributos.BackColor = System.Drawing.Color.LightGray;
            this.txtImpOtrosTributos.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImpOtrosTributos.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtImpOtrosTributos.Location = new System.Drawing.Point(1140, 614);
            this.txtImpOtrosTributos.Name = "txtImpOtrosTributos";
            this.txtImpOtrosTributos.ReadOnly = true;
            this.txtImpOtrosTributos.Size = new System.Drawing.Size(154, 20);
            this.txtImpOtrosTributos.TabIndex = 113;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(961, 618);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label26.Size = new System.Drawing.Size(161, 16);
            this.label26.TabIndex = 112;
            this.label26.Text = "Importe Otros Tributos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1124, 658);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 116;
            this.label6.Text = "$";
            // 
            // txtImpTotal
            // 
            this.txtImpTotal.BackColor = System.Drawing.Color.LightGray;
            this.txtImpTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImpTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtImpTotal.Location = new System.Drawing.Point(1140, 653);
            this.txtImpTotal.Name = "txtImpTotal";
            this.txtImpTotal.ReadOnly = true;
            this.txtImpTotal.Size = new System.Drawing.Size(154, 29);
            this.txtImpTotal.TabIndex = 115;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(987, 657);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(132, 24);
            this.label10.TabIndex = 117;
            this.label10.Text = "Importe Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(908, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 610);
            this.panel1.TabIndex = 118;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(0, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2500, 2);
            this.panel2.TabIndex = 119;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(0, 585);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2500, 2);
            this.panel3.TabIndex = 120;
            // 
            // txtImporteIVA2
            // 
            this.txtImporteIVA2.BackColor = System.Drawing.Color.LightGray;
            this.txtImporteIVA2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImporteIVA2.Location = new System.Drawing.Point(990, 128);
            this.txtImporteIVA2.Name = "txtImporteIVA2";
            this.txtImporteIVA2.ReadOnly = true;
            this.txtImporteIVA2.Size = new System.Drawing.Size(90, 20);
            this.txtImporteIVA2.TabIndex = 100;
            this.txtImporteIVA2.TextChanged += new System.EventHandler(this.mostrarTotalizadores);
            // 
            // txtImporteIVA3
            // 
            this.txtImporteIVA3.BackColor = System.Drawing.Color.LightGray;
            this.txtImporteIVA3.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImporteIVA3.Location = new System.Drawing.Point(990, 166);
            this.txtImporteIVA3.Name = "txtImporteIVA3";
            this.txtImporteIVA3.ReadOnly = true;
            this.txtImporteIVA3.Size = new System.Drawing.Size(90, 20);
            this.txtImporteIVA3.TabIndex = 100;
            this.txtImporteIVA3.TextChanged += new System.EventHandler(this.mostrarTotalizadores);
            // 
            // txtImporteIVA1
            // 
            this.txtImporteIVA1.BackColor = System.Drawing.Color.LightGray;
            this.txtImporteIVA1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtImporteIVA1.Location = new System.Drawing.Point(990, 91);
            this.txtImporteIVA1.Name = "txtImporteIVA1";
            this.txtImporteIVA1.ReadOnly = true;
            this.txtImporteIVA1.Size = new System.Drawing.Size(90, 20);
            this.txtImporteIVA1.TabIndex = 100;
            this.txtImporteIVA1.TextChanged += new System.EventHandler(this.mostrarTotalizadores);
            // 
            // lblImporteIVA
            // 
            this.lblImporteIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblImporteIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteIVA.Location = new System.Drawing.Point(999, 69);
            this.lblImporteIVA.Name = "lblImporteIVA";
            this.lblImporteIVA.Size = new System.Drawing.Size(87, 23);
            this.lblImporteIVA.TabIndex = 121;
            this.lblImporteIVA.Text = "Importe IVA";
            // 
            // txtSubtotalIVA2
            // 
            this.txtSubtotalIVA2.BackColor = System.Drawing.Color.LightGray;
            this.txtSubtotalIVA2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSubtotalIVA2.Location = new System.Drawing.Point(1101, 128);
            this.txtSubtotalIVA2.Name = "txtSubtotalIVA2";
            this.txtSubtotalIVA2.ReadOnly = true;
            this.txtSubtotalIVA2.Size = new System.Drawing.Size(131, 20);
            this.txtSubtotalIVA2.TabIndex = 100;
            // 
            // txtSubtotalIVA3
            // 
            this.txtSubtotalIVA3.BackColor = System.Drawing.Color.LightGray;
            this.txtSubtotalIVA3.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSubtotalIVA3.Location = new System.Drawing.Point(1101, 166);
            this.txtSubtotalIVA3.Name = "txtSubtotalIVA3";
            this.txtSubtotalIVA3.ReadOnly = true;
            this.txtSubtotalIVA3.Size = new System.Drawing.Size(131, 20);
            this.txtSubtotalIVA3.TabIndex = 100;
            // 
            // txtSubtotalIVA1
            // 
            this.txtSubtotalIVA1.BackColor = System.Drawing.Color.LightGray;
            this.txtSubtotalIVA1.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSubtotalIVA1.Location = new System.Drawing.Point(1101, 91);
            this.txtSubtotalIVA1.Name = "txtSubtotalIVA1";
            this.txtSubtotalIVA1.ReadOnly = true;
            this.txtSubtotalIVA1.Size = new System.Drawing.Size(131, 20);
            this.txtSubtotalIVA1.TabIndex = 100;
            // 
            // lblSubtotalconIVA
            // 
            this.lblSubtotalconIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotalconIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalconIVA.Location = new System.Drawing.Point(1110, 69);
            this.lblSubtotalconIVA.Name = "lblSubtotalconIVA";
            this.lblSubtotalconIVA.Size = new System.Drawing.Size(128, 23);
            this.lblSubtotalconIVA.TabIndex = 125;
            this.lblSubtotalconIVA.Text = "Subtotal con IVA";
            // 
            // btnBorrar1
            // 
            this.btnBorrar1.ForeColor = System.Drawing.Color.Red;
            this.btnBorrar1.Location = new System.Drawing.Point(1255, 89);
            this.btnBorrar1.Name = "btnBorrar1";
            this.btnBorrar1.Size = new System.Drawing.Size(47, 23);
            this.btnBorrar1.TabIndex = 129;
            this.btnBorrar1.Text = "❌\r\n";
            this.btnBorrar1.UseVisualStyleBackColor = true;
            this.btnBorrar1.Click += new System.EventHandler(this.btnBorrar1_Click);
            // 
            // lblBorrar
            // 
            this.lblBorrar.BackColor = System.Drawing.Color.Transparent;
            this.lblBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrar.ForeColor = System.Drawing.Color.Red;
            this.lblBorrar.Location = new System.Drawing.Point(1259, 69);
            this.lblBorrar.Name = "lblBorrar";
            this.lblBorrar.Size = new System.Drawing.Size(59, 23);
            this.lblBorrar.TabIndex = 130;
            this.lblBorrar.Text = "Borrar";
            // 
            // btnBorrar2
            // 
            this.btnBorrar2.ForeColor = System.Drawing.Color.Red;
            this.btnBorrar2.Location = new System.Drawing.Point(1255, 126);
            this.btnBorrar2.Name = "btnBorrar2";
            this.btnBorrar2.Size = new System.Drawing.Size(47, 23);
            this.btnBorrar2.TabIndex = 131;
            this.btnBorrar2.Text = "❌\r\n";
            this.btnBorrar2.UseVisualStyleBackColor = true;
            this.btnBorrar2.Click += new System.EventHandler(this.btnBorrar2_Click);
            // 
            // btnBorrar3
            // 
            this.btnBorrar3.ForeColor = System.Drawing.Color.Red;
            this.btnBorrar3.Location = new System.Drawing.Point(1255, 163);
            this.btnBorrar3.Name = "btnBorrar3";
            this.btnBorrar3.Size = new System.Drawing.Size(47, 23);
            this.btnBorrar3.TabIndex = 132;
            this.btnBorrar3.Text = "❌\r\n";
            this.btnBorrar3.UseVisualStyleBackColor = true;
            this.btnBorrar3.Click += new System.EventHandler(this.btnBorrar3_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::SimuladorFacturacion.Properties.Resources.Degradado_blanco_azul_GRANDE;
            this.panel4.Controls.Add(this.lblPerRetGanancias);
            this.panel4.Controls.Add(this.lblPerRetIVA);
            this.panel4.Controls.Add(this.lblBorrar);
            this.panel4.Controls.Add(this.lblImpuestosMunicipales);
            this.panel4.Controls.Add(this.lblImpuestosInternos);
            this.panel4.Controls.Add(this.lblPerRetIngresosBrutos);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblSubtotalconIVA);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblDetalle);
            this.panel4.Controls.Add(this.lblImporteIVA);
            this.panel4.Controls.Add(this.lblBaseImp);
            this.panel4.Controls.Add(this.lblImporte);
            this.panel4.Controls.Add(this.lblAlicuotaPorciento);
            this.panel4.Controls.Add(this.lblImporteOtrosTributos);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblImpNetoNoGravado);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.lblImporteExtento);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.lblImpNetoGravado);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.lblIVA27);
            this.panel4.Controls.Add(this.lblIVA0);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.lblIVA21);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.lblIVA25);
            this.panel4.Controls.Add(this.lblIVA10);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.lblIVA5);
            this.panel4.Controls.Add(this.lblProductoServicio);
            this.panel4.Controls.Add(this.lblCodigo);
            this.panel4.Controls.Add(this.lblCant);
            this.panel4.Controls.Add(this.lblUmedida);
            this.panel4.Controls.Add(this.lblPrecUnitario);
            this.panel4.Controls.Add(this.btnSiguiente);
            this.panel4.Controls.Add(this.btnAnterior);
            this.panel4.Controls.Add(this.lblBon);
            this.panel4.Controls.Add(this.lblImporteBon);
            this.panel4.Controls.Add(this.lblSubtotal);
            this.panel4.Controls.Add(this.lblAlicuotaIVA);
            this.panel4.Controls.Add(this.lblDatosOperacion);
            this.panel4.Location = new System.Drawing.Point(-6, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1331, 740);
            this.panel4.TabIndex = 133;
            // 
            // FormDatosOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1318, 733);
            this.Controls.Add(this.btnBorrar3);
            this.Controls.Add(this.btnBorrar2);
            this.Controls.Add(this.btnBorrar1);
            this.Controls.Add(this.txtSubtotalIVA2);
            this.Controls.Add(this.txtSubtotalIVA3);
            this.Controls.Add(this.txtSubtotalIVA1);
            this.Controls.Add(this.txtImporteIVA2);
            this.Controls.Add(this.txtImporteIVA3);
            this.Controls.Add(this.txtImporteIVA1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtImpTotal);
            this.Controls.Add(this.txtImpOtrosTributos);
            this.Controls.Add(this.txtIVA0);
            this.Controls.Add(this.txtIVA2);
            this.Controls.Add(this.txtIVA5);
            this.Controls.Add(this.txtIVA10);
            this.Controls.Add(this.txtIVA21);
            this.Controls.Add(this.txtIVA27);
            this.Controls.Add(this.txtImpNetoGravado);
            this.Controls.Add(this.txtImpExento);
            this.Controls.Add(this.txtImpNetoNoGravado);
            this.Controls.Add(this.txtImporteOtrosTributos);
            this.Controls.Add(this.txtImpuestosMunicipales_Importe);
            this.Controls.Add(this.txtImpuestosMunicipales_Alicuota);
            this.Controls.Add(this.txtImpuestosMunicipales_BaseImp);
            this.Controls.Add(this.txtImpuestosMunicipales_Detalle);
            this.Controls.Add(this.txtImpuestosInternos_Importe);
            this.Controls.Add(this.txtImpuestosInternos_Alicuota);
            this.Controls.Add(this.txtImpuestosInternos_BaseImp);
            this.Controls.Add(this.txtImpuestosInternos_Detalle);
            this.Controls.Add(this.txtPerRetIngresosBrutos_Importe);
            this.Controls.Add(this.txtPerRetIngresosBrutos_Alicuota);
            this.Controls.Add(this.txtPerRetIngresosBrutos_BaseImp);
            this.Controls.Add(this.txtPerRetIngresosBrutos_Detalle);
            this.Controls.Add(this.txtPerRetGanancias_Importe);
            this.Controls.Add(this.txtPerRetGanancias_Alicuota);
            this.Controls.Add(this.txtPerRetGanancias_BaseImp);
            this.Controls.Add(this.txtPerRetGanancias_Detalle);
            this.Controls.Add(this.txtPerRetIVA_Importe);
            this.Controls.Add(this.txtPerRetIVA_Alicuota);
            this.Controls.Add(this.txtPerRetIVA_BaseImp);
            this.Controls.Add(this.txtPerRetIVA_Detalle);
            this.Controls.Add(this.cbxAlicuotaIVA3);
            this.Controls.Add(this.cbxAlicuotaIVA2);
            this.Controls.Add(this.cbxAlicuotaIVA1);
            this.Controls.Add(this.txtSubtotal2);
            this.Controls.Add(this.txtSubtotal3);
            this.Controls.Add(this.txtImporteBon2);
            this.Controls.Add(this.txtImporteBon3);
            this.Controls.Add(this.txtPorcentajeBon2);
            this.Controls.Add(this.txtPorcentajeBon3);
            this.Controls.Add(this.txtPrecUnitario2);
            this.Controls.Add(this.txtPrecUnitario3);
            this.Controls.Add(this.cbxUmedida3);
            this.Controls.Add(this.cbxUmedida2);
            this.Controls.Add(this.txtCant2);
            this.Controls.Add(this.txtCant3);
            this.Controls.Add(this.txtProductoServicio2);
            this.Controls.Add(this.txtProductoServicio3);
            this.Controls.Add(this.txtCodigo2);
            this.Controls.Add(this.txtCodigo3);
            this.Controls.Add(this.txtSubtotal1);
            this.Controls.Add(this.txtImporteBon1);
            this.Controls.Add(this.txtPorcentajeBon1);
            this.Controls.Add(this.txtPrecUnitario1);
            this.Controls.Add(this.cbxUmedida1);
            this.Controls.Add(this.txtCant1);
            this.Controls.Add(this.txtProductoServicio1);
            this.Controls.Add(this.txtCodigo1);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDatosOperacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos De La Operación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDatosOperacion_FormClosing);
            this.Load += new System.EventHandler(this.FormDatosOperacionLoad);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormDatosOperacion_KeyPress);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label lblDatosOperacion;
        private System.Windows.Forms.TextBox txtCodigo1;
        private System.Windows.Forms.TextBox txtProductoServicio1;
        private System.Windows.Forms.TextBox txtCant1;
        private System.Windows.Forms.ComboBox cbxUmedida1;
        private System.Windows.Forms.TextBox txtPrecUnitario1;
        private System.Windows.Forms.TextBox txtPorcentajeBon1;
        private System.Windows.Forms.TextBox txtImporteBon1;
        private System.Windows.Forms.TextBox txtSubtotal1;
        private System.Windows.Forms.TextBox txtCodigo3;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.TextBox txtProductoServicio3;
        private System.Windows.Forms.TextBox txtProductoServicio2;
        private System.Windows.Forms.TextBox txtCant3;
        private System.Windows.Forms.TextBox txtCant2;
        private System.Windows.Forms.ComboBox cbxUmedida2;
        private System.Windows.Forms.ComboBox cbxUmedida3;
        private System.Windows.Forms.TextBox txtPrecUnitario3;
        private System.Windows.Forms.TextBox txtPrecUnitario2;
        private System.Windows.Forms.TextBox txtPorcentajeBon3;
        private System.Windows.Forms.TextBox txtPorcentajeBon2;
        private System.Windows.Forms.TextBox txtImporteBon3;
        private System.Windows.Forms.TextBox txtImporteBon2;
        private System.Windows.Forms.TextBox txtSubtotal3;
        private System.Windows.Forms.TextBox txtSubtotal2;
        private System.Windows.Forms.ComboBox cbxAlicuotaIVA1;
        private System.Windows.Forms.ComboBox cbxAlicuotaIVA2;
        private System.Windows.Forms.ComboBox cbxAlicuotaIVA3;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblPerRetGanancias;
        private System.Windows.Forms.Label lblPerRetIVA;
        private System.Windows.Forms.Label lblImpuestosMunicipales;
        private System.Windows.Forms.Label lblImpuestosInternos;
        private System.Windows.Forms.Label lblPerRetIngresosBrutos;
        private System.Windows.Forms.TextBox txtPerRetIVA_Importe;
        private System.Windows.Forms.TextBox txtPerRetIVA_Alicuota;
        private System.Windows.Forms.TextBox txtPerRetIVA_BaseImp;
        private System.Windows.Forms.TextBox txtPerRetIVA_Detalle;
        private System.Windows.Forms.TextBox txtPerRetGanancias_Importe;
        private System.Windows.Forms.TextBox txtPerRetGanancias_Alicuota;
        private System.Windows.Forms.TextBox txtPerRetGanancias_BaseImp;
        private System.Windows.Forms.TextBox txtPerRetGanancias_Detalle;
        private System.Windows.Forms.TextBox txtPerRetIngresosBrutos_Importe;
        private System.Windows.Forms.TextBox txtPerRetIngresosBrutos_Alicuota;
        private System.Windows.Forms.TextBox txtPerRetIngresosBrutos_BaseImp;
        private System.Windows.Forms.TextBox txtPerRetIngresosBrutos_Detalle;
        private System.Windows.Forms.TextBox txtImpuestosInternos_Importe;
        private System.Windows.Forms.TextBox txtImpuestosInternos_Alicuota;
        private System.Windows.Forms.TextBox txtImpuestosInternos_BaseImp;
        private System.Windows.Forms.TextBox txtImpuestosInternos_Detalle;
        private System.Windows.Forms.TextBox txtImpuestosMunicipales_Importe;
        private System.Windows.Forms.TextBox txtImpuestosMunicipales_Alicuota;
        private System.Windows.Forms.TextBox txtImpuestosMunicipales_BaseImp;
        private System.Windows.Forms.TextBox txtImpuestosMunicipales_Detalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblBaseImp;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblAlicuotaPorciento;
        private System.Windows.Forms.Label lblImporteOtrosTributos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImporteOtrosTributos;
        private System.Windows.Forms.Label lblImpNetoNoGravado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImpNetoNoGravado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImpExento;
        private System.Windows.Forms.Label lblImporteExtento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtImpNetoGravado;
        private System.Windows.Forms.Label lblImpNetoGravado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIVA27;
        private System.Windows.Forms.Label lblIVA27;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIVA21;
        private System.Windows.Forms.Label lblIVA21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIVA10;
        private System.Windows.Forms.Label lblIVA10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIVA5;
        private System.Windows.Forms.Label lblIVA5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtIVA2;
        private System.Windows.Forms.Label lblIVA25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtIVA0;
        private System.Windows.Forms.Label lblIVA0;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtImpOtrosTributos;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImpTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtImporteIVA2;
        private System.Windows.Forms.TextBox txtImporteIVA3;
        private System.Windows.Forms.TextBox txtImporteIVA1;
        private System.Windows.Forms.Label lblImporteIVA;
        private System.Windows.Forms.TextBox txtSubtotalIVA2;
        private System.Windows.Forms.TextBox txtSubtotalIVA3;
        private System.Windows.Forms.TextBox txtSubtotalIVA1;
        private System.Windows.Forms.Label lblSubtotalconIVA;
        private System.Windows.Forms.Button btnBorrar1;
        private System.Windows.Forms.Label lblBorrar;
        private System.Windows.Forms.Button btnBorrar2;
        private System.Windows.Forms.Button btnBorrar3;
        private System.Windows.Forms.Panel panel4;
    }
}
