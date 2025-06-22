using SimuladorFacturacion.Interfaces;
using SimuladorFacturacion.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SimuladorFacturacion
{
	public partial class MainForm : Form
	{
        private readonly INavigationService _navigationService;
        public MainForm(INavigationService navigationService)
        {
            _navigationService = navigationService;
            InitializeComponent();
            iniciarboton();
            iniciarlabel();
        }

		private Button btn1;
        private Label TituloMain;
        private Label lblAbajoIZQ;
        private Label lblAbajoDER;

        private void iniciarboton()
        {
            btn1 = new Button();
            btn1.Text = "< Iniciar >";
            btn1.Size = new Size(130, 30);
            btn1.Click += btn1_Click;
            this.Controls.Add(btn1);
        }

        private void centrarboton()
        {
            int x = (this.ClientSize.Width - btn1.Size.Width) / 2;
            int y = (this.ClientSize.Height - btn1.Size.Height) / 2;

            btn1.Location = new Point(x, y);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            _navigationService.NavigateTo<FormCargarDatosEmisor>();
        }
        
        private void iniciarlabel()
        {
            TituloMain = new Label();
            TituloMain.Text = "Simulador de Facturación";
            TituloMain.AutoSize = true;
            TituloMain.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            TituloMain.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(TituloMain);

            lblAbajoIZQ = new Label();
            lblAbajoIZQ.Text = "Hecho por Tomás Borgo/Gino Casentini";
            lblAbajoIZQ.AutoSize = true;
            lblAbajoIZQ.Font = new Font("Arial", 12, FontStyle.Italic); 
            lblAbajoIZQ.ForeColor = Color.Gray; 
            this.Controls.Add(lblAbajoIZQ);

            lblAbajoDER = new Label();
            lblAbajoDER.Text = "E.E.T Nº2 'Pbro. José. M. Colombo'";
            lblAbajoDER.AutoSize = true;
            lblAbajoDER.Font = new Font("Arial", 12, FontStyle.Italic);
            lblAbajoDER.ForeColor = Color.Gray; 
            this.Controls.Add(lblAbajoDER);
        }

        private void centrarlabel()
        {
            int x = (this.ClientSize.Width - TituloMain.Size.Width) / 2;
            double y = (this.ClientSize.Height - TituloMain.Size.Height) / 2.2;
            TituloMain.Location = new Point(x, (int)y);
        }

        private void ubicarlabel()
        {
            lblAbajoIZQ.Location = new Point(10, (this.ClientSize.Height - 35) - lblAbajoIZQ.Height - 10);

            lblAbajoDER.Location = new Point(this.ClientSize.Width - lblAbajoDER.Width - 10, (this.ClientSize.Height - 35) - lblAbajoDER.Height - 10);
        }
        
        private void MainForm_Resize(object sender, EventArgs e)
        {
            centrarboton();
            centrarlabel();
            ubicarlabel();
        }

        void MainFormLoad(object sender, EventArgs e)
		{
            centrarboton();
            centrarlabel();
            ubicarlabel();
        }
    }
}
