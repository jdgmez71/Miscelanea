using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Carro
    {
        private string Carroceria;
        private string Chasis;

        public Carro()
        {
            this.Carroceria = "Sedan";
            this.Chasis = "Monocasco";
        }
        public void setCarroceria(string Carroceria)
        {
            this.Carroceria = Carroceria;
        }
        public string getCarroceria()
        {
            return "El carro cuenta con una carroceria: " + Carroceria;
        }
        public void setChasis(string Chasis)
        {
            this.Chasis = Chasis;
        }
        public string getChasis()
        {
            return "El carro cuenta con un chasis tipo " + Chasis;
        }
    }
}
