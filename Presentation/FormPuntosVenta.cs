using SimuladorFacturacion.Core.Application.Services;
using SimuladorFacturacion.Core.Domain.Interfaces.Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimuladorFacturacion
{
	public partial class FormPuntosVenta : Form
	{
        private FacturacionService _facturacionService;
        private readonly INavigationService _navigationService;
        public FormPuntosVenta(FacturacionService facturacionService, INavigationService navigationService)
		{
            _facturacionService = facturacionService;
            _navigationService = navigationService;
            InitializeComponent();
            this.KeyPreview = true;
        }

		string separarTipoComprobante()
        {
            string seleccionado = cbxTipoComprobante.SelectedItem.ToString();

            if (seleccionado == "Factura A" || seleccionado == "Factura B" || seleccionado == "Factura T")
            {
                string tipoComprobante = seleccionado.Substring(0, 7);
                return tipoComprobante;
            }

            else if (seleccionado == "Nota de Débito A" || seleccionado == "Nota de Débito B" || seleccionado == "Nota de Débito T")
            {
                string tipoComprobante = seleccionado.Substring(0, 14);
                return tipoComprobante;
            }

            else if (seleccionado == "Nota de Crédito A" || seleccionado == "Nota de Crédito B" || seleccionado == "Nota de Crédito T")
            {
                string tipoComprobante = seleccionado.Substring(0, 15);
                return tipoComprobante;
            }

            else if (seleccionado == "Recibo A" || seleccionado == "Recibo B")
            {
                string tipoComprobante = seleccionado.Substring(0, 6);
                return tipoComprobante;
            }

            else if (seleccionado == "Factura de Crédito Electrónica MiPyMEs (FCE) A" || seleccionado == "Factura de Crédito Electrónica MiPyMEs (FCE) B")
            {
                string tipoComprobante = seleccionado.Substring(0, 44);
                return tipoComprobante;
            }

            else if (seleccionado == "Nota de Débito Electrónica MiPyMEs (FCE) A" || seleccionado == "Nota de Débito Electrónica MiPyMEs (FCE) B")
            {
                string tipoComprobante = seleccionado.Substring(0, 40);
                return tipoComprobante;
            }

            else
            {
                string tipoComprobante = seleccionado.Substring(0, 41);
                return tipoComprobante;
            }
        }
        
        string separarLetraComprobante()
        {
            string seleccionado = cbxTipoComprobante.SelectedItem.ToString();

            if (seleccionado == "Factura A" || seleccionado == "Factura B" || seleccionado == "Factura T")
            {
                string letraComprobante = seleccionado.Substring(8, 1);
                return letraComprobante;
            }

            else if (seleccionado == "Nota de Débito A" || seleccionado == "Nota de Débito B" || seleccionado == "Nota de Débito T")
            {
                string letraComprobante = seleccionado.Substring(15, 1);
                return letraComprobante;
            }

            else if (seleccionado == "Nota de Crédito A" || seleccionado == "Nota de Crédito B" || seleccionado == "Nota de Crédito T")
            {
                string letraComprobante = seleccionado.Substring(16, 1);
                return letraComprobante;
            }

            else if (seleccionado == "Recibo A" || seleccionado == "Recibo B")
            {
                string letraComprobante = seleccionado.Substring(7, 1);
                return letraComprobante;
            }

            else if (seleccionado == "Factura de Crédito Electrónica MiPyMEs (FCE) A" || seleccionado == "Factura de Crédito Electrónica MiPyMEs (FCE) B")
            {
                string letraComprobante = seleccionado.Substring(45, 1);
                return letraComprobante;
            }

            else if (seleccionado == "Nota de Débito Electrónica MiPyMEs (FCE) A" || seleccionado == "Nota de Débito Electrónica MiPyMEs (FCE) B")
            {
                string letraComprobante = seleccionado.Substring(41, 1);
                return letraComprobante;
            }

            else
            {
                string letraComprobante = seleccionado.Substring(42, 1);
                return letraComprobante;
            }
        }
        

		bool validaciones(){
			if (txtPuntosVenta.Text.Trim() == ""){
				App.MostrarError("Debe ingresar el valor de punto de venta");
				return false;
			}
			if (cbxTipoComprobante.Text.Trim() == "" || cbxTipoComprobante.SelectedIndex < 0){
				App.MostrarError("Debe seleccionar un tipo de comprobante ");
				return false;
			}
			return true;
		}
		void BtnContinuarClick(object sender, EventArgs e)
		{
			if (!validaciones()) {
				return;
			}
            _facturacionService.GetBuilder()
                .GetComprobante()
                    .SetPuntoVenta(int.Parse(txtPuntosVenta.Text))
                    .SetTipo(cbxTipoComprobante.Text)
                    .SetLetra(separarLetraComprobante())
                    .Build();
            // App.DataFacturacion.ComprobanteNoLetra = separarTipoComprobante();
            _navigationService.NavigateTo<FormDatosEmision>();
            //App.MostrarDatosEmision();
			Hide();
		}

        private void FromPuntosVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateBack();
            //App.MostrarCargarDatosEmisor();
            Hide();
        }

        private void FromPuntosVenta_Load(object sender, EventArgs e)
        {
            if (cbxTipoComprobante.Items.Count > 0)
            {
                cbxTipoComprobante.SelectedIndex = 0;
            }
        }

        private void FromPuntosVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (!validaciones())
                {
                    return;
                }
                _facturacionService.GetBuilder()
                .GetComprobante()
                    .SetPuntoVenta(int.Parse(txtPuntosVenta.Text))
                    .SetTipo(cbxTipoComprobante.Text)
                    .SetLetra(separarLetraComprobante())
                    .Build();
                /*App.DataFacturacion.PuntoVentas = txtPuntosVenta.Text;
                App.DataFacturacion.TipoComprobante = cbxTipoComprobante.Text;
                App.DataFacturacion.ComprobanteNoLetra = separarTipoComprobante();
                App.DataFacturacion.LetraComprobante = separarLetraComprobante();

                App.MostrarDatosEmision();*/
                _navigationService.NavigateTo<FormDatosEmision>();
                Hide();
            }
        }
    }
}
