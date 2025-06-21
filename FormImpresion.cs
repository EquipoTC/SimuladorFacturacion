using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;


namespace SimuladorFacturacion
{
    public partial class FormImpresion : Form
    {
        public FormImpresion()
        {
            InitializeComponent();
        }

        private void FormImpresion_Load(object sender, EventArgs e)
        {

        }

        public void iniciar()
        {


            ReportDataSource rds = new ReportDataSource("DataSet1", App.DataFacturacion.Renglones);
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
            ReportParameter rpRazonSocialEmisor = new ReportParameter("RPRazonSocialEmisor", App.DataFacturacion.RazonSocialEmisor);
            ReportParameter rpDomicilioComercialEmisor = new ReportParameter("RPDomicilioComercialEmisor", App.DataFacturacion.DomicilioComercialEmisor);
            ReportParameter rpCondicionIVA_Emisor = new ReportParameter("RPCondicionIVA_Emisor", App.DataFacturacion.CondicionIVA_Emisor);
            ReportParameter rpCuitEmisor = new ReportParameter("RPCuitEmisor", App.DataFacturacion.CUITemisor);
            ReportParameter rpFechaInicioAct = new ReportParameter("RPFechaInicioActividades", App.DataFacturacion.FechaInicioActividades.ToString());
            ReportParameter rpCuitEmisorGuion = new ReportParameter("RPCuitEmisorGuion", App.DataFacturacion.CUITemisorConGuion);
            ReportParameter rpRazonSocial = new ReportParameter("RPRazonSocial", App.DataFacturacion.RazonSocial);
            ReportParameter rpDomicilio = new ReportParameter("RPDomicilioComercial", App.DataFacturacion.DomicilioComercial);
            ReportParameter rpCondicionIVA = new ReportParameter("RPCondicionIVA", App.DataFacturacion.CondicionIVA);
            ReportParameter rpPuntoVenta = new ReportParameter("RPPuntoVenta", App.DataFacturacion.PuntoVentas);
            ReportParameter rpFechaEmision = new ReportParameter("RPFechaEmision", App.DataFacturacion.FechaEmision.ToString());
            ReportParameter rpCuit = new ReportParameter("RPCuit", App.DataFacturacion.CUIT);
            ReportParameter rpLetraComprobante = new ReportParameter("RPLetraComprobante", App.DataFacturacion.LetraComprobante);
            ReportParameter rpTipoComprobante = new ReportParameter("RPTipoComprobante", App.DataFacturacion.ComprobanteNoLetra);
            ReportParameter rpCondicionVenta = new ReportParameter("RPCondicionVenta", App.DataFacturacion.CondicionesVenta);
            ReportParameter rpImporteOtrosTributos = new ReportParameter("RPImporteOtrosTributos", App.DataFacturacion.ImpOtrosTributos);
            ReportParameter rpImpNetoGravado = new ReportParameter("RPImporteNetoGravado", App.DataFacturacion.ImpNetoGravado);
            ReportParameter rpIVA27 = new ReportParameter("RPIva27", App.DataFacturacion.IVA27);
            ReportParameter rpIVA21 = new ReportParameter("RPIva21", App.DataFacturacion.IVA21);
            ReportParameter rpIVA10 = new ReportParameter("RPIva10", App.DataFacturacion.IVA10);
            ReportParameter rpIVA5 = new ReportParameter("RPIva5", App.DataFacturacion.IVA5);
            ReportParameter rpIVA2 = new ReportParameter("RPIva2", App.DataFacturacion.IVA2);
            ReportParameter rpIVA0 = new ReportParameter("RPIva0", App.DataFacturacion.IVA0);
            ReportParameter rpImporteTotal = new ReportParameter("RPImporteTotal", App.DataFacturacion.ImpTotal);


            // Asignar el parámetro al ReportViewer
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpRazonSocialEmisor
    });
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpDomicilioComercialEmisor
});
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] { rpCondicionIVA_Emisor });
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
            App.MostrarDatosOperacion();
            Hide();
        }

        private void FormImpresion_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
