using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimuladorFacturacion
{
    public partial class FormCargarDatosEmisor : Form
    {
        public FormCargarDatosEmisor()
        {
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


            App.DataFacturacion.RazonSocialEmisor = txtRazonSocial_Emisor.Text;
            App.DataFacturacion.CUITemisor = txtCuit_Emisor.Text;
            App.DataFacturacion.DomicilioComercialEmisor = txtDomicilioComercial_Emisor.Text;
            App.DataFacturacion.CondicionIVA_Emisor = cbxCondicionIVA_Emisor.Text;
            App.DataFacturacion.FechaInicioActividades = dtpFechaInicioActividades.Value;
            App.DataFacturacion.CUITemisorConGuion = CuitConGuion;

            App.MostrarFromPuntosVenta();
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


                App.DataFacturacion.RazonSocialEmisor = txtRazonSocial_Emisor.Text;
                App.DataFacturacion.CUITemisor = txtCuit_Emisor.Text;
                App.DataFacturacion.DomicilioComercialEmisor = txtDomicilioComercial_Emisor.Text;
                App.DataFacturacion.CondicionIVA_Emisor = cbxCondicionIVA_Emisor.Text;
                App.DataFacturacion.FechaInicioActividades = dtpFechaInicioActividades.Value;
                App.DataFacturacion.CUITemisorConGuion = CuitConGuion;

                App.MostrarFromPuntosVenta();
                Hide();
            }
        }
    }
}
