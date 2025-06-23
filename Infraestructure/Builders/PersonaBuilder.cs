using SimuladorFacturacion.Core.Domain.Models;
using SimuladorFacturacion.Core.Domain.Interfaces.Builders;

namespace SimuladorFacturacion.Infraestructure.Builders
{
    public abstract class PersonaBuilder<T, TBuilder> : IPersonaBuilder<T, TBuilder> 
        where T : PersonaModel
        where TBuilder : IPersonaBuilder<T, TBuilder>
    {
        protected T _persona;

        public PersonaBuilder() => Reset();

        public virtual void Reset()
        {
            _persona = new T();
            return;
        }

        public virtual T GetProduct()
        {
            return _persona;
        }

        public virtual T Build()
        {
            var result = _persona;
            Reset();
            return result;
        }

        public virtual TBuilder SetRazonSocial(string razonSocial)
        {
            _persona.RazonSocial = razonSocial;
            return (TBuilder)(object)this;
        }

        public virtual TBuilder SetCUIT(string cuit)
        {
            _persona.CUIT = cuit;
            return (TBuilder)(object)this;
        }

        public virtual TBuilder SetDomicilio(string domicilio)
        {
            _persona.DomicilioComercial = domicilio;
            return (TBuilder)(object)this;
        }

        public virtual TBuilder SetCondicionIVA(string condicionIVA)
        {
            _persona.CondicionIVA = condicionIVA;
            return (TBuilder)(object)this;
        }

        public virtual TBuilder SetDatos(string razonSocial, string cuit)
        {
            return SetRazonSocial(razonSocial).SetCUIT(cuit);
        }

        public virtual TBuilder SetDatos(string razonSocial, string cuit, string domicilio)
        {
            return SetDatos(razonSocial, cuit).SetDomicilio(domicilio);
        }

        public virtual TBuilder SetDatos(string razonSocial, string cuit, string domicilio, string condicionIVA)
        {
            return SetDatos(razonSocial, cuit, domicilio).SetCondicionIVA(condicionIVA);
        }
    }
}