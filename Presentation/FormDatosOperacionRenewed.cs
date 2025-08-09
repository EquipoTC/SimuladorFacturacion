using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorFacturacion.Presentation
{
	public partial class FormDatosOperacionRenewed : Form
	{
		public List<UserControlProducto> productos;
		public FormDatosOperacionRenewed()
		{
			InitializeComponent();
            productos = new List<UserControlProducto>();
		}

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            lblProductosEncontrados.Visible = false;
            UserControlProducto nuevoProducto = new UserControlProducto();
            nuevoProducto.Dock = DockStyle.Top;
            panelIngresoProductos.Controls.Add(nuevoProducto);
            panelIngresoProductos.Controls.SetChildIndex(nuevoProducto, 0);
            productos.Add(nuevoProducto);
        }
    }
}
