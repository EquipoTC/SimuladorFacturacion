using SimuladorFacturacion.Core.Application.Services;
using SimuladorFacturacion.Core.Domain.Interfaces.Services;
using System;
using System.Windows.Forms;

namespace SimuladorFacturacion
{
    public partial class FormCargarDatosEmisor : Form
    {
        private FacturacionService _facturacionService;
        private readonly INavigationService _navigationService;
        public FormCargarDatosEmisor(FacturacionService facturacionService, INavigationService navigationService)
        {
            _facturacionService = facturacionService;
            _navigationService = navigationService;
            InitializeComponent();
            this.KeyPreview = true;

            txtCuit_Emisor.MaxLength = 11;

            txtRazonSocial_Emisor.Text = "Escuela de Educación Técnica Nº1 'Áferez de Navió José María Sobral'";
            txtCuit_Emisor.Text = "12345678910";
            txtDomicilioComercial_Emisor.Text = "San Martín 1055";
            
            if (cbxCondicionIVA_Emisor.Items.Count > 0)
            {
                cbxCondicionIVA_Emisor.SelectedIndex = 0; 
            }

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                return;
            }

            string CuitConGuion = "";

            if (txtCuit_Emisor.Text.Length > 0)
            {
                for (int i = 0; i < txtCuit_Emisor.Text.Length; i++)
                {
                    if (i == 2)
                    {
                        CuitConGuion += "-";
                    }
                    if (i == 10)
                    {
                        CuitConGuion += "-";
                    }
                    CuitConGuion += txtCuit_Emisor.Text[i];
                }
            }

            _facturacionService.GetBuilder()
                .GetEmisor()
                    .SetRazonSocial(txtRazonSocial_Emisor.Text)
                    .SetCUIT(txtCuit_Emisor.Text)
                    .SetDomicilio(txtDomicilioComercial_Emisor.Text)
                    .SetCondicionIVA(cbxCondicionIVA_Emisor.Text)
                    .SetFechaInicioActividades(dtpFechaInicioActividades.Value)
                    .Build();
            /*txtRazonSocial_Emisor.Text, txtCuit_Emisor.Text,
                    txtDomicilioComercial_Emisor.Text, cbxCondicionIVA_Emisor.Text,
                    dtpFechaInicioActividades.Value);*/
            _navigationService.NavigateTo<FormPuntosVenta>();
            Hide();
        }

        //Validaciones
        bool validaciones()
        {
            if (txtRazonSocial_Emisor.Text.Trim() == "")
            {
                App.MostrarError("Debe ingresar la razón social");
                return false;
            }
            if (txtCuit_Emisor.Text.Trim() == "")
            {
                App.MostrarError("Debe ingresar el CUIT del emisor");
                return false;
            }
            if (txtDomicilioComercial_Emisor.Text.Trim() == "")
            {
                App.MostrarError("Debe ingresar el domicilio comercial del emisor");
                return false;
            }
            if (cbxCondicionIVA_Emisor.Text.Trim() == "" || cbxCondicionIVA_Emisor.SelectedIndex < 0)
            {
                App.MostrarError("Debe seleccionar la condicion frente al IVA del emisor");
                return false;
            }
            return true;
        }

        private void FormCargarDatosEmisor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void FormCargarDatosEmisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (!validaciones())
                {
                    return;
                }

                string CuitConGuion = "";

                if (txtCuit_Emisor.Text.Length > 0)
                {
                    for (int i = 0; i < txtCuit_Emisor.Text.Length; i++)
                    {
                        if (i == 2)
                        {
                            CuitConGuion += "-";
                        }
                        if (i == 10)
                        {
                            CuitConGuion += "-";
                        }
                        CuitConGuion += txtCuit_Emisor.Text[i];
                    }
                }

                _facturacionService.GetBuilder()
                .GetEmisor()
                    .SetRazonSocial(txtRazonSocial_Emisor.Text)
                    .SetCUIT(txtCuit_Emisor.Text)
                    .SetDomicilio(txtDomicilioComercial_Emisor.Text)
                    .SetCondicionIVA(cbxCondicionIVA_Emisor.Text)
                    .SetFechaInicioActividades(dtpFechaInicioActividades.Value)
                    .Build();
                _navigationService.NavigateTo<FormPuntosVenta>();
                Hide();
            }
        }
    }
}
