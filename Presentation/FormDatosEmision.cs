using SimuladorFacturacion.Core.Application.Services;
using SimuladorFacturacion.Core.Domain.Interfaces.Services;
using System;
using System.Windows.Forms;

namespace SimuladorFacturacion
{
	public partial class FormDatosEmision : Form
	{
        private readonly FacturacionService _facturacionService;
        private readonly INavigationService _navigationService;
        public FormDatosEmision(FacturacionService facturacionService, INavigationService navigationService)
		{
            _facturacionService = facturacionService;
            _navigationService = navigationService;
            InitializeComponent();
            this.KeyPreview = true;
        }
		void Label1Click(object sender, EventArgs e)
		{

		}
		void CbxConceptosSelectedIndexChanged(object sender, EventArgs e)
		{

		}
		void BtnAnteriorClick(object sender, EventArgs e)
		{
            _navigationService.NavigateTo<FormPuntosVenta>();
			Hide();
		}

        bool validaciones()
        {
            if (cbxConceptos.Text.Trim() == "" || cbxConceptos.SelectedIndex < 0)
            {
                App.MostrarError("Debe seleccionar los conceptos a incluir ");
                return false;
            }
            return true;
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
		{
            if (!validaciones())
            {
                return;
            }
            /*controlar las validaciones, para ello crear una funcion que valide que el usuarios haya seleccionado un concepto
            caso contrario mostrar error (mirar como esta hecho en FormPuntosVenta)
            guardar los datos en App.DataFacturacion*/

            _facturacionService.GetBuilder()
                .GetComprobante()
                    .SetFechaEmision(dtpFechaComprobante.Value)
                    .SetConceptos(cbxConceptos.Text);
            _navigationService.NavigateTo<FormDatosReceptor>();
            Hide();
		}

        private void FormDatosEmision_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void FormDatosEmision_Load(object sender, EventArgs e)
        {
            if (cbxConceptos.Items.Count > 0)
            {
                cbxConceptos.SelectedIndex = 0;
            }
        }

        private void FormDatosEmision_KeyPress(object sender, KeyPressEventArgs e)
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
                    .SetFechaEmision(dtpFechaComprobante.Value)
                    .SetConceptos(cbxConceptos.Text);
                _navigationService.NavigateTo<FormDatosReceptor>();
                Hide();
            }
        }
    }
}


