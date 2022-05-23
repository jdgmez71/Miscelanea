using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Particular
    {
        private string IdPlacaAmarilla;
        public void setIdPlacaAmarilla(string IdPlacaAmarilla)
        {
            this.IdPlacaAmarilla = IdPlacaAmarilla;
        }
        public string getIdPlacaAmarilla()
        {
            return " " + IdPlacaAmarilla;
        }
    }
}
