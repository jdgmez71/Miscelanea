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
        public Bus() 
        {
            TarifasFijas = 2000;
        }
        public void setTarifasFijas(int TarifasFijas)
        {
            this.TarifasFijas = TarifasFijas;
        }
        public string getTarifasFijas()
        {
            return "La tarifa del bus cuesta: " + TarifasFijas;
        }

    }
}
