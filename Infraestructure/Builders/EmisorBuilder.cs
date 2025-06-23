using SimuladorFacturacion.Core.Domain.Models;
using SimuladorFacturacion.Interfaces;
using System;

namespace SimuladorFacturacion.Builders
{
    public class EmisorBuilder : PersonaBuilder<EmisorModel, IEmisorBuilder>
    {
        public IEmisorBuilder SetFechaInicioActividades(DateTime fecha)
        {
            _persona.FechaInicioActividades = fecha;
            return (IEmisorBuilder)this;
        }

        public IEmisorBuilder SetDatos(string razonSocial, string cuit, string domicilio, string condicionIVA, DateTime fechaInicioActividades)
        {
            SetDatos(razonSocial, cuit, domicilio, condicionIVA);
            return SetFechaInicioActividades(fechaInicioActividades);
        }
    }
}