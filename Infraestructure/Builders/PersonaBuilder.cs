using SimuladorFacturacion.Core.Domain.Models;
using SimuladorFacturacion.Interfaces;
using System;

namespace SimuladorFacturacion.Builders
{
    public abstract class PersonaBuilder<T> : IPersonaBuilder<T> where T : PersonaModel
    {
        protected T _persona;

        public PersonaBuilder()
        {
            Reset();
        }

        public virtual void Reset()
        {
            _persona = null;
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

        public virtual IPersonaBuilder<T> SetRazonSocial(string razonSocial)
        {
            _persona.RazonSocial = razonSocial;
            return this;
        }

        public virtual IPersonaBuilder<T> SetCUIT(string cuit)
        {
            _persona.CUIT = cuit;
            return this;
        }

        public virtual IPersonaBuilder<T> SetDomicilio(string domicilio)
        {
            _persona.DomicilioComercial = domicilio;
            return this;
        }

        public virtual IPersonaBuilder<T> SetCondicionIVA(string condicionIVA)
        {
            _persona.CondicionIVA = condicionIVA;
            return this;
        }

        public virtual IPersonaBuilder<T> SetDatos(string razonSocial, string cuit)
        {
            return SetRazonSocial(razonSocial).SetCUIT(cuit);
        }

        public virtual IPersonaBuilder<T> SetDatos(string razonSocial, string cuit, string domicilio)
        {
            return SetDatos(razonSocial, cuit).SetDomicilio(domicilio);
        }

        public virtual IPersonaBuilder<T> SetDatos(string razonSocial, string cuit, string domicilio, string condicionIVA)
        {
            return SetDatos(razonSocial, cuit, domicilio).SetCondicionIVA(condicionIVA);
        }
    }
}