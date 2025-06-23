using System.Windows.Forms;

namespace SimuladorFacturacion.Core.Domain.Interfaces.Services
{
    public interface INavigationService
    {
        void NavigateTo<T>() where T : Form;
        void NavigateBack();
    }
}