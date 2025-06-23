using Microsoft.Extensions.DependencyInjection;
using SimuladorFacturacion.Core.Application.Services;
using SimuladorFacturacion.Core.Domain.Interfaces.Builders;
using SimuladorFacturacion.Core.Domain.Interfaces.Repositories;
using SimuladorFacturacion.Core.Domain.Interfaces.Services;
using SimuladorFacturacion.Infraestructure.Builders;
using SimuladorFacturacion.Infraestructure.Repositories;
using SimuladorFacturacion.Infraestructure.Services;
using System;
using System.Windows.Forms;

namespace SimuladorFacturacion
{
	internal sealed class Program
	{
		ServiceProvider servicesContainer = new ServiceCollection()
            // Vistas
            .AddSingleton<MainForm>()
            .AddSingleton<FormPuntosVenta>()
            .AddSingleton<FormDatosEmision>()
            .AddSingleton<FormDatosOperacion>()
            .AddSingleton<FormDatosReceptor>()
            .AddSingleton<FormImpresion>()
            .AddSingleton<FormCargarDatosEmisor>()

            // Repositorios
            .AddSingleton<IFacturaRepository, FacturaRepository>()

            // Builders
            .AddTransient<IEmisorBuilder, EmisorBuilder>()
            .AddTransient<IReceptorBuilder, ReceptorBuilder>()
            .AddTransient<IComprobanteBuilder, ComprobanteBuilder>()
            .AddTransient<IRenglonBuilder, RenglonBuilder>()
            .AddTransient<IImporteBuilder, ImporteBuilder>()
            .AddTransient<IFacturaBuilder, FacturaBuilder>()

            // Servicios
            .AddSingleton<FacturacionService>()
            .AddSingleton<INavigationService, NavigationService>()

			.BuildServiceProvider();

		[STAThread]
		private static void Main(string[] args)
		{
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run();
		}
		
	}
}
