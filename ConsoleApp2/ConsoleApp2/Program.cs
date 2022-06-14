using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
                Pagos pagos = new Pagos();
                Console.WriteLine("Welcome to Payroll");
                Console.WriteLine("1. Add Employee \n2. Exit the program");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":                        
                        {                            
                            do
                            {
                                pagos.Calculos();
                                pagos.Impresiones();
                                Console.WriteLine("\n1.Do you want to add another employee?");
                                Console.WriteLine("2.Exit the program");
                                menu = Console.ReadLine();
                            }while (menu != "2");
                        break;
                        }
                    case "2":
                        {                            
                            Console.WriteLine("Exit the program");                            
                            break;
                        }
                   default:
                    {
                        Console.WriteLine("Typing Error");
                        break;
                    }
                }
            
        }

    }
}
