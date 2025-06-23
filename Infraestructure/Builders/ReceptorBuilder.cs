using SimuladorFacturacion.Core.Domain.Interfaces.Builders;
using SimuladorFacturacion.Core.Domain.Models;

namespace SimuladorFacturacion.Infraestructure.Builders
{
    public class ReceptorBuilder : PersonaBuilder<ReceptorModel, IReceptorBuilder>
    {
        public IReceptorBuilder SetEmail(string email)
        {
            _persona.Email = email;
            return (IReceptorBuilder)this;
        }

        public IReceptorBuilder SetDatos(string razonSocial, string cuit, string domicilio, string condicionIVA, string email)
        {
            SetDatos(razonSocial, cuit, domicilio, condicionIVA);
            return SetEmail(email);
        }
    }
}