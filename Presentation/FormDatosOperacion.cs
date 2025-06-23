using SimuladorFacturacion.Core.Application.Services;
using SimuladorFacturacion.Core.Domain.Interfaces.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimuladorFacturacion
{
	public partial class FormDatosOperacion : Form
	{
        private readonly FacturacionService _facturacionService;
        private readonly INavigationService _navigationService;
        double totalTotalizadores = 0;
        public FormDatosOperacion(FacturacionService facturacionService, INavigationService navigationService)
		{
            _facturacionService = facturacionService;
            _navigationService = navigationService;
            InitializeComponent();
            txtImporteIVA1.Text = "0";
            txtImporteIVA2.Text = "0";
            txtImporteIVA3.Text = "0";
            txtPorcentajeBon1.Text = "0";
            txtPorcentajeBon2.Text = "0";
            txtPorcentajeBon3.Text = "0";
            cbxAlicuotaIVA1.SelectedIndex = 2;
            cbxAlicuotaIVA2.SelectedIndex = 2;
            cbxAlicuotaIVA3.SelectedIndex = 2;
            txtImpOtrosTributos.Text = "0";
        }
		void FormDatosOperacionLoad(object sender, EventArgs e)
		{
            this.KeyPreview = true;
        }
		bool validaciones()
		{
			if (txtCodigo1.Text.Trim() != "" || txtProductoServicio1.Text.Trim() != "" || txtCant1.Text.Trim() != "" || cbxUmedida1.Text.Trim() != "" || cbxUmedida1.SelectedIndex < 0 || txtPrecUnitario1.Text.Trim() != "" || txtPorcentajeBon1.Text.Trim() != "0" || txtImporteBon1.Text.Trim() != "0" || txtSubtotal1.Text.Trim() != "0" || cbxAlicuotaIVA1.Text.Trim() != "0" || cbxAlicuotaIVA1.SelectedIndex != 2)
			{
				if (txtCodigo1.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el codigo (Fila 1)");
					return false;
				}
				else if (txtProductoServicio1.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el producto o servicio (Fila 1)");
					return false;
				}
				else if (txtCant1.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar la cantidad (Fila 1)");
					return false;
				}
				else if (cbxUmedida1.Text.Trim() == "" || cbxUmedida1.SelectedIndex < 0)
				{
					App.MostrarError("Debe seleccionar la unidad de medida (Fila 1)");
					return false;
				}
				else if (txtPrecUnitario1.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el precio unitario (Fila 1)");
					return false;
				}
				//cambiar mensaje de error
				else if (txtPorcentajeBon1.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el porcentaje bonificacion (Fila 1)");
					return false;
				}
				else if (txtImporteBon1.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el importe bonificacion (Fila 1)");
					return false;
				}
				else if (txtSubtotal1.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el precio unitario (Fila 1)");
					return false;
				}
				else if (cbxAlicuotaIVA1.Text.Trim() == "" || cbxAlicuotaIVA1.SelectedIndex < 0)
				{
					App.MostrarError("Debe seleccionar la alicuota IVA (Fila 1)");
					return false;
				}
			}

			if (txtCodigo2.Text.Trim() == "" && txtProductoServicio2.Text.Trim() == "" && txtCant2.Text.Trim() == "" && (cbxUmedida2.Text.Trim() == "" || cbxUmedida2.SelectedIndex <= 0) && txtPrecUnitario2.Text.Trim() == "" && txtPorcentajeBon2.Text.Trim() == "0" && txtImporteBon2.Text.Trim() == "0" && txtSubtotal2.Text.Trim() == "0" && (cbxAlicuotaIVA2.Text.Trim() == "0" || cbxAlicuotaIVA2.SelectedIndex == 2) && txtCodigo3.Text.Trim() == "" && txtProductoServicio3.Text.Trim() == "" && txtCant3.Text.Trim() == "" && (cbxUmedida3.Text.Trim() == "" || cbxUmedida3.SelectedIndex < 0) && txtPrecUnitario3.Text.Trim() == "" && txtPorcentajeBon3.Text.Trim() == "0" && txtImporteBon3.Text.Trim() == "0" && txtSubtotal3.Text.Trim() == "0" && (cbxAlicuotaIVA3.Text.Trim() == "0" || cbxAlicuotaIVA3.SelectedIndex == 2))
			{
				return true;
			}

			if (txtCodigo2.Text.Trim() != "" || txtProductoServicio2.Text.Trim() != "" || txtCant2.Text.Trim() != "" || cbxUmedida2.Text.Trim() != "" || cbxUmedida2.SelectedIndex >= 0 || txtPrecUnitario2.Text.Trim() != "" || txtPorcentajeBon2.Text.Trim() != "0" || txtImporteBon2.Text.Trim() != "0" || txtSubtotal2.Text.Trim() != "0" || cbxAlicuotaIVA2.Text.Trim() != "0" || cbxAlicuotaIVA2.SelectedIndex !=2)
			{
				if (txtCodigo2.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el codigo (Fila 2)");
					return false;
				}
				else if (txtProductoServicio2.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el producto o servicio (Fila 2)");
					return false;
				}
				else if (txtCant2.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar la cantidad (Fila 2)");
					return false;
				}
				else if (cbxUmedida2.Text.Trim() == "" || cbxUmedida2.SelectedIndex < 0)
				{
					App.MostrarError("Debe seleccionar la unidad de medida (Fila 2)");
					return false;
				}
				else if (txtPrecUnitario2.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el precio unitario (Fila 2)");
					return false;
				}
				else if (txtPorcentajeBon2.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el porcentaje bonificacion (Fila 2)");
					return false;
				}
				else if (txtImporteBon2.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el importe bonificacion (Fila 2)");
					return false;
				}
				else if (txtSubtotal2.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el precio unitario (Fila 2)");
					return false;
				}
				else if (cbxAlicuotaIVA2.Text.Trim() == "" || cbxAlicuotaIVA2.SelectedIndex < 0)
				{
					App.MostrarError("Debe seleccionar la alicuota IVA (Fila 2)");
					return false;
				}
			}
			if (txtCodigo3.Text.Trim() == "" && txtProductoServicio3.Text.Trim() == "" && txtCant3.Text.Trim() == "" && (cbxUmedida3.Text.Trim() == "" || cbxUmedida3.SelectedIndex < 0) && txtPrecUnitario3.Text.Trim() == "" && txtPorcentajeBon3.Text.Trim() == "0" && txtImporteBon3.Text.Trim() == "0" && txtSubtotal3.Text.Trim() == "0" && (cbxAlicuotaIVA3.Text.Trim() == "0" || cbxAlicuotaIVA3.SelectedIndex == 2))
			{
				return true;
			}

			if (txtCodigo3.Text.Trim() != "" || txtProductoServicio3.Text.Trim() != "" || txtCant3.Text.Trim() != "" || cbxUmedida3.Text.Trim() != "" || cbxUmedida3.SelectedIndex >= 0 || txtPrecUnitario3.Text.Trim() != "" || txtPorcentajeBon3.Text.Trim() != "0" || txtImporteBon3.Text.Trim() != "0" || txtSubtotal3.Text.Trim() != "0" || cbxAlicuotaIVA3.Text.Trim() != "0" || cbxAlicuotaIVA3.SelectedIndex != 2)
			{
				if (txtCodigo3.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el codigo (Fila 3)");
					return false;
				}
				else if (txtProductoServicio3.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el producto o servicio (Fila 3)");
					return false;
				}
				else if (txtCant3.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar la cantidad (Fila 3)");
					return false;
				}
				else if (cbxUmedida3.Text.Trim() == "" || cbxUmedida3.SelectedIndex < 0)
				{
					App.MostrarError("Debe seleccionar la unidad de medida (Fila 3)");
					return false;
				}
				else if (txtPrecUnitario3.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el precio unitario (Fila 3)");
					return false;
				}
				else if (txtPorcentajeBon3.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el porcentaje bonificacion (Fila 3)");
					return false;
				}
				else if (txtImporteBon3.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el importe bonificacion (Fila 3)");
					return false;
				}
				else if (txtSubtotal3.Text.Trim() == "")
				{
					App.MostrarError("Debe ingresar el precio unitario (Fila 3)");
					return false;
				}
				else if (cbxAlicuotaIVA3.Text.Trim() == "" || cbxAlicuotaIVA3.SelectedIndex < 0)
				{
					App.MostrarError("Debe seleccionar la alicuota IVA (Fila 3)");
					return false;
				}
			}
			return true;
		}

		private void btnSiguiente_Click(object sender, EventArgs e)
		{
			if (!validaciones())
			{
				return;
			}
			cargarData();
            _facturacionService.GetBuilder()
                .GetImporte()
                    .SetOtrosTributos(decimal.Parse(txtImpOtrosTributos.Text))
                    .SetNetoGravado(decimal.Parse(txtImpNetoGravado.Text))
                    .SetIVA27(decimal.Parse(txtIVA27.Text))
                    .SetIVA21(decimal.Parse(txtIVA21.Text))
                    .SetIVA10(decimal.Parse(txtIVA10.Text))
                    .SetIVA5(decimal.Parse(txtIVA5.Text))
                    .SetIVA2(decimal.Parse(txtIVA2.Text))
                    .SetIVA0(decimal.Parse(txtIVA0.Text))
                    .SetOtrosTributos(decimal.Parse(txtImpOtrosTributos.Text))
                    .SetNetoGravado(decimal.Parse(txtImpNetoGravado.Text))
                    .Build();
            _navigationService.NavigateTo<FormImpresion>();
            Hide();


            //Renglon 1
            /*			App.DataRenglon.Codigo1 = txtCodigo1.Text;
                        App.DataRenglon.ProductoServicio1 = txtProductoServicio1.Text;
                        App.DataRenglon.Cantidad1 = txtCant1.Text;
                        App.DataRenglon.UnidadMedida1 = cbxUmedida1.Text;
                        App.DataRenglon.PrecioUnitario1 = txtPrecUnitario1.Text;
                        App.DataRenglon.PorcentajeBon1 = txtPorcentajeBon1.Text;
                        App.DataRenglon.ImporteBon1 = txtImporteBon1.Text;
                        App.DataRenglon.Subtotal1 = txtSubtotal1.Text;
                        App.DataRenglon.AlicuotaIVA1 = cbxAlicuotaIVA1.Text;
                        App.DataRenglon.ImporteIVA1 = txtImporteIVA1.Text;
                        App.DataRenglon.SubtotalconIVA1 = txtSubtotalIVA1.Text;
                        //Renglon 2
                        App.DataRenglon.Codigo2 = txtCodigo2.Text;
                        App.DataRenglon.ProductoServicio2 = txtProductoServicio2.Text;
                        App.DataRenglon.Cantidad2 = txtCant2.Text;
                        App.DataRenglon.UnidadMedida2 = cbxUmedida2.Text;
                        App.DataRenglon.PrecioUnitario2 = txtPrecUnitario2.Text;
                        App.DataRenglon.PorcentajeBon2 = txtPorcentajeBon2.Text;
                        App.DataRenglon.ImporteBon2 = txtImporteBon2.Text;
                        App.DataRenglon.Subtotal2 = txtSubtotal2.Text;
                        App.DataRenglon.AlicuotaIVA2 = cbxAlicuotaIVA2.Text;
                        App.DataRenglon.ImporteIVA2 = txtImporteIVA2.Text;
                        App.DataRenglon.SubtotalconIVA2 = txtSubtotalIVA2.Text;
                        //Renglon 3
                        App.DataRenglon.Codigo3 = txtCodigo3.Text;
                        App.DataRenglon.ProductoServicio3 = txtProductoServicio3.Text;
                        App.DataRenglon.Cantidad3 = txtCant3.Text;
                        App.DataRenglon.UnidadMedida3 = cbxUmedida3.Text;
                        App.DataRenglon.PrecioUnitario3 = txtPrecUnitario3.Text;
                        App.DataRenglon.PorcentajeBon3 = txtPorcentajeBon3.Text;
                        App.DataRenglon.ImporteBon3 = txtImporteBon3.Text;
                        App.DataRenglon.Subtotal3 = txtSubtotal3.Text;
                        App.DataRenglon.AlicuotaIVA3 = cbxAlicuotaIVA3.Text;
                        App.DataRenglon.ImporteIVA3 = txtImporteIVA3.Text;
                        App.DataRenglon.SubtotalconIVA3 = txtSubtotalIVA3.Text;
            */

        }
		private void cargarData(){
            var builder = _facturacionService.GetBuilder();
            var renglon = builder.GetRenglon()
                    .SetCodigo(txtCodigo1.Text)
                    .SetProductoServicio(txtProductoServicio1.Text)
                    .SetCantidad(decimal.Parse(txtCant1.Text))
                    .SetUnidadMedida(cbxUmedida1.Text)
                    .SetPrecioUnitario(decimal.Parse(txtPrecUnitario1.Text))
                    .SetPorcentajeBonificacion(decimal.Parse(txtPorcentajeBon1.Text))
                    .SetAlicuotaIVA(decimal.Parse(cbxAlicuotaIVA1.Text))
                    .Build();
            _facturacionService.GetBuilder().AddRenglon(renglon);

            renglon = builder.GetRenglon()
                    .SetCodigo(txtCodigo2.Text)
                    .SetProductoServicio(txtProductoServicio2.Text)
                    .SetCantidad(decimal.Parse(txtCant2.Text))
                    .SetUnidadMedida(cbxUmedida2.Text)
                    .SetPrecioUnitario(decimal.Parse(txtPrecUnitario2.Text))
                    .SetPorcentajeBonificacion(decimal.Parse(txtPorcentajeBon2.Text))
                    .SetAlicuotaIVA(decimal.Parse(cbxAlicuotaIVA2.Text))
                    .Build();
            builder.AddRenglon(renglon);

            renglon = builder.GetRenglon()
                   .SetCodigo(txtCodigo3.Text)
                   .SetProductoServicio(txtProductoServicio3.Text)
                   .SetCantidad(decimal.Parse(txtCant3.Text))
                   .SetUnidadMedida(cbxUmedida3.Text)
                   .SetPrecioUnitario(decimal.Parse(txtPrecUnitario3.Text))
                   .SetPorcentajeBonificacion(decimal.Parse(txtPorcentajeBon3.Text))
                   .SetAlicuotaIVA(decimal.Parse(cbxAlicuotaIVA3.Text))
                   .Build();
            builder.AddRenglon(renglon);
        }
		
		private void calcularImportes(TextBox txtCantidad, TextBox txtPrecio, TextBox txtBonificacionPorcentaje, TextBox txtBonificacionImporte, TextBox txtSubTotal,ComboBox cbxIVAPorcentaje,TextBox txtIVA, TextBox txtTotal){
			
			//precio
			double precio  = App.StrToDouble(txtCantidad.Text) * App.StrToDouble(txtPrecio.Text);
			
			//calcular bonificacion
			double bonificacion = precio * (App.StrToDouble(txtBonificacionPorcentaje.Text) / 100);
			
			//cantidad por precio unitario mas la bonificacion
			double subtotal  = precio + bonificacion;
			
			//alicuota
			double alicuota = subtotal * (App.StrToDouble(cbxIVAPorcentaje.Text) / 100);
			
			//total
			double total  = subtotal;
			if (alicuota > 0) {
				total = alicuota + total;
			}
			
			txtBonificacionImporte.Text = bonificacion.ToString();
			txtSubTotal.Text = subtotal.ToString();
			txtIVA.Text = alicuota.ToString();
			txtTotal.Text = total.ToString();
		}
        private void btnAnterior_Click(object sender, EventArgs e)
		{
            _navigationService.NavigateBack();
			Hide();
		}

		private void btnBorrar1_Click(object sender, EventArgs e)
		{
			txtCodigo1.Text = string.Empty; 
			txtProductoServicio1.Text = string.Empty;
			txtCant1.Text = string.Empty;
			cbxUmedida1.SelectedIndex = -1;
			txtPrecUnitario1.Text = string.Empty;
            txtPorcentajeBon1.Text = "0";
			txtImporteBon1.Text = "0";
			txtSubtotal1.Text = "0";
			cbxAlicuotaIVA1.SelectedIndex = 2;
			txtImporteIVA1.Text = "0";
			txtSubtotalIVA1.Text = "0";
           
        }

		private void btnBorrar2_Click(object sender, EventArgs e)
		{
			txtCodigo2.Text = string.Empty;
			txtProductoServicio2.Text = string.Empty;
			txtCant2.Text = string.Empty;
			cbxUmedida2.SelectedIndex = -1;
			txtPrecUnitario2.Text = string.Empty;
            txtPorcentajeBon2.Text = "0";
            txtImporteBon2.Text = "0";
			txtSubtotal2.Text = "0";
			cbxAlicuotaIVA2.SelectedIndex = 2;
			txtImporteIVA2.Text = "0";
            txtSubtotalIVA2.Text = "0";
            
        }

		private void btnBorrar3_Click(object sender, EventArgs e)
		{
			txtCodigo3.Text = string.Empty;
			txtProductoServicio3.Text = string.Empty;
			txtCant3.Text = string.Empty;
			cbxUmedida3.SelectedIndex = -1;
			txtPrecUnitario3.Text = string.Empty;
			txtPorcentajeBon3.Text = "0";
			txtImporteBon3.Text = "0";
			txtSubtotal3.Text = "0";
			cbxAlicuotaIVA3.SelectedIndex = 2;
			txtImporteIVA3.Text = "0";
            txtSubtotalIVA3.Text = "0";
            
        }
		
		//esta funcion se encuentra asinada a los envento text change de cantidad, precio unitario % bonificacion y la alicuota
		void TextChangedRenglon1(object sender, EventArgs e)
		{
			calcularImportes(txtCant1, 
			                 txtPrecUnitario1, 
			                 txtPorcentajeBon1, 
			                 txtImporteBon1, 
			                 txtSubtotal1,
			                 cbxAlicuotaIVA1,
			                 txtImporteIVA1, 
			                 txtSubtotalIVA1);
		}
        void TextChangedRenglon2(object sender, EventArgs e)
        {
            calcularImportes(txtCant2,
                             txtPrecUnitario2,
                             txtPorcentajeBon2,
                             txtImporteBon2,
                             txtSubtotal2,
                             cbxAlicuotaIVA2,
                             txtImporteIVA2,
                             txtSubtotalIVA2);
        }

        void TextChangedRenglon3(object sender, EventArgs e)
        {
            calcularImportes(txtCant3,
                             txtPrecUnitario3,
                             txtPorcentajeBon3,
                             txtImporteBon3,
                             txtSubtotal3,
                             cbxAlicuotaIVA3,
                             txtImporteIVA3,
                             txtSubtotalIVA3);
        }

		void mostrarTotalizadores(object sender, EventArgs e)
		{
            txtImpNetoNoGravado.Text = "0";
            txtImpExento.Text = "0";
            txtIVA27.Text = "0";
            txtIVA21.Text = "0";
            txtIVA10.Text = "0";
            txtIVA5.Text = "0";
            txtIVA2.Text = "0";
            txtIVA0.Text = "0";

            //Totalizador No Gravado
            double totalizadorNoGravado = 0;
			totalizadorNoGravado = App.StrToDouble(txtSubtotal1.Text) + App.StrToDouble(txtSubtotal2.Text) + App.StrToDouble(txtSubtotal3.Text);
			txtImpNetoGravado.Text = totalizadorNoGravado.ToString();

            //Totalizador Importe Exento (Renglon 1)
            if (cbxAlicuotaIVA1.Text == "Exento")
            {
                double totalizadorExento = App.StrToDouble(txtImporteIVA1.Text);
                txtImpExento.Text = totalizadorExento.ToString();

                if(cbxAlicuotaIVA2.Text == cbxAlicuotaIVA1.Text)
                {
                    totalizadorExento = totalizadorExento + App.StrToDouble(txtImporteIVA2.Text);
                    txtImpExento.Text = totalizadorExento.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA1.Text)
                    {
                        totalizadorExento = totalizadorExento + App.StrToDouble(txtImporteIVA3.Text);
                        txtImpExento.Text = totalizadorExento.ToString();
                    }
                }
            }
            //Totalizador Importe Exento (Renglon 2)
            if (cbxAlicuotaIVA2.Text == "Exento")
            {
                double totalizadorExento = App.StrToDouble(txtImporteIVA2.Text);
                txtImpExento.Text = totalizadorExento.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA2.Text)
                {
                    totalizadorExento = totalizadorExento + App.StrToDouble(txtImporteIVA1.Text);
                    txtImpExento.Text = totalizadorExento.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA2.Text)
                    {
                        totalizadorExento = totalizadorExento + App.StrToDouble(txtImporteIVA3.Text);
                        txtImpExento.Text = totalizadorExento.ToString();
                    }
                }
            }
            //Totalizador Importe Exento (Renglon 3)
            if (cbxAlicuotaIVA3.Text == "Exento")
            {
                double totalizadorExento = App.StrToDouble(txtImporteIVA3.Text);
                txtImpExento.Text = totalizadorExento.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA3.Text)
                {
                    totalizadorExento = totalizadorExento + App.StrToDouble(txtImporteIVA1.Text);
                    txtImpExento.Text = totalizadorExento.ToString();

                    if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA3.Text)
                    {
                        totalizadorExento = totalizadorExento + App.StrToDouble(txtImporteIVA2.Text);
                        txtImpExento.Text = totalizadorExento.ToString();
                    }
                }
            }

            //Totalizador Importe Neto Gravado (Renglon 1)
            if(cbxAlicuotaIVA1.Text == "No gravado")
            {
                double totalizadorGravado = App.StrToDouble(txtImporteIVA1.Text);
                txtImpNetoGravado.Text = totalizadorGravado.ToString();

                if(cbxAlicuotaIVA2.Text == cbxAlicuotaIVA1.Text)
                {
                    totalizadorGravado = totalizadorGravado + App.StrToDouble(txtImporteIVA2.Text);
                    txtImpNetoGravado.Text = totalizadorGravado.ToString();

                    if(cbxAlicuotaIVA3.Text == cbxAlicuotaIVA1.Text)
                    {
                        totalizadorGravado = totalizadorGravado + App.StrToDouble(txtImporteIVA3.Text);
                        txtImpNetoGravado.Text = totalizadorGravado.ToString();
                    }
                }
            }
            //Totalizador importe neto gravado (renglon 2)
            if (cbxAlicuotaIVA2.Text == "No gravado")
            {
                double totalizadorGravado = App.StrToDouble(txtImporteIVA2.Text);
                txtImpNetoGravado.Text = totalizadorGravado.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA2.Text)
                {
                    totalizadorGravado = totalizadorGravado + App.StrToDouble(txtImporteIVA1.Text);
                    txtImpNetoGravado.Text = totalizadorGravado.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA2.Text)
                    {
                        totalizadorGravado = totalizadorGravado + App.StrToDouble(txtImporteIVA3.Text);
                        txtImpNetoGravado.Text = totalizadorGravado.ToString();
                    }
                }
            }
            //Totalizador importe neto gravado (renglon 3)
            if (cbxAlicuotaIVA3.Text == "No gravado")
            {
                double totalizadorGravado = App.StrToDouble(txtImporteIVA3.Text);
                txtImpNetoGravado.Text = totalizadorGravado.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA3.Text)
                {
                    totalizadorGravado = totalizadorGravado + App.StrToDouble(txtImporteIVA1.Text);
                    txtImpNetoGravado.Text = totalizadorGravado.ToString();

                    if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA3.Text)
                    {
                        totalizadorGravado = totalizadorGravado + App.StrToDouble(txtImporteIVA2.Text);
                        txtImpNetoGravado.Text = totalizadorGravado.ToString();
                    }
                }
            }

            //
            //Totalizador IVA 27%
            if (cbxAlicuotaIVA1.Text == "27")
			{
				double totalizadorIVA27 = App.StrToDouble(txtImporteIVA1.Text);
				txtIVA27.Text = totalizadorIVA27.ToString();

				if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA1.Text)
				{
					totalizadorIVA27 = totalizadorIVA27 + App.StrToDouble(txtImporteIVA2.Text);
					txtIVA27.Text = totalizadorIVA27.ToString();

					if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA1.Text)
					{
						totalizadorIVA27 = totalizadorIVA27 + App.StrToDouble(txtImporteIVA3.Text);
						txtIVA27.Text = totalizadorIVA27.ToString();
					}
				}
			}
            //Totalizador IVA 21%
            if (cbxAlicuotaIVA1.Text == "21")
            {
                double totalizadorIVA21 = App.StrToDouble(txtImporteIVA1.Text);
                txtIVA21.Text = totalizadorIVA21.ToString();

                if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA1.Text)
                {
                    totalizadorIVA21 = totalizadorIVA21 + App.StrToDouble(txtImporteIVA2.Text);
                    txtIVA21.Text = totalizadorIVA21.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA1.Text)
                    {
                        totalizadorIVA21 = totalizadorIVA21 + App.StrToDouble(txtImporteIVA3.Text);
                        txtIVA21.Text = totalizadorIVA21.ToString();
                    }
                }
            }
            //Totalizador IVA 10,5%
            if (cbxAlicuotaIVA1.Text == "10,5")
            {
                double totalizadorIVA10_5 = App.StrToDouble(txtImporteIVA1.Text);
                txtIVA10.Text = totalizadorIVA10_5.ToString();

                if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA1.Text)
                {
                    totalizadorIVA10_5 = totalizadorIVA10_5 + App.StrToDouble(txtImporteIVA2.Text);
                    txtIVA10.Text = totalizadorIVA10_5.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA1.Text)
                    {
                        totalizadorIVA10_5 = totalizadorIVA10_5 + App.StrToDouble(txtImporteIVA3.Text);
                        txtIVA10.Text = totalizadorIVA10_5.ToString();
                    }
                }
            }
            //Totalizador IVA 5%
            if (cbxAlicuotaIVA1.Text == "5")
            {
                double totalizadorIVA5 = App.StrToDouble(txtImporteIVA1.Text);
                txtIVA5.Text = totalizadorIVA5.ToString();

                if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA1.Text)
                {
                    totalizadorIVA5 = totalizadorIVA5 + App.StrToDouble(txtImporteIVA2.Text);
                    txtIVA5.Text = totalizadorIVA5.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA1.Text)
                    {
                        totalizadorIVA5 = totalizadorIVA5 + App.StrToDouble(txtImporteIVA3.Text);
                        txtIVA5.Text = totalizadorIVA5.ToString();
                    }
                }
            }
            //Totalizador IVA 2,5%
            if (cbxAlicuotaIVA1.Text == "2,5")
            {
                double totalizadorIVA2_5 = App.StrToDouble(txtImporteIVA1.Text);
                txtIVA2.Text = totalizadorIVA2_5.ToString();

                if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA1.Text)
                {
                    totalizadorIVA2_5 = totalizadorIVA2_5 + App.StrToDouble(txtImporteIVA2.Text);
                    txtIVA2.Text = totalizadorIVA2_5.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA1.Text)
                    {
                        totalizadorIVA2_5 = totalizadorIVA2_5 + App.StrToDouble(txtImporteIVA3.Text);
                        txtIVA2.Text = totalizadorIVA2_5.ToString();
                    }
                }
            }
            //Totalizador IVA 0%
            if (cbxAlicuotaIVA1.Text == "0")
            {
                double totalizadorIVA0 = App.StrToDouble(txtImporteIVA1.Text);
                txtIVA0.Text = totalizadorIVA0.ToString();

                if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA1.Text)
                {
                    totalizadorIVA0 = totalizadorIVA0 + App.StrToDouble(txtImporteIVA2.Text);
                    txtIVA0.Text = totalizadorIVA0.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA1.Text)
                    {
                        totalizadorIVA0 = totalizadorIVA0 + App.StrToDouble(txtImporteIVA3.Text);
                        txtIVA0.Text = totalizadorIVA0.ToString();
                    }
                }
            }

            //
            //Totalizador IVA 27%
            if (cbxAlicuotaIVA2.Text == "27")
            {
                double totalizadorIVA27 = App.StrToDouble(txtImporteIVA2.Text);
                txtIVA27.Text = totalizadorIVA27.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA2.Text)
                {
                    totalizadorIVA27 = totalizadorIVA27 + App.StrToDouble(txtImporteIVA1.Text);
                    txtIVA27.Text = totalizadorIVA27.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA2.Text)
                    {
                        totalizadorIVA27 = totalizadorIVA27 + App.StrToDouble(txtImporteIVA3.Text);
                        txtIVA27.Text = totalizadorIVA27.ToString();
                    }
                }
            }
            //Totalizador IVA 21%
            if (cbxAlicuotaIVA2.Text == "21")
            {
                double totalizadorIVA21 = App.StrToDouble(txtImporteIVA2.Text);
                txtIVA21.Text = totalizadorIVA21.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA2.Text)
                {
                    totalizadorIVA21 = totalizadorIVA21 + App.StrToDouble(txtImporteIVA1.Text);
                    txtIVA21.Text = totalizadorIVA21.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA2.Text)
                    {
                        totalizadorIVA21 = totalizadorIVA21 + App.StrToDouble(txtImporteIVA3.Text);
                        txtIVA21.Text = totalizadorIVA21.ToString();
                    }
                }
            }
            //Totalizador IVA 10,5%
            if (cbxAlicuotaIVA2.Text == "10,5")
            {
                double totalizadorIVA10_5 = App.StrToDouble(txtImporteIVA2.Text);
                txtIVA10.Text = totalizadorIVA10_5.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA2.Text)
                {
                    totalizadorIVA10_5 = totalizadorIVA10_5 + App.StrToDouble(txtImporteIVA1.Text);
                    txtIVA10.Text = totalizadorIVA10_5.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA2.Text)
                    {
                        totalizadorIVA10_5 = totalizadorIVA10_5 + App.StrToDouble(txtImporteIVA3.Text);
                        txtIVA10.Text = totalizadorIVA10_5.ToString();
                    }
                }
            }
            //Totalizador IVA 5%
            if (cbxAlicuotaIVA2.Text == "5")
            {
                double totalizadorIVA5 = App.StrToDouble(txtImporteIVA2.Text);
                txtIVA5.Text = totalizadorIVA5.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA2.Text)
                {
                    totalizadorIVA5 = totalizadorIVA5 + App.StrToDouble(txtImporteIVA1.Text);
                    txtIVA5.Text = totalizadorIVA5.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA2.Text)
                    {
                        totalizadorIVA5 = totalizadorIVA5 + App.StrToDouble(txtImporteIVA3.Text);
                        txtIVA5.Text = totalizadorIVA5.ToString();
                    }
                }
            }
            //Totalizador IVA 2,5%
            if (cbxAlicuotaIVA2.Text == "2,5")
            {
                double totalizadorIVA2_5 = App.StrToDouble(txtImporteIVA2.Text);
                txtIVA2.Text = totalizadorIVA2_5.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA2.Text)
                {
                    totalizadorIVA2_5 = totalizadorIVA2_5 + App.StrToDouble(txtImporteIVA1.Text);
                    txtIVA2.Text = totalizadorIVA2_5.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA2.Text)
                    {
                        totalizadorIVA2_5 = totalizadorIVA2_5 + App.StrToDouble(txtImporteIVA3.Text);
                        txtIVA2.Text = totalizadorIVA2_5.ToString();
                    }
                }
            }
            //Totalizador IVA 0%
            if (cbxAlicuotaIVA2.Text == "0")
            {
                double totalizadorIVA0 = App.StrToDouble(txtImporteIVA2.Text);
                txtIVA0.Text = totalizadorIVA0.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA2.Text)
                {
                    totalizadorIVA0 = totalizadorIVA0 + App.StrToDouble(txtImporteIVA1.Text);
                    txtIVA0.Text = totalizadorIVA0.ToString();

                    if (cbxAlicuotaIVA3.Text == cbxAlicuotaIVA2.Text)
                    {
                        totalizadorIVA0 = totalizadorIVA0 + App.StrToDouble(txtImporteIVA3.Text);
                        txtIVA0.Text = totalizadorIVA0.ToString();
                    }
                }
            }
            
            //
            //Totalizador IVA 27%
            if (cbxAlicuotaIVA3.Text == "27")
            {
                double totalizadorIVA27 = App.StrToDouble(txtImporteIVA3.Text);
                txtIVA27.Text = totalizadorIVA27.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA3.Text)
                {
                    totalizadorIVA27 = totalizadorIVA27 + App.StrToDouble(txtImporteIVA1.Text);
                    txtIVA27.Text = totalizadorIVA27.ToString();

                    if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA3.Text)
                    {
                        totalizadorIVA27 = totalizadorIVA27 + App.StrToDouble(txtImporteIVA2.Text);
                        txtIVA27.Text = totalizadorIVA27.ToString();
                    }
                }
            }
            //Totalizador IVA 21%
            if (cbxAlicuotaIVA3.Text == "21")
            {
                double totalizadorIVA21 = App.StrToDouble(txtImporteIVA3.Text);
                txtIVA21.Text = totalizadorIVA21.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA3.Text)
                {
                    totalizadorIVA21 = totalizadorIVA21 + App.StrToDouble(txtImporteIVA1.Text);
                    txtIVA21.Text = totalizadorIVA21.ToString();

                    if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA3.Text)
                    {
                        totalizadorIVA21 = totalizadorIVA21 + App.StrToDouble(txtImporteIVA2.Text);
                        txtIVA21.Text = totalizadorIVA21.ToString();
                    }
                }
            }
            //Totalizador IVA 10,5%
            if (cbxAlicuotaIVA3.Text == "10,5")
            {
                double totalizadorIVA10_5 = App.StrToDouble(txtImporteIVA3.Text);
                txtIVA10.Text = totalizadorIVA10_5.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA3.Text)
                {
                    totalizadorIVA10_5 = totalizadorIVA10_5 + App.StrToDouble(txtImporteIVA1.Text);
                    txtIVA10.Text = totalizadorIVA10_5.ToString();

                    if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA3.Text)
                    {
                        totalizadorIVA10_5 = totalizadorIVA10_5 + App.StrToDouble(txtImporteIVA2.Text);
                        txtIVA10.Text = totalizadorIVA10_5.ToString();
                    }
                }
            }
            //Totalizador IVA 5%
            if (cbxAlicuotaIVA3.Text == "5")
            {
                double totalizadorIVA5 = App.StrToDouble(txtImporteIVA3.Text);
                txtIVA5.Text = totalizadorIVA5.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA3.Text)
                {
                    totalizadorIVA5 = totalizadorIVA5 + App.StrToDouble(txtImporteIVA1.Text);
                    txtIVA5.Text = totalizadorIVA5.ToString();

                    if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA3.Text)
                    {
                        totalizadorIVA5 = totalizadorIVA5 + App.StrToDouble(txtImporteIVA2.Text);
                        txtIVA5.Text = totalizadorIVA5.ToString();
                    }
                }
            }
            //Totalizador IVA 2,5%
            if (cbxAlicuotaIVA3.Text == "2,5")
            {
                double totalizadorIVA2_5 = App.StrToDouble(txtImporteIVA3.Text);
                txtIVA2.Text = totalizadorIVA2_5.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA3.Text)
                {
                    totalizadorIVA2_5 = totalizadorIVA2_5 + App.StrToDouble(txtImporteIVA1.Text);
                    txtIVA2.Text = totalizadorIVA2_5.ToString();

                    if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA3.Text)
                    {
                        totalizadorIVA2_5 = totalizadorIVA2_5 + App.StrToDouble(txtImporteIVA2.Text);
                        txtIVA2.Text = totalizadorIVA2_5.ToString();
                    }
                }
            }
            //Totalizador IVA 0%
            if (cbxAlicuotaIVA3.Text == "0")
            {
                double totalizadorIVA0 = App.StrToDouble(txtImporteIVA3.Text);
                txtIVA0.Text = totalizadorIVA0.ToString();

                if (cbxAlicuotaIVA1.Text == cbxAlicuotaIVA3.Text)
                {
                    totalizadorIVA0 = totalizadorIVA0 + App.StrToDouble(txtImporteIVA1.Text);
                    txtIVA0.Text = totalizadorIVA0.ToString();

                    if (cbxAlicuotaIVA2.Text == cbxAlicuotaIVA3.Text)
                    {
                        totalizadorIVA0 = totalizadorIVA0 + App.StrToDouble(txtImporteIVA2.Text);
                        txtIVA0.Text = totalizadorIVA0.ToString();
                    }
                }
            }
            totalTotalizadores = App.StrToDouble(txtIVA27.Text) + App.StrToDouble(txtIVA21.Text) + App.StrToDouble(txtIVA10.Text) + App.StrToDouble(txtIVA5.Text) + App.StrToDouble(txtIVA2.Text) + App.StrToDouble(txtIVA0.Text) + App.StrToDouble(txtImpNetoNoGravado.Text) + App.StrToDouble(txtImpExento.Text) + App.StrToDouble(txtImpNetoGravado.Text) + App.StrToDouble(txtImporteOtrosTributos.Text);
            txtImpTotal.Text = totalTotalizadores.ToString();
        }

        void calcularImporteOtrosTributos(object sender, EventArgs e)
        {
            

            //Calcular Per./Ret. de Imp. a las Ganancias
            double alicuotaPorciento = App.StrToDouble(txtPerRetGanancias_BaseImp.Text) * ((App.StrToDouble(txtPerRetGanancias_Alicuota.Text) / 100));
            double Total_PerRetGanancias = App.StrToDouble(txtPerRetGanancias_BaseImp.Text) + alicuotaPorciento;
            txtPerRetGanancias_Importe.Text = Total_PerRetGanancias.ToString();

            //Calcular Per./Ret. IVA
            alicuotaPorciento = App.StrToDouble(txtPerRetIVA_BaseImp.Text) * ((App.StrToDouble(txtPerRetIVA_Alicuota.Text) / 100));
            double Total_PerRetIVA = App.StrToDouble(txtPerRetIVA_BaseImp.Text) + alicuotaPorciento;
            txtPerRetIVA_Importe.Text = Total_PerRetIVA.ToString();

            //Calcular Per./Ret. Ingresos Brutos
            alicuotaPorciento = App.StrToDouble(txtPerRetIngresosBrutos_BaseImp.Text) * ((App.StrToDouble(txtPerRetIngresosBrutos_Alicuota.Text) / 100));
            double Total_PerRetIngresosBrutos = App.StrToDouble(txtPerRetIngresosBrutos_BaseImp.Text) + alicuotaPorciento;
            txtPerRetIngresosBrutos_Importe.Text = Total_PerRetIngresosBrutos.ToString();

            //Calcular Impuestos Internos
            alicuotaPorciento = App.StrToDouble(txtImpuestosInternos_BaseImp.Text) * ((App.StrToDouble(txtImpuestosInternos_Alicuota.Text) / 100));
            double Total_ImpuestosInternos = App.StrToDouble(txtImpuestosInternos_BaseImp.Text) + alicuotaPorciento;
            txtImpuestosInternos_Importe.Text = Total_ImpuestosInternos.ToString();

            //Calcular Impuestos Municipales
            alicuotaPorciento = App.StrToDouble(txtImpuestosMunicipales_BaseImp.Text) * ((App.StrToDouble(txtImpuestosMunicipales_Alicuota.Text) / 100));
            double Total_ImpuestosMunicipales = App.StrToDouble(txtImpuestosMunicipales_BaseImp.Text) + alicuotaPorciento;
            txtImpuestosMunicipales_Importe.Text = Total_ImpuestosMunicipales.ToString();

            //Mostrar total Importe Otros Tributos
            double Total_ImporteOtrosTributos = Total_PerRetGanancias + Total_PerRetIVA + Total_PerRetIngresosBrutos + Total_ImpuestosInternos + Total_ImpuestosMunicipales;
            txtImporteOtrosTributos.Text = Total_ImporteOtrosTributos.ToString();

            txtImpOtrosTributos.Text = txtImporteOtrosTributos.Text;
            totalTotalizadores = App.StrToDouble(txtIVA27.Text) + App.StrToDouble(txtIVA21.Text) + App.StrToDouble(txtIVA10.Text) + App.StrToDouble(txtIVA5.Text) + App.StrToDouble(txtIVA2.Text) + App.StrToDouble(txtIVA0.Text) + App.StrToDouble(txtImpNetoNoGravado.Text) + App.StrToDouble(txtImpExento.Text) + App.StrToDouble(txtImpNetoGravado.Text) + App.StrToDouble(txtImporteOtrosTributos.Text);
            txtImpTotal.Text = totalTotalizadores.ToString();
        }

        private void FormDatosOperacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void FormDatosOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (!validaciones())
                {
                    return;
                }

                cargarData();
                _facturacionService.GetBuilder()
                .GetImporte()
                    .SetOtrosTributos(decimal.Parse(txtImpOtrosTributos.Text))
                    .SetNetoGravado(decimal.Parse(txtImpNetoGravado.Text))
                    .SetIVA27(decimal.Parse(txtIVA27.Text))
                    .SetIVA21(decimal.Parse(txtIVA21.Text))
                    .SetIVA10(decimal.Parse(txtIVA10.Text))
                    .SetIVA5(decimal.Parse(txtIVA5.Text))
                    .SetIVA2(decimal.Parse(txtIVA2.Text))
                    .SetIVA0(decimal.Parse(txtIVA0.Text))
                    .SetOtrosTributos(decimal.Parse(txtImpOtrosTributos.Text))
                    .SetNetoGravado(decimal.Parse(txtImpNetoGravado.Text))
                    .Build();
                _navigationService.NavigateTo<FormImpresion>();
                Hide();
            }
        }
    }
}
