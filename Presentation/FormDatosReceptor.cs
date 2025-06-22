using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimuladorFacturacion
{
	/// <summary>
	/// Description of FormDatosReceptor.
	/// </summary>
	public partial class FormDatosReceptor : Form
	{
		public FormDatosReceptor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            txtCuit.MaxLength = 11;
            this.KeyPreview = true;
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
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
			App.MostrarDatosEmision();
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
            App.DataFacturacion.CondicionIVA = cbxCondicionIVA.Text;
            App.DataFacturacion.CUIT = txtCuit.Text;
            App.DataFacturacion.RazonSocial = txtRazonSocial.Text;
            App.DataFacturacion.DomicilioComercial = txtDomicilioComercial.Text;
            App.DataFacturacion.Email = txtEmail.Text;

            string opcionesSeleccionadas = "";

            foreach (object item in ckbCondicionesVenta.CheckedItems)
            {
                opcionesSeleccionadas += item.ToString() + ", ";
            }

            if (opcionesSeleccionadas.Length > 0)
            {
                opcionesSeleccionadas = opcionesSeleccionadas.Substring(0, opcionesSeleccionadas.Length - 2);
            }

            string condicionesVenta = opcionesSeleccionadas.ToString();

            App.DataFacturacion.CondicionesVenta = condicionesVenta;

            App.MostrarDatosOperacion();
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
                App.DataFacturacion.CondicionIVA = cbxCondicionIVA.Text;
                App.DataFacturacion.CUIT = txtCuit.Text;
                App.DataFacturacion.RazonSocial = txtRazonSocial.Text;
                App.DataFacturacion.DomicilioComercial = txtDomicilioComercial.Text;
                App.DataFacturacion.Email = txtEmail.Text;

                string opcionesSeleccionadas = "";

                foreach (object item in ckbCondicionesVenta.CheckedItems)
                {
                    opcionesSeleccionadas += item.ToString() + ", ";
                }

                if (opcionesSeleccionadas.Length > 0)
                {
                    opcionesSeleccionadas = opcionesSeleccionadas.Substring(0, opcionesSeleccionadas.Length - 2);
                }

                string condicionesVenta = opcionesSeleccionadas.ToString();

                App.DataFacturacion.CondicionesVenta = condicionesVenta;

                App.MostrarDatosOperacion();
                Hide();
            }
        }
    }
}
