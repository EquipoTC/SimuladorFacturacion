using SimuladorFacturacion.Core.Domain.Models;
using System;

namespace SimuladorFacturacion.Core.Domain.Interfaces.Builders
{
    public interface IEmisorBuilder : IPersonaBuilder<EmisorModel, IEmisorBuilder>
    {
        IEmisorBuilder SetFechaInicioActividades(DateTime fecha);
        IEmisorBuilder SetDatos(string razonSocial, string cuit, string domicilio, string condicionIVA, DateTime fechaInicioActividades);
    }
}