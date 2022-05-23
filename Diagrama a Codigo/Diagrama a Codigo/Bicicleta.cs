using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Bicicleta
    {
        private string Marco;

        public Bicicleta()
        {
            this.Marco = "Fixie Innova K2";
        }
        public void setMarco(string Marco)
        {
            this.Marco = Marco;
        }
        public string getMarco()
        {
            return "La bicicleta cuenta con un marco " + Marco;
        }
    }
}
