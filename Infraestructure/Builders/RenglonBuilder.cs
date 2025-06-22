using SimuladorFacturacion.Interfaces;

namespace SimuladorFacturacion.Infraestructure.Builders
{
    public class RenglonBuilder : IRenglonBuilder
    {
        private RenglonModel _renglon;

        public RenglonBuilder() => Reset();

        public RenglonModel Build()
        {
            var result = _renglon;
            Reset();
            return result;
        }

        public void Reset()
        {
            _renglon = new RenglonModel();
        }

        public IRenglonBuilder SetCodigo(string codigo)
        {
            _renglon.Codigo = codigo;
            return this;
        }

        public IRenglonBuilder SetProductoServicio(string productoServicio)
        {
            _renglon.ProductoServicio = productoServicio;
            return this;
        }

        public IRenglonBuilder SetCantidad(decimal cantidad)
        {
            _renglon.Cantidad = cantidad;
            return this;
        }

        public IRenglonBuilder SetUnidadMedida(string unidadMedida)
        {
            _renglon.UnidadMedida = unidadMedida;
            return this;
        }

        public IRenglonBuilder SetPrecioUnitario(decimal precio)
        {
            _renglon.PrecioUnitario = precio;
            return this;
        }

        public IRenglonBuilder SetPorcentajeBonificacion(decimal porcentaje)
        {
            _renglon.PorcentajeBonificacion = porcentaje;
            return this;
        }

        public IRenglonBuilder SetAlicuotaIVA(decimal alicuota)
        {
            _renglon.AlicuotaIVA = alicuota;
            return this;
        }

        public IRenglonBuilder SetDatos(string codigo, string productoServicio, decimal cantidad, string unidadMedida, decimal precioUnitario)
        {
            _renglon.Codigo = codigo;
            _renglon.ProductoServicio = productoServicio;
            _renglon.Cantidad = cantidad;
            _renglon.UnidadMedida = unidadMedida;
            _renglon.PrecioUnitario = precioUnitario;
            return this;
        }

        public IRenglonBuilder SetDatos(string codigo, string productoServicio, decimal cantidad, string unidadMedida, decimal precioUnitario, decimal porcentajeBonificacion)
        {
            SetDatos(codigo, productoServicio, cantidad, unidadMedida, precioUnitario);
            _renglon.PorcentajeBonificacion = porcentajeBonificacion;
            return this;
        }

        public IRenglonBuilder SetDatos(string codigo, string productoServicio, decimal cantidad, string unidadMedida, decimal precioUnitario, decimal porcentajeBonificacion, decimal alicuotaIVA)
        {
            SetDatos(codigo, productoServicio, cantidad, unidadMedida, precioUnitario, porcentajeBonificacion);
            _renglon.AlicuotaIVA = alicuotaIVA;
            return this;
        }
    }
}