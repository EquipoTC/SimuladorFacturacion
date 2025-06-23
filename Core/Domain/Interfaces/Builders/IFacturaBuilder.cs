using SimuladorFacturacion.Core.Domain.Models;
namespace SimuladorFacturacion.Core.Domain.Interfaces.Builders
{
    public interface IFacturaBuilder : IBuilder<FacturaModel>
    {
        IEmisorBuilder GetEmisor();
        IReceptorBuilder GetReceptor();
        IComprobanteBuilder GetComprobante();
        IRenglonBuilder GetRenglon();
        IImporteBuilder GetImporte();
        IFacturaBuilder AddRenglon(RenglonModel renglon);
        IFacturaBuilder DeleteRenglon(int index);
        IFacturaBuilder CleanRenglones();
        IFacturaBuilder SetEmisor(EmisorModel emisor);
        IFacturaBuilder SetReceptor(ReceptorModel receptor);
        IFacturaBuilder SetComprobante(ComprobanteModel comprobante);
        IFacturaBuilder SetImporte(ImporteModel importes);
    }
}
