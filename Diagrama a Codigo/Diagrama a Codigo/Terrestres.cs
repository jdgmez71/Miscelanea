using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Terrestres
        
    {
        private int Ruedas;
        private int Cambios;
        public Terrestres  ()
        {
            this.Ruedas = 4;
            this.Cambios = 6;
        }
        public void setRuedas(int Ruedas)
        {
            this.Ruedas = Ruedas;
        }
        public string getRuedas()
        {
            return "La cantidad de ruedas que posee el vehiculo son: "+ Ruedas;
        }
        public void setCambios(int Cambios)
        {
            this.Cambios = Cambios;
        }
        public string getCambios()
        {
            return "El vehiculo cuenta con " + Cambios + " cambios";
        }
    }                       
}
