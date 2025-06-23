using SimuladorFacturacion.Core.Domain.Models;
using SimuladorFacturacion.Interfaces;

namespace SimuladorFacturacion.Infraestructure.Builders
{
    public class ImporteBuilder : IImporteBuilder
    {
        private ImporteModel _importes;

        public ImporteBuilder() => Reset();

        public ImporteModel Build()
        {
            var result = _importes;
            Reset();
            return result;
        }

        public ImporteModel GetProduct()
        {
            return _importes;
        }

        public void Reset()
        {
            _importes = new ImporteModel();
        }

        public IImporteBuilder SetIVA27(decimal iva27)
        {
            _importes.IVA27 = iva27;
            return this;
        }

        public IImporteBuilder SetIVA21(decimal iva21)
        {
            _importes.IVA21 = iva21;
            return this;
        }

        public IImporteBuilder SetIVA10(decimal iva10)
        {
            _importes.IVA10 = iva10;
            return this;
        }

        public IImporteBuilder SetOtrosTributos(decimal otrosTributos)
        {
            _importes.OtrosTributos = otrosTributos;
            return this;
        }

        public IImporteBuilder SetNetoGravado(decimal netoGravado)
        {
            _importes.NetoGravado = netoGravado;
            return this;
        }
    }
}