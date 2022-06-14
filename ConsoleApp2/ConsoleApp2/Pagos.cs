using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pagos
    {
        Datos datos = new Datos();

        
        public void Calculos()
        {
            try
            {
                Console.WriteLine("Insert your first name: ");
                datos.FirstName1 = Console.ReadLine();
                Console.WriteLine("Insert your last name: ");
                datos.LastName1 = Console.ReadLine();
                Console.WriteLine("Insert your document: ");
                datos.Document1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insert your salary: ");
                datos.Salary1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Insert your Worked Days: ");
                datos.WorkedDays1 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Typing Error");
            }
                datos.TotalAccurred1 = datos.Salary1 / 30 * datos.WorkedDays1;
                datos.SubsidyHealth1 = datos.TotalAccurred1 * 0.04;
                datos.Pension1 = datos.TotalAccurred1 * 0.04;
                
                if (datos.SubsidyTransport1 <= 2000000)
                {
                  datos.SubsidyTransport1 = 117172 / 30 * datos.WorkedDays1;
                  datos.TotalAccurred1 = datos.TotalAccurred1 + datos.SubsidyTransport1;
                }
                else
                {
                  datos.TotalAccurred1 = datos.TotalAccurred1;
                }     
        }

        public void Impresiones()
        {
            Console.WriteLine("\n----------------------------------------------------------------------");
            Console.WriteLine("First Name: " + datos.FirstName1);
            Console.WriteLine("Last Name: " + datos.LastName1);
            Console.WriteLine("Document: " + datos.Document1);
            Console.WriteLine("Salary: " + datos.Salary1);
            Console.WriteLine("Worked Days: " + datos.WorkedDays1);
            Console.WriteLine("Subsidy Transport: " + datos.SubsidyTransport1);
            Console.WriteLine("Subsidy Health: " + datos.SubsidyHealth1);
            Console.WriteLine("Pension: " + datos.Pension1);
            Console.WriteLine("Total Accurred is: " + datos.TotalAccurred1);
        }
    }
}
