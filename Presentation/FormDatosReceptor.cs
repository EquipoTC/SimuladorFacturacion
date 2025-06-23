using SimuladorFacturacion.Core.Application.Services;
using SimuladorFacturacion.Core.Domain.Interfaces.Services;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimuladorFacturacion
{
	public partial class FormDatosReceptor : Form
	{
        private readonly FacturacionService _facturacionService;
        private readonly INavigationService _navigationService;
        public FormDatosReceptor(FacturacionService facturacionService, INavigationService navigationService)
		{
            _facturacionService = facturacionService;
            _navigationService = navigationService;
            InitializeComponent();
            txtCuit.MaxLength = 11;
            this.KeyPreview = true;
        }
		void FormDatosReceptorLoad(object sender, EventArgs e)
		{
            if (cbxCondicionIVA.Items.Count > 0)
            {
                cbxCondicionIVA.SelectedIndex = 0;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateBack();
			Hide();
        }
        bool validaciones()
        {
            if (cbxCondicionIVA.Text.Trim() == "" || cbxCondicionIVA.SelectedIndex < 0)
            {
                App.MostrarError("Debe seleccionar la condicion frente al IVA ");
                return false;
            }
            if (txtCuit.Text.Trim() == "")
            {
                App.MostrarError("Debe ingresar el CUIT");
                return false;
            }
            if (txtRazonSocial.Text.Trim() == "")
            {
                App.MostrarError("Debe ingresar la razon social");
                return false;
            }
            if (txtDomicilioComercial.Text.Trim() == "")
            {
                App.MostrarError("Debe ingresar el domicilio comercial");
                return false;
            }
            if (ckbCondicionesVenta.SelectedIndex < 0)
            {
                App.MostrarError("Debe seleccionar una condicion de venta ");
                return false;
            }
            return true;
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //controlar que se hayan ingresado todos los datos a excepcion del email, y que al menos se haya seleccionado 1 condicion de venta

            //guardar los datos en App.DataFacturacion
            if (!validaciones())
            {
                return;
            }
            _facturacionService.GetBuilder()
                .GetReceptor()
                    .SetRazonSocial(txtRazonSocial.Text)
                    .SetCUIT(txtCuit.Text)
                    .SetDomicilio(txtDomicilioComercial.Text)
                    .SetCondicionIVA(cbxCondicionIVA.Text)
                    .SetEmail(txtEmail.Text)
                    .Build();

            string opcionesSeleccionadas = "";

            foreach (object item in ckbCondicionesVenta.CheckedItems)
            {
                opcionesSeleccionadas += item.ToString() + ", ";
            }

            if (opcionesSeleccionadas.Length > 0)
            {
                opcionesSeleccionadas = opcionesSeleccionadas.Substring(0, opcionesSeleccionadas.Length - 2);
            }
            _facturacionService.GetBuilder().GetComprobante()
                .SetCondicionesVenta(opcionesSeleccionadas.ToString());
            _navigationService.NavigateTo<FormDatosOperacion>();
			Hide();
        }

        private void ckbCondicionesVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDomicilioComercial_Click(object sender, EventArgs e)
        {

        }

        private void FormDatosReceptor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDatosReceptor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (!validaciones())
                {
                    return;
                }
                _facturacionService.GetBuilder()
               .GetReceptor()
                   .SetRazonSocial(txtRazonSocial.Text)
                   .SetCUIT(txtCuit.Text)
                   .SetDomicilio(txtDomicilioComercial.Text)
                   .SetCondicionIVA(cbxCondicionIVA.Text)
                   .SetEmail(txtEmail.Text)
                   .Build();

                string opcionesSeleccionadas = "";

                foreach (object item in ckbCondicionesVenta.CheckedItems)
                {
                    opcionesSeleccionadas += item.ToString() + ", ";
                }

                if (opcionesSeleccionadas.Length > 0)
                {
                    opcionesSeleccionadas = opcionesSeleccionadas.Substring(0, opcionesSeleccionadas.Length - 2);
                }
                _facturacionService.GetBuilder().GetComprobante()
                .SetCondicionesVenta(opcionesSeleccionadas.ToString());
                _navigationService.NavigateTo<FormDatosOperacion>();
                Hide();
            }
        }
    }
}
