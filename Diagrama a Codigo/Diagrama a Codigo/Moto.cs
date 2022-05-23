using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Moto
    {
        private int Cilindraje;
        private char Cuadro;

        public void setCilindraje(int Cilindraje)
        {
            this.Cilindraje = Cilindraje;
        }
        public int getCilindraje()
        {
            return Cilindraje;
        }
        public void setCuadro(char Cuadro)
        {
            this.Cuadro = Cuadro;
        }
        public char getCuadro()
        {
            return Cuadro;
        }
    }
}
