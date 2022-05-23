using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Taxi
    {
        private int TarifasReguladas;
        public void setTarifasReguladas(int TarifasReguladas)
        {
            this.TarifasReguladas = TarifasReguladas;
        }
        public int getTarifasReguladas()
        {
            return TarifasReguladas;
        }

    }
}
