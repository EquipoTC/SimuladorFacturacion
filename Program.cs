using Microsoft.Extensions.DependencyInjection;
using SimuladorFacturacion.Core.Application.Services;
using SimuladorFacturacion.Core.Domain.Interfaces.Builders;
using SimuladorFacturacion.Core.Domain.Interfaces.Repositories;
using SimuladorFacturacion.Core.Domain.Interfaces.Services;
using SimuladorFacturacion.Infraestructure.Builders;
using SimuladorFacturacion.Infraestructure.Repositories;
using SimuladorFacturacion.Infraestructure.Services;
using SimuladorFacturacion.Presentation;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorFacturacion
{
	internal sealed class Program
	{

		[STAThread]
		private static async Task Main(string[] args)
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
            .AddSingleton<FormDatosOperacionRenewed>()

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

            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(servicesContainer.GetService<MainForm>());
		}
		
	}
}
