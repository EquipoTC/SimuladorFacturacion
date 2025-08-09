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
	[DefaultEvent(nameof(TextChanged))]
	public partial class UserControlProducto : UserControl
	{
		public UserControlProducto()
		{
			InitializeComponent();
		}
	}
}
