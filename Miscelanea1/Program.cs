using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static double n1, n2, n3, n4;
        static void Main(string[] args)
        {
            string linea;
            do
            {

                linea = null;

                Console.WriteLine("Menu Principal");
                Console.WriteLine("Seleccione el metodo: \n1. Operadores  \n2. Condicionales \n3. Ciclos \n4. Salida");

                String menu = null;
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.WriteLine("\n1. OPERADORES");


                        Console.WriteLine("Seleccione el tipo de operacion: \n1. Area de un Triangulo " + "\n2. Suma " + "\n3. Numero elevado al cuadrado " + "\n4. Euros a Dolares" + "\n5. Calcular Area y Perimetro de un Cuadrado" + "\n6. Determinar Area y Volumen de un Cilindro" + "\n7. Determinar Longitud de la Circunferencia y Area del Circulo" + "\n8. Promedio de tres numeros ");
                        String Operadores = null;
                        Operadores = Console.ReadLine();
                        switch (Operadores)
                        {
                            case "1":
                                {
                                    Ejercicios.AreaTriangulo();
                                    break;
                                }

                            case "2":
                                {
                                    Ejercicios.SUMA();
                                    break;
                                }

                            case "3":
                                {
                                   Ejercicios.Numeroalcuadrado();
                                    break;
                                }

                            case "4":
                                {
                                    Ejercicios.EurosDolares();
                                    break;
                                }

                            case "5":
                                {
                                    Ejercicios.AreaCuadrado();
                                    break;
                                }

                            case "6":
                                {
                                    Ejercicios.Areayvolumen();
                                    break;
                                }
                            case "7":
                                {
                                    Ejercicios.Longitudyarea();

                                    break;
                                }
                            case "8":
                                {
                                    Ejercicios.Promedio();
                                    break;
                                }

                            default:
                                Console.WriteLine("Error la opcion no existe, regresando al menu.");
                                break;
                        }

                        break;

                    case "2":
                        {
                            Console.WriteLine("\n2. CONDICIONALES");
                            Console.WriteLine("");
                            Console.WriteLine("\n1. Numero Positivo o Negativo \n2. Numero mayor y menor \n3. Ingresar tres numeros positivos para saber cual es mayor y menor \n4. Dos números A y B, sumarlos si A es menor que B o sino restarlos \n5. Dos números A y B encontrar el cociente \n6. Dos números sumarlos si alguno es negativo, sino multiplicarlos  \n7. Determinar si un año es bisiesto o no");
                            String Condicionales = null;
                            Condicionales = Console.ReadLine();
                            switch (Condicionales)
                            {
                                case "1":
                                    {
                                        Ejercicios.PosioNega();
                                        break;
                                    }

                                case "2":
                                    {
                                        Ejercicios.MayorOMenor();
                                        break;
                                    }
                                case "3":
                                    {
                                        Ejercicios.TresNum();                                    
                                        break;
                                    }
                                case "4":
                                    {
                                        Ejercicios.AyB();
                                        
                                        break;
                                    }
                                case "5":
                                    {
                                        Ejercicios.AyB2();
                                        break;
                                    }
                                case "6":
                                    {
                                        Ejercicios.Dosnumeros();
                                        break;
                                    }
                                case "7":
                                    {
                                        Ejercicios.Añobisiesto();   

                                        break;
                                    }
                                default:
                                    Console.WriteLine("Error la opcion no existe, regresando al menu.");
                                    break;
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("\n3. Ciclos");
                            Console.WriteLine("Seleccione el tipo de operacion: \n1. Todos los multiplos de 3, entre 1 a 100 \n2. Numeros impares entre 0 a 100 \n3. Numeros pares entre 1 a 100 \n4. Numeros cuadrados del 1 al 30 \n5. Suma de los cuadrados de los cien primeros numeros naturales \n6. Dados dos números naturales, mostrar todos los números comprendidos entre ellos en secuencia ascendente  \n7.Suma de todos los numeros digitados hasta el ingreso de 0");
                            String Ciclos = null;
                            Ciclos = Console.ReadLine();
                            switch (Ciclos)
                            {
                                case "1":
                                    {
                                        Ejercicios.Multi3();
                                        break;
                                    }
                                case "2":
                                    {
                                        Ejercicios.NumImp();
                                        break;
                                    }
                                case "3":
                                    {
                                        Ejercicios.NumPar();
                                        break;
                                    }
                                case "4":
                                    {
                                        Ejercicios.NumCuad();
                                        break;
                                    }
                                case "5":
                                    {
                                        Ejercicios.SumaCuadra();
                                        break;
                                    }
                                case "6":
                                    {
                                       Ejercicios.NumerosNatu();    

                                        break;
                                    }
                                case "7":
                                    {
                                        Ejercicios.SumaTodo();  

                                        break;
                                    }
                                default:
                                    Console.WriteLine("Error la opcion no existe, regresando al menu.");
                                    break;
                            }

                            break;

                        }

                    case "4":
                        {
                            Console.WriteLine("Esta saliendo del programa, se reiniciara. ");
                            break;
                        }

                    default:
                        Console.WriteLine("Error la opcion no existe, regresando al menu.");
                        break;
                }
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("");
            } while (linea != "ayuda");

            Console.WriteLine("Has ingresado: \t" + linea);
        }
    }
}
