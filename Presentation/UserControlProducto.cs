using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimuladorFacturacion.Presentation
{
	[DefaultEvent(nameof(TextChanged))]
	public partial class UserControlProducto : UserControl
	{
        public event EventHandler BotonBorrarClick;

        public string Codigo
        {
            get => txtCodigo.Text;
            set => txtCodigo.Text = value;
        }
        public string Producto
        {
            get => txtProducto.Text;
            set => txtProducto.Text = value;
        }

        public string Cantidad
        {
            get => txtCantidad.Text;
            set => txtCantidad.Text = value;
        }

        public string UnidadMedida
        {
            get => cbxUmedida1.Text;
            set => cbxUmedida1.Text = value;
        }

        public string PrecioUnitario
        {
            get => txtPrecUnitario1.Text;
            set => txtPrecUnitario1.Text = value;
        }

        public string PorcentajeBonificacion
        {
            get => txtPorcentajeBon.Text;
            set => txtPorcentajeBon.Text = value;
        }

        public string AlicuotaIVA
        {
            get => cbxAlicuotaIVA.Text;
            set => cbxAlicuotaIVA.Text = value;
        }

        public string ImporteBon
        {
            get => txtImporteBon.Text;
            set => txtImporteBon.Text = value;
        }

        public string Subtotal
        {
            get => txtSubtotal.Text;
            set => txtSubtotal.Text = value;
        }

        public string ImporteIVA
        {
            get => txtImporteIVA.Text;
            set => txtImporteIVA.Text = value;
        }

        public string SubtotalIVA
        {
            get => txtSubtotalIVA.Text;
            set => txtSubtotalIVA.Text = value;
        }
        public event EventHandler ValoresCambiados;
        public UserControlProducto()
        {
            InitializeComponent();

            // Cuando cambie algo de interés, disparar evento
            txtCantidad.TextChanged += (s, e) => ValoresCambiados?.Invoke(this, EventArgs.Empty);
            txtPrecUnitario1.TextChanged += (s, e) => ValoresCambiados?.Invoke(this, EventArgs.Empty);
            txtPorcentajeBon.TextChanged += (s, e) => ValoresCambiados?.Invoke(this, EventArgs.Empty);
            cbxAlicuotaIVA.SelectedIndexChanged += (s, e) => ValoresCambiados?.Invoke(this, EventArgs.Empty);

            btnBorrar.Click += (s, e) => BotonBorrarClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
