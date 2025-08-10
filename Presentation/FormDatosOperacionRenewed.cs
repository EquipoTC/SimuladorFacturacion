using SimuladorFacturacion.Core.Application.Services;
using SimuladorFacturacion.Core.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SimuladorFacturacion.Presentation
{
    public partial class FormDatosOperacionRenewed : Form
    {
        private readonly FacturacionService _facturacionService;
        private readonly INavigationService _navigationService;
        double totalTotalizadores = 0;
        public List<UserControlProducto> productos;

        public FormDatosOperacionRenewed(FacturacionService facturacionService, INavigationService navigationService)
        {
            _facturacionService = facturacionService;
            _navigationService = navigationService;
            InitializeComponent();

            productos = new List<UserControlProducto>();
            txtImpOtrosTributos.Text = "0";
            txtIVA0.Text = "0";
            txtIVA2.Text = "0";
            txtIVA5.Text = "0";
            txtIVA10.Text = "0";
            txtIVA21.Text = "0";
            txtIVA27.Text = "0";
            txtImpNetoNoGravado.Text = "0";
            txtImpExento.Text = "0";
            txtImpNetoGravado.Text = "0";
            txtImporteOtrosTributos.Text = "0";
            this.KeyPreview = true;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            lblProductosEncontrados.Visible = false;
            var nuevoProducto = new UserControlProducto();
            nuevoProducto.Dock = DockStyle.Top;
            panelIngresoProductos.Controls.Add(nuevoProducto);
            panelIngresoProductos.Controls.SetChildIndex(nuevoProducto, 0);
            productos.Add(nuevoProducto);

            // Eventos encapsulados
            nuevoProducto.ValoresCambiados += (s, ev) =>
            {
                CalcularImportes(nuevoProducto);
                CalcularTotales();
            };
            nuevoProducto.BotonBorrarClick += (s, ev) => BorrarProducto(nuevoProducto);
        }

        private void BorrarProducto(UserControlProducto producto)
        {
            panelIngresoProductos.Controls.Remove(producto);
            productos.Remove(producto);
            producto.Dispose();
            CalcularTotales();
        }

        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            foreach (var producto in productos.ToList())
            {
                panelIngresoProductos.Controls.Remove(producto);
                productos.Remove(producto);
                producto.Dispose();
            }

            lblProductosEncontrados.Visible = true;
            CalcularTotales();
        }

        private void CalcularImportes(UserControlProducto producto)
        {
            double cantidad = App.StrToDouble(producto.Cantidad);
            double precioUnitario = App.StrToDouble(producto.PrecioUnitario);
            double precio = cantidad * precioUnitario;

            double porcentajeBon = App.StrToDouble(producto.PorcentajeBonificacion);
            double bonificacion = precio * (porcentajeBon / 100);

            double subtotal = precio + bonificacion;

            double alicuotaIVA = App.StrToDouble(producto.AlicuotaIVA);
            double importeIVA = subtotal * (alicuotaIVA / 100);

            double totalConIVA = subtotal;
            if (importeIVA > 0)
                totalConIVA += importeIVA;

            producto.ImporteBon = bonificacion.ToString();
            producto.Subtotal = subtotal.ToString();
            producto.ImporteIVA = importeIVA.ToString();
            producto.SubtotalIVA = totalConIVA.ToString();
        }

        private void CalcularTotales()
        {
            txtImpNetoNoGravado.Text = "0";
            txtImpExento.Text = "0";
            txtImpNetoGravado.Text = "0";
            txtIVA27.Text = "0";
            txtIVA21.Text = "0";
            txtIVA10.Text = "0";
            txtIVA5.Text = "0";
            txtIVA2.Text = "0";
            txtIVA0.Text = "0";

            double totalizadorNetoGravado = 0;
            foreach (var producto in productos)
            {
                totalizadorNetoGravado += App.StrToDouble(producto.Subtotal);
            }
            txtImpNetoGravado.Text = totalizadorNetoGravado.ToString();

            var totalizadoresPorAlicuota = new Dictionary<string, double>();
            foreach (var producto in productos)
            {
                string alicuota = producto.AlicuotaIVA;
                double importeIVA = App.StrToDouble(producto.ImporteIVA);

                if (!totalizadoresPorAlicuota.ContainsKey(alicuota))
                    totalizadoresPorAlicuota[alicuota] = 0;

                totalizadoresPorAlicuota[alicuota] += importeIVA;
            }

            foreach (var kvp in totalizadoresPorAlicuota)
            {
                switch (kvp.Key)
                {
                    case "27":
                        txtIVA27.Text = kvp.Value.ToString();
                        break;
                    case "21":
                        txtIVA21.Text = kvp.Value.ToString();
                        break;
                    case "10,5":
                        txtIVA10.Text = kvp.Value.ToString();
                        break;
                    case "5":
                        txtIVA5.Text = kvp.Value.ToString();
                        break;
                    case "2,5":
                        txtIVA2.Text = kvp.Value.ToString();
                        break;
                    case "0":
                        txtIVA0.Text = kvp.Value.ToString();
                        break;
                    case "Exento":
                        txtImpExento.Text = kvp.Value.ToString();
                        break;
                    case "No gravado":
                        txtImpNetoNoGravado.Text = kvp.Value.ToString();
                        break;
                }
            }

            totalTotalizadores = App.StrToDouble(txtIVA27.Text) +
                                 App.StrToDouble(txtIVA21.Text) +
                                 App.StrToDouble(txtIVA10.Text) +
                                 App.StrToDouble(txtIVA5.Text) +
                                 App.StrToDouble(txtIVA2.Text) +
                                 App.StrToDouble(txtIVA0.Text) +
                                 App.StrToDouble(txtImpNetoNoGravado.Text) +
                                 App.StrToDouble(txtImpExento.Text) +
                                 App.StrToDouble(txtImpNetoGravado.Text) +
                                 App.StrToDouble(txtImporteOtrosTributos.Text);

            txtImpTotal.Text = totalTotalizadores.ToString();
        }

        private void calcularImporteOtrosTributos(object sender, EventArgs e)
        {
            double alicuotaPorciento = App.StrToDouble(txtPerRetGanancias_BaseImp.Text) * (App.StrToDouble(txtPerRetGanancias_Alicuota.Text) / 100);
            double Total_PerRetGanancias = App.StrToDouble(txtPerRetGanancias_BaseImp.Text) + alicuotaPorciento;
            txtPerRetGanancias_Importe.Text = Total_PerRetGanancias.ToString();

            alicuotaPorciento = App.StrToDouble(txtPerRetIVA_BaseImp.Text) * (App.StrToDouble(txtPerRetIVA_Alicuota.Text) / 100);
            double Total_PerRetIVA = App.StrToDouble(txtPerRetIVA_BaseImp.Text) + alicuotaPorciento;
            txtPerRetIVA_Importe.Text = Total_PerRetIVA.ToString();

            alicuotaPorciento = App.StrToDouble(txtPerRetIngresosBrutos_BaseImp.Text) * (App.StrToDouble(txtPerRetIngresosBrutos_Alicuota.Text) / 100);
            double Total_PerRetIngresosBrutos = App.StrToDouble(txtPerRetIngresosBrutos_BaseImp.Text) + alicuotaPorciento;
            txtPerRetIngresosBrutos_Importe.Text = Total_PerRetIngresosBrutos.ToString();

            alicuotaPorciento = App.StrToDouble(txtImpuestosInternos_BaseImp.Text) * (App.StrToDouble(txtImpuestosInternos_Alicuota.Text) / 100);
            double Total_ImpuestosInternos = App.StrToDouble(txtImpuestosInternos_BaseImp.Text) + alicuotaPorciento;
            txtImpuestosInternos_Importe.Text = Total_ImpuestosInternos.ToString();

            alicuotaPorciento = App.StrToDouble(txtImpuestosMunicipales_BaseImp.Text) * (App.StrToDouble(txtImpuestosMunicipales_Alicuota.Text) / 100);
            double Total_ImpuestosMunicipales = App.StrToDouble(txtImpuestosMunicipales_BaseImp.Text) + alicuotaPorciento;
            txtImpuestosMunicipales_Importe.Text = Total_ImpuestosMunicipales.ToString();

            double Total_ImporteOtrosTributos = Total_PerRetGanancias + Total_PerRetIVA + Total_PerRetIngresosBrutos + Total_ImpuestosInternos + Total_ImpuestosMunicipales;
            txtImporteOtrosTributos.Text = Total_ImporteOtrosTributos.ToString();
            txtImpOtrosTributos.Text = txtImporteOtrosTributos.Text;

            totalTotalizadores = App.StrToDouble(txtIVA27.Text) +
                                 App.StrToDouble(txtIVA21.Text) +
                                 App.StrToDouble(txtIVA10.Text) +
                                 App.StrToDouble(txtIVA5.Text) +
                                 App.StrToDouble(txtIVA2.Text) +
                                 App.StrToDouble(txtIVA0.Text) +
                                 App.StrToDouble(txtImpNetoNoGravado.Text) +
                                 App.StrToDouble(txtImpExento.Text) +
                                 App.StrToDouble(txtImpNetoGravado.Text) +
                                 App.StrToDouble(txtImporteOtrosTributos.Text);

            txtImpTotal.Text = totalTotalizadores.ToString();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (!ValidarProductos()) return;

            CargarData();
            _facturacionService.GetBuilder()
                .GetImporte()
                    .SetOtrosTributos(decimal.Parse(txtImpOtrosTributos.Text))
                    .SetNetoGravado(decimal.Parse(txtImpNetoGravado.Text))
                    .SetIVA27(decimal.Parse(txtIVA27.Text))
                    .SetIVA21(decimal.Parse(txtIVA21.Text))
                    .SetIVA10(decimal.Parse(txtIVA10.Text))
                    .SetIVA5(decimal.Parse(txtIVA5.Text))
                    .SetIVA2(decimal.Parse(txtIVA2.Text))
                    .SetIVA0(decimal.Parse(txtIVA0.Text))
                    .SetOtrosTributos(decimal.Parse(txtImpOtrosTributos.Text))
                    .SetNetoGravado(decimal.Parse(txtImpNetoGravado.Text))
                    .Build();
            _navigationService.NavigateTo<FormImpresion>();
            Hide();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Hide();
            _navigationService.NavigateBack();
        }

        private bool ValidarProductos()
        {
            if (productos.Count == 0)
            {
                App.MostrarError("Debe agregar al menos un producto");
                return false;
            }

            foreach (var producto in productos)
            {
                if (string.IsNullOrWhiteSpace(producto.Codigo))
                {
                    App.MostrarError("Debe ingresar el código del producto");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(producto.Producto))
                {
                    App.MostrarError("Debe ingresar el nombre del producto o servicio");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(producto.Cantidad))
                {
                    App.MostrarError("Debe ingresar la cantidad");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(producto.UnidadMedida))
                {
                    App.MostrarError("Debe seleccionar la unidad de medida");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(producto.PrecioUnitario))
                {
                    App.MostrarError("Debe ingresar el precio unitario");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(producto.AlicuotaIVA))
                {
                    App.MostrarError("Debe seleccionar la alícuota IVA");
                    return false;
                }
            }

            return true;
        }

        private void CargarData()
        {
            var builder = _facturacionService.GetBuilder();
            builder.CleanRenglones();

            foreach (var producto in productos)
            {
                var alicuota = 0M;
                if(!string.IsNullOrWhiteSpace(producto.AlicuotaIVA) 
                    && producto.AlicuotaIVA != "No gravado" 
                    && producto.AlicuotaIVA != "Exento")
                {
                    alicuota = App.StrToDecimal(producto.AlicuotaIVA);
                }
                builder.GetRenglon().Reset();
                var renglon = builder.GetRenglon()
                    .SetCodigo(producto.Codigo)
                    .SetProductoServicio(producto.Producto)
                    .SetCantidad(string.IsNullOrWhiteSpace(producto.Cantidad) ? 0 : App.StrToDecimal(producto.Cantidad))
                    .SetUnidadMedida(producto.UnidadMedida)
                    .SetPrecioUnitario(string.IsNullOrWhiteSpace(producto.PrecioUnitario) ? 0 : App.StrToDecimal(producto.PrecioUnitario))
                    .SetPorcentajeBonificacion(string.IsNullOrWhiteSpace(producto.PorcentajeBonificacion) ? 0 : App.StrToDecimal(producto.PorcentajeBonificacion))
                    .SetAlicuotaIVA(producto.AlicuotaIVA, alicuota)
                    .Build();
                builder.AddRenglon(renglon);
            }
        }

        private void FormDatosOperacionRenewed_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void FormDatosOperacionRenewed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (!ValidarProductos()) return;

                CargarData();
                _facturacionService.GetBuilder()
                    .GetImporte()
                        .SetOtrosTributos(decimal.Parse(txtImpOtrosTributos.Text))
                        .SetNetoGravado(decimal.Parse(txtImpNetoGravado.Text))
                        .SetIVA27(decimal.Parse(txtIVA27.Text))
                        .SetIVA21(decimal.Parse(txtIVA21.Text))
                        .SetIVA10(decimal.Parse(txtIVA10.Text))
                        .SetIVA5(decimal.Parse(txtIVA5.Text))
                        .SetIVA2(decimal.Parse(txtIVA2.Text))
                        .SetIVA0(decimal.Parse(txtIVA0.Text))
                        .SetOtrosTributos(decimal.Parse(txtImpOtrosTributos.Text))
                        .SetNetoGravado(decimal.Parse(txtImpNetoGravado.Text))
                        .Build();
                _navigationService.NavigateTo<FormImpresion>();
                Hide();
            }
        }

        private void panelDetalle_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(panelDetalle, e);
        }
        private void panelImporte_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(panelDetalle, e);
        }
        private void DrawPanelBorder(Panel panel, PaintEventArgs e)
        {
            Color colorBorde = Color.Black;
            int grosor = 2;

            using (Pen pen = new Pen(colorBorde, grosor))
            {
                e.Graphics.DrawRectangle(pen,
                    new Rectangle(0, 0, panel.Width - 1, panel.Height - 1));
            }
        }

        private void panelProductoBotones_Paint(object sender, PaintEventArgs e)
        {
            DrawPanelBorder(panelProductoBotones, e);
        }
    }
}
