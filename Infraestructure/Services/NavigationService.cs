using Microsoft.Extensions.DependencyInjection;
using SimuladorFacturacion.Core.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimuladorFacturacion.Infraestructure.Services
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
