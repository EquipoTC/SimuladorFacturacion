/*
 * Created by SharpDevelop.
 * User: Alumno
 * Date: 6/5/2024
 * Time: 20:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimuladorFacturacion
{
	/// <summary>
	/// Description of FormDatosEmision.
	/// </summary>
	public partial class FormDatosEmision : Form
	{
		public FormDatosEmision()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            this.KeyPreview = true;
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
		void Label1Click(object sender, EventArgs e)
		{

		}
		void CbxConceptosSelectedIndexChanged(object sender, EventArgs e)
		{

		}
		void BtnAnteriorClick(object sender, EventArgs e)
		{
			App.MostrarFromPuntosVenta();
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
            //controlar las validaciones, para ello crear una funcion que valide que el usuarios haya seleccionado un concepto
            //caso contrario mostrar error (mirar como esta hecho en FormPuntosVenta)
            ////guardar los datos en App.DataFacturacion
			App.DataFacturacion.FechaEmision = dtpFechaComprobante.Value;
            App.DataFacturacion.ConceptosIncluir = cbxConceptos.Text;

            App.MostrarDatosReceptor();
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
                App.DataFacturacion.FechaEmision = dtpFechaComprobante.Value;
                App.DataFacturacion.ConceptosIncluir = cbxConceptos.Text;

                App.MostrarDatosReceptor();
                Hide();
            }
        }
    }
}


