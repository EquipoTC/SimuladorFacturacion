using Microsoft.Extensions.DependencyInjection;
using SimuladorFacturacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorFacturacion.Services
{
    public class NavigationService : INavigationService
    {
        public ServiceProvider _serviceProvider;
        private Stack<Form> historyRecord;
        private Form currentForm;

        public NavigationService(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
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
            nextForm.Show();
        }

        public void NavigateBack()
        {
            if (historyRecord.Count > 0)
            {
                currentForm?.Hide();
                currentForm = historyRecord.Pop();
                currentForm.Show();
            }
        }
    }
}
