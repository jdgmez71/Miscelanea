using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Moto
    {
        private string Cilindraje;
        private string Cuadro;
        public Moto()
        {
            this.Cilindraje = "Cilindraje Medio";
            this.Cuadro = "Doble Cuna";

        }
        public void setCilindraje(string Cilindraje)
        {
            this.Cilindraje = Cilindraje;
        }
        public string getCilindraje()
        {
            return Cilindraje;
        }
        public void setCuadro(string Cuadro)
        {
            this.Cuadro = Cuadro;
        }
        public string getCuadro()
        {
            return Cuadro;
        }
        public void setInfoMoto(string Cilindraje, string Cuadro)
        {
            this.Cilindraje = Cilindraje;
            this.Cuadro = Cuadro;
        }
        public string getInfoMoto()
        {
            return "La moto cuenta con un " + Cilindraje + " y un cuadro de " + Cuadro;
        }
    }
}
