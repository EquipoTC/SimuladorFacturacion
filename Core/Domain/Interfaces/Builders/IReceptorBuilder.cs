using SimuladorFacturacion.Models;

namespace SimuladorFacturacion.Interfaces
{
    public interface IReceptorBuilder : IPersonaBuilder<ReceptorModel, IReceptorBuilder>
    {
        IReceptorBuilder SetEmail(string email);
        IReceptorBuilder SetDatos(string razonSocial, string cuit, string domicilio, string condicionIVA, string email);
    }
}