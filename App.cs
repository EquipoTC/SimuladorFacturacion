using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimuladorFacturacion
{
	public static class App
	{
		// Declarar instancias de los formularios
		static FormPuntosVenta frmPuntosVentas;
		static FormDatosEmision frmDatosEmision;
		static FormDatosOperacion frmDatosOperacion;
		static FormDatosReceptor frmDatosReceptor;
		static FormImpresion frmImpresion;
		static FormCargarDatosEmisor frmCargarDatosEmisor;

		public static ClassFacturacion DataFacturacion;

        // Método para mostrar FormCargarDatosEmisor
        public static void MostrarCargarDatosEmisor()
        {
            if (frmCargarDatosEmisor == null)
            {
                frmCargarDatosEmisor = new FormCargarDatosEmisor();
            }
            frmCargarDatosEmisor.Show();
        }

        // Método para mostrar FromPuntosVenta
        public static void MostrarFromPuntosVenta()
		{
			if (frmPuntosVentas == null)
			{
				frmPuntosVentas = new FormPuntosVenta();
			}
			frmPuntosVentas.Show();
		}
		
		// Método para mostrar FormDatosEmision
		public static void MostrarDatosEmision()
		{
			if (frmDatosEmision == null)
			{
				frmDatosEmision = new FormDatosEmision();
            }
			frmDatosEmision.Show();
		}
		
		// Método para mostrar FormDatosOperacion
		public static void MostrarDatosOperacion()
		{
			if (frmDatosOperacion == null)
			{
				frmDatosOperacion = new FormDatosOperacion();
                frmDatosOperacion.Show();
            }
            frmDatosOperacion.Show();
		}
		
		
		// Método para mostrar FormDatosReceptor
		public static void MostrarDatosReceptor()
		{
			if (frmDatosReceptor == null)
			{
				frmDatosReceptor = new FormDatosReceptor();
			}
			frmDatosReceptor.Show();
		}


		// Método para mostrar FormImpresion
		public static void MostrarFormImpresion()
		{
			if (frmImpresion == null)
			{
				frmImpresion = new FormImpresion();
			}
			frmImpresion.iniciar();
			frmImpresion.Show();
		}

		public static void MostrarError(string msj){
			MessageBox.Show(msj,"Facturacion",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
		
		
		public static int StrToInt(string input, int defaultValue = 0)
		{
			int result;
			return int.TryParse(input, out result) ? result : defaultValue;
		}
		
		public static double StrToDouble(string input, double defaultValue = 0.0)
		{
			double result;
			return double.TryParse(input, out result) ? result : defaultValue;
		}
	}
}
