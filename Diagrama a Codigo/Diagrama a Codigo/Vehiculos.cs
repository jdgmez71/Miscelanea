using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_a_Codigo
{
    internal class Vehiculos
    {
        private string Nombre;

        private string Serial;

        private string Marca;

        private double Precio;

        private string Color;

        private int Capacidad;

        private string Motor;

        public Vehiculos()
        {
            this.Nombre = "Verde";
            this.Serial = "4MRFO247859MGI";
            this.Marca = "Chevrolet";
            this.Precio = 2800;
            this.Color = "Azul";
            this.Capacidad = 4;
            this.Motor = "Motor de Diesel";
        }
        public void setNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public string getNombre()
        {
            return "El nombre del vehiculo es: " + Nombre;
        }
        public void setSerial(string Serial)
        {
            this.Serial = Serial;
        }
        public string getSerial()
        {
            return "El serial del vehiculo es: " + Serial;
        }
        public void setMarca(string Marca)
        {
            this.Marca = Marca;
        }
        public string getMarca()
        {
            return Marca;
        }
        public void setPrecio(double Precio)
        {
            this.Precio= Precio;
        }
        public double getPrecio()
        {
            return Precio;
        }
        public void setColor(string Color)
        {
            this.Color = Color;
        }
        public string getColor()
        {
            return Color;
        }
        public void setCapacidad(int Capacidad)
        {
            this.Capacidad = Capacidad;
        }
        public int getCapacidad()
        {
            return Capacidad;
        }
        public void setMotor(string Motor)
        {
            this.Motor = Motor;
        }
        public string getMotor()
        {
            return Motor;
        }       
    }
}
