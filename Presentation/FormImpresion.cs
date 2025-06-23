using Microsoft.Reporting.WinForms;
using SimuladorFacturacion.Core.Application.Services;
using SimuladorFacturacion.Core.Domain.Interfaces.Services;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace SimuladorFacturacion
{
    public partial class FormImpresion : Form
    {
        private readonly FacturacionService _facturacionService;
        private readonly INavigationService _navigationService;
        public FormImpresion(FacturacionService facturacionService, INavigationService navigationService)
        {
            _facturacionService = facturacionService;
            _navigationService = navigationService;
            InitializeComponent();
        }

        private void FormImpresion_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        public void iniciar()
        {
            var factura = _facturacionService.FinishFactura();
            ReportDataSource rds = new ReportDataSource("DataSet1", factura.Renglones);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "SimuladorFacturacion.Report1.rdlc";
            this.reportViewer.LocalReport.DataSources.Clear();
            this.reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer.ZoomMode = ZoomMode.PageWidth;


            // Configurar márgenes
            PageSettings pageSettings = new PageSettings();
            pageSettings.Margins = new Margins(25, 2, 2, 2); // Márgenes en milésimas de pulgada
            pageSettings.PaperSize = new PaperSize("A4", 827, 1169); // Tamaño en milésimas de pulgada (8.27 x 11.69 pulgadas)

            // Asignar configuraciones al ReportViewer
            reportViewer.SetPageSettings(pageSettings);



            // Definir el parámetro
            ReportParameter rpRazonSocialEmisor = new ReportParameter("RPRazonSocialEmisor", factura.Emisor.RazonSocial);
            ReportParameter rpDomicilioComercialEmisor = new ReportParameter("RPDomicilioComercialEmisor", factura.Emisor.DomicilioComercial);
            ReportParameter rpCondicionIVAEmisor = new ReportParameter("RPCondicionIVA_Emisor", factura.Emisor.CondicionIVA);
            ReportParameter rpCuitEmisor = new ReportParameter("RPCuitEmisor", factura.Emisor.CUIT);
            ReportParameter rpFechaInicioAct = new ReportParameter("RPFechaInicioActividades", factura.Emisor.FechaInicioActividades.ToString());
            //ReportParameter rpCuitEmisorGuion = new ReportParameter("RPCuitEmisorGuion", FormatCUITWithDashes(factura.Emisor.CUIT));
            ReportParameter rpCuitEmisorGuion = new ReportParameter("RPCuitEmisorGuion", "123123123");
            ReportParameter rpRazonSocial = new ReportParameter("RPRazonSocial", factura.Receptor.RazonSocial);
            ReportParameter rpDomicilio = new ReportParameter("RPDomicilioComercial", factura.Receptor.DomicilioComercial);
            ReportParameter rpCondicionIVA = new ReportParameter("RPCondicionIVA", factura.Receptor.CondicionIVA);
            ReportParameter rpCuit = new ReportParameter("RPCuit", factura.Receptor.CUIT);
            ReportParameter rpPuntoVenta = new ReportParameter("RPPuntoVenta", factura.Comprobante.PuntoVenta.ToString());
            ReportParameter rpFechaEmision = new ReportParameter("RPFechaEmision", factura.Comprobante.FechaEmision.ToString());
            ReportParameter rpLetraComprobante = new ReportParameter("RPLetraComprobante", factura.Comprobante.LetraComprobante);
            ReportParameter rpTipoComprobante = new ReportParameter("RPTipoComprobante", factura.Comprobante.TipoComprobante);
            ReportParameter rpCondicionVenta = new ReportParameter("RPCondicionVenta", factura.Comprobante.CondicionesVenta);
            ReportParameter rpImporteOtrosTributos = new ReportParameter("RPImporteOtrosTributos", factura.Importes.OtrosTributos.ToString());
            ReportParameter rpImpNetoGravado = new ReportParameter("RPImporteNetoGravado", factura.Importes.NetoGravado.ToString());
            ReportParameter rpIVA27 = new ReportParameter("RPIva27", factura.Importes.IVA27.ToString());
            ReportParameter rpIVA21 = new ReportParameter("RPIva21", factura.Importes.IVA21.ToString());
            ReportParameter rpIVA10 = new ReportParameter("RPIva10", factura.Importes.IVA10.ToString());
            ReportParameter rpIVA5 = new ReportParameter("RPIva5", factura.Importes.IVA5.ToString());
            ReportParameter rpIVA2 = new ReportParameter("RPIva2", factura.Importes.IVA2.ToString());
            ReportParameter rpIVA0 = new ReportParameter("RPIva0", factura.Importes.IVA0.ToString());
            ReportParameter rpImporteTotal = new ReportParameter("RPImporteTotal", factura.Importes.GetImporteTotal().ToString());
            //ReportParameter rpTipoComprobante = new ReportParameter("RPTipoComprobante", App.DataFacturacion.ComprobanteNoLetra);


            // Asignar el parámetro al ReportViewer
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpRazonSocialEmisor
    });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpDomicilioComercialEmisor
});
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpCondicionIVAEmisor });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpCuitEmisor });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpFechaInicioAct });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpCuitEmisorGuion });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpRazonSocial });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpDomicilio });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpCondicionIVA });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpPuntoVenta });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpFechaEmision });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpCuit });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpLetraComprobante });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpTipoComprobante });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpCondicionVenta });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpImporteOtrosTributos });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpImpNetoGravado });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpIVA27 });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpIVA21 });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpIVA10 });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpIVA5 });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpIVA2 });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpIVA0 });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpImporteTotal });

            // Cargar y mostrar el reporte
            this.reportViewer.RefreshReport();
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateTo<FormDatosOperacion>();
            Hide();
        }

        private void FormImpresion_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
