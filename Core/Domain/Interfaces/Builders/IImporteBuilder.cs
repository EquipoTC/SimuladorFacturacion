using SimuladorFacturacion.Core.Domain.Models;

namespace SimuladorFacturacion.Core.Domain.Interfaces.Builders
{
    public interface IImporteBuilder : IBuilder<ImporteModel>
    {
        IImporteBuilder SetIVA27(decimal iva27);
        IImporteBuilder SetIVA21(decimal iva21);
        IImporteBuilder SetIVA10(decimal iva10);
        IImporteBuilder SetOtrosTributos(decimal otrosTributos);
        IImporteBuilder SetNetoGravado(decimal netoGravado);
    }
}