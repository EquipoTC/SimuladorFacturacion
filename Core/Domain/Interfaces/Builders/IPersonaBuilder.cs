using SimuladorFacturacion.Core.Domain.Models;

namespace SimuladorFacturacion.Interfaces
{
    public interface IPersonaBuilder<T> : IBuilder<T> where T : PersonaModel
    {
        IPersonaBuilder<T> SetRazonSocial(string razonSocial);
        IPersonaBuilder<T> SetCUIT(string cuit);
        IPersonaBuilder<T> SetDomicilio(string domicilio);
        IPersonaBuilder<T> SetCondicionIVA(string condicionIVA);
        IPersonaBuilder<T> SetDatos(string razonSocial, string cuit);
        IPersonaBuilder<T> SetDatos(string razonSocial, string cuit, string domicilio);
        IPersonaBuilder<T> SetDatos(string razonSocial, string cuit, string domicilio, string condicionIVA);
    }
}