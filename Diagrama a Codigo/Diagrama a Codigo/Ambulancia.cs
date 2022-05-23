using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Ambulancia
    {
        private string EquipoMedico;
        public Ambulancia()
        {
            this.EquipoMedico = "Monitor de signos vitales.\nVentilador Mécanico.\nDesfibrilador.\nBombas de infusión.\nGlucometro.\nLaringoscopio.Tubos endotraqueales.\nGuias de Intubación";
        }
        public void setEquipoMedico(string EquipoMedico)
        {
            this.EquipoMedico = EquipoMedico;
        }
        public string getEquipoMedico()
        {
            return "El equipo medico con el que cuenta la ambulancia es el siguiente: " + EquipoMedico;
        }
    }
}      

