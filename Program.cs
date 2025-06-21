using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace SimuladorFacturacion
{
	internal sealed class Program
	{
        ServiceProvider services = new ServiceCollection()
			.AddSingleton<FormPuntosVenta>()
			.AddSingleton<FormDatosEmision>()
			.AddSingleton<FormDatosOperacion>()
			.AddSingleton<FormDatosReceptor>()
			.AddSingleton<FormImpresion>()
			.AddSingleton<FormCargarDatosEmisor>()
			.AddSingleton<ClassFacturacion>()
			.BuildServiceProvider();
		[STAThread]
		private static void Main(string[] args)
		{
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
