using Microsoft.Extensions.DependencyInjection;
using SimuladorFacturacion.Core.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimuladorFacturacion.Infraestructure.Services
{
    public class NavigationService : INavigationService
    {
        public IServiceProvider _serviceProvider;
        private Stack<Form> historyRecord;
        private Form currentForm;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            historyRecord = new Stack<Form>();
        }

        public void NavigateTo<T>() where T : Form
        {
            var nextForm = _serviceProvider.GetService<T>();
            if (currentForm != null)
            {
                historyRecord.Push(currentForm);
                currentForm.Hide();
            }
            currentForm = nextForm;
            if(currentForm == null)
            {
                MessageBox.Show("El formulario no existe. Reinicia el programa.");
                return;
            }
            nextForm.Show();
        }

        public void NavigateBack()
        {
            if (historyRecord.Count > 0)
            {
                currentForm?.Hide();
                currentForm = historyRecord.Pop();
                currentForm.Show();
                currentForm.BringToFront();
                currentForm.Focus();
            }
        }
    }
}
