using SimuladorFacturacion.Core.Domain.Models;
using SimuladorFacturacion.Core.Domain.Interfaces.Builders;
using System;

namespace SimuladorFacturacion.Infraestructure.Builders
{
    public class EmisorBuilder : PersonaBuilder<EmisorModel, IEmisorBuilder>, IEmisorBuilder
    {
        public IEmisorBuilder SetFechaInicioActividades(DateTime fecha)
        {
            _persona.FechaInicioActividades = fecha;
            return this;
        }

        public IEmisorBuilder SetDatos(string razonSocial, string cuit, string domicilio, string condicionIVA, DateTime fechaInicioActividades)
        {
            SetDatos(razonSocial, cuit, domicilio, condicionIVA);
            return SetFechaInicioActividades(fechaInicioActividades);
        }
    }
}