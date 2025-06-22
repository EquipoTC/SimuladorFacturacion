using System;
using System.Windows.Forms;

namespace SimuladorFacturacion.Interfaces
{
    public interface INavigationService
    {
        void NavigateTo<T>() where T : Form;
        void NavigateBack();
    }
}