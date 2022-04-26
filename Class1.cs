using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Menu Principal");
            Console.WriteLine("Seleccione el metodo: \n1. Operadores  \n2. Condicionales \n3. Ciclos");
            
            String menu = null;
            menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    Console.WriteLine("\n1. OPERADORES");
                    

                    Console.WriteLine("Seleccione el tipo de operacion: \n1. Area de un Triangulo " + "\n2. Suma " + "\n3. Numero elevado al cuadrado " + "\n4. Euros a Dolares" + "\n5. Calcular Area y Perimetro de un Cuadrado" + "\n6. Determinar Area y Volumen de un Cilindro" + "\n7. Determinar Longitud de la Circunferencia y Area del Circulo" + "\n8. Promedio de tres numeros " );
                    String Operadores = null;
                    Operadores = Console.ReadLine();
                    switch (Operadores)
                    {
                        case "1":
                            {
                                Console.WriteLine("Calcular Area de un Triangulo");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese dos valores enteros");
                                Console.WriteLine("Ingrese el valor de la base: ");
                                double base_t = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese el valor de la altura: ");
                                double altura = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El Area del triangulo es " + ((base_t * altura)/2));
                                break;
                            }

                        case "2":
                            {
                                Console.WriteLine("Suma");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese dos valores enteros");
                                Console.WriteLine("Ingrese el primer valor:");
                                double num3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese el segundo valor: ");
                                double num4 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El resultado de la suma es: " + (num3 + num4));
                                break;
                            }

                        case "3":
                            {
                                Console.WriteLine("Numero elevado al Cuadrado");
                                Console.WriteLine("Ingrese el valor:");
                                double elevado = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El numero elevado al cuadrado es: " + ( elevado * elevado));
                                break;
                            }

                        case "4":
                            {
                                Console.WriteLine("Euros a Dolares");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese el valor que quiera convertir: ");
                                double Convertido = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El resultado de la conversion es: " + (Convertido * 1.06) + " USD $");
                                break;
                            }

                        case "5":
                            {
                                Console.WriteLine("Calcular Area y Perimetro de un Cuadrado");
                                Console.WriteLine("");
                                Console.WriteLine("Inserte el valor del lado de un Cuadrado");
                                double cuadrado = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El resultado del area es: " + (cuadrado * cuadrado));
                                Console.WriteLine("El resultado del perimetro es: " + (cuadrado * 4));
                                break;
                            }
                            
                        case "6":
                            {
                                Console.WriteLine("Determinar Area y Volumen de un Cilindro");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese el valor del Radio del Cilindro: ");
                                int radio = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese el valor de la Altura del Cilindro: ");
                                int altura = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El resultado del Area del cilindro es: " + ((2*3.1416)* (radio * altura) + (2* 3.1416)*(radio * radio)));
                                Console.WriteLine("El resultado del Volumen del cilindro es: " + ((radio * radio * 3.1416) * (altura)));
                                break;
                            }
                        case "7":
                            {
                                Console.WriteLine("Determinar la Longitud y Area de un Circulo");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese el valor del Radio del Cilindro: ");
                                double radio = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("El resultado de la longitud de la Circunferencia es: " + ((2 * 3.1416) * (radio)));
                                Console.WriteLine("El resultado del Area del Circulo es: " + ((3.1416) * (radio * radio)));

                                break;
                            }
                        case "8":
                            {
                                Console.WriteLine("Promedio de tres numeros");
                                Console.WriteLine("");
                                Console.WriteLine("Ingrese el primer valor: ");
                                int numero1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese el segundo valor: ");
                                int numero2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese el tercer valor: ");
                                int numero3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("La suma de los numeros es: " + (numero1 + numero2 + numero3));
                                Console.WriteLine("El promedio de los numeros es: " + (numero1 + numero2 + numero3) / (3));
                                break;
                            }

                        default:
                            Console.WriteLine("Error, la opcion no existe");
                            break;
                    }

                break;
               
            }
            
           
        }      
    }
}
