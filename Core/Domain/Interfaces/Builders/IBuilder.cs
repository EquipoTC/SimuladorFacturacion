namespace SimuladorFacturacion.Core.Domain.Interfaces.Builders
{
    public interface IBuilder<TOutput>
    {
        TOutput Build();
        TOutput GetProduct();
        void Reset();
    }
}
