using SimuladorFacturacion.Core.Domain.Models;

namespace SimuladorFacturacion.Core.Domain.Interfaces.Builders
{
    public interface IPersonaBuilder<T, TBuilder> : IBuilder<T> where T : PersonaModel
    {
        TBuilder SetRazonSocial(string razonSocial);
        TBuilder SetCUIT(string cuit);
        TBuilder SetDomicilio(string domicilio);
        TBuilder SetCondicionIVA(string condicionIVA);
        TBuilder SetDatos(string razonSocial, string cuit);
        TBuilder SetDatos(string razonSocial, string cuit, string domicilio);
        TBuilder SetDatos(string razonSocial, string cuit, string domicilio, string condicionIVA);
    }
}