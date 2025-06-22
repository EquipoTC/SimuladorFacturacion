using SimuladorFacturacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Interfaces
{
    public interface IBuilder<TOutput>
    {
        TOutput Build();
        void Reset();
    }
}
