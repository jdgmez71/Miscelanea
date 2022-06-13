using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            Datos datos = new Datos();
            Console.WriteLine("Insert your number of document: ");
            datos.setDocument(int.Parse(Console.ReadLine()));
            Console.WriteLine("Insert your FirsName: ");
            datos.setFirstName(Console.ReadLine());
            Console.WriteLine("Insert your LastName: ");
            datos.setLastName(Console.ReadLine());
            Console.WriteLine("Insert your Salary: ");
            datos.setSalary(double.Parse(Console.ReadLine()));
            Console.WriteLine("Insert your days worked: ");
            datos.setDaysWorked(int.Parse(Console.ReadLine()));
            Console.WriteLine(datos.Operation());

        }
    }
}
