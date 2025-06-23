using SimuladorFacturacion.Core.Domain.Models;
using SimuladorFacturacion.Core.Domain.Interfaces.Builders;
namespace SimuladorFacturacion.Infraestructure.Builders
{
    public class FacturaBuilder : IFacturaBuilder
    {
        private FacturaModel _factura;

        private readonly IEmisorBuilder _emisorBuilder;
        private readonly IReceptorBuilder _receptorBuilder;
        private readonly IComprobanteBuilder _comprobanteBuilder;
        private readonly IRenglonBuilder _renglonBuilder;
        private readonly IImporteBuilder _importeBuilder;

        public FacturaBuilder(
            IEmisorBuilder emisorBuilder, IReceptorBuilder receptorBuilder,
            IRenglonBuilder renglonBuilder, IComprobanteBuilder comprobanteBuilder,
            IImporteBuilder importeBuilder)
        {
            _emisorBuilder = emisorBuilder;
            _receptorBuilder = receptorBuilder;
            _comprobanteBuilder = comprobanteBuilder;
            _renglonBuilder = renglonBuilder;
            _importeBuilder = importeBuilder;
            Reset();
        }
        public FacturaModel Build()
        {
            return _factura;
        }

        public void Reset()
        {
            _factura = new FacturaModel();
        }

        public IEmisorBuilder GetEmisor() => _emisorBuilder;
        public IReceptorBuilder GetReceptor() => _receptorBuilder;
        public IComprobanteBuilder GetComprobante() => _comprobanteBuilder;
        public IRenglonBuilder GetRenglon() => _renglonBuilder;
        public IImporteBuilder GetImporte() => _importeBuilder;

        public IFacturaBuilder AddRenglon(RenglonModel renglon)
        {
            _factura.Renglones.Add(renglon);
            return this;
        }

        public IFacturaBuilder DeleteRenglon(int index)
        {
            if (index >= 0 && index < _factura.Renglones.Count)
            {
                _factura.Renglones.RemoveAt(index);
            }
            return this;
        }

        public IFacturaBuilder CleanRenglones()
        {
            _factura.Renglones.Clear();
            return this;
        }

        public IFacturaBuilder SetEmisor(EmisorModel emisor)
        {
            _factura.Emisor = emisor;
            return this;
        }

        public IFacturaBuilder SetReceptor(ReceptorModel receptor)
        {
            _factura.Receptor = receptor;
            return this;
        }

        public IFacturaBuilder SetComprobante(ComprobanteModel comprobante)
        {
            _factura.Comprobante = comprobante;
            return this;
        }

        public IFacturaBuilder SetImporte(ImporteModel importes)
        {
            _factura.Importes = importes;
            return this;
        }
    }
}