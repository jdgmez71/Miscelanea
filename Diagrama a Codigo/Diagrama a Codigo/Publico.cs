using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Publico
    {
        private char IdPlacaBlanca;
        private string TipodeServicio;
        public Publico(char IdPlacaBlanca, string TipodeServicio)
        {
            this.IdPlacaBlanca = IdPlacaBlanca;
            this.TipodeServicio = TipodeServicio;
        }

        public void setIdPlacaBlanca(char IdPlacaBlanca)
        {
            this.IdPlacaBlanca = IdPlacaBlanca;
        }
        public char getIdPlacaBlanca()
        {
            return IdPlacaBlanca;
        }
        public void setTipodeServicio(string TipodeServicio)
        {
            this.TipodeServicio = TipodeServicio;    
        }
        public string getTipodeServicio()
        {
            return TipodeServicio;
        }
        
    }
}
