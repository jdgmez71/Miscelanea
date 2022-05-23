using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Bus
    {
        private int TarifasFijas;
        public void setTarifasFijas(int TarifasFijas)
        {
            this.TarifasFijas = TarifasFijas;
        }
        public int getTarifasFijas()
        {
            return TarifasFijas;
        }

    }
}
