using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SimuladorFacturacion
{
	public class App
	{
		/*public ClassFacturacion DataFacturacion;
        public App(ClassFacturacion DataFacturacion)
		{
			this.DataFacturacion = DataFacturacion;
		}*/
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
        public static decimal StrToDecimal(string input, decimal defaultValue = 0M)
        {
            if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.CurrentCulture, out var result))
                return result;
            return defaultValue;
        }
    }
}
