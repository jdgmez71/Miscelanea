using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        static bool bisiesto(int año)
        {
            if (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0))
            return true;
            return false;
        }
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
                                        Console.WriteLine("\nCalcular Area de un Triangulo");
                                        Console.WriteLine("");
                                        Console.WriteLine("Ingrese dos valores enteros");
                                        Console.WriteLine("Ingrese el valor de la base: ");
                                        double base_t = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Ingrese el valor de la altura: ");
                                        double altura = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("El Area del triangulo es " + ((base_t * altura) / 2));
                                        break;
                                    }

                                case "2":
                                    {
                                        Console.WriteLine("\nSuma");
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
                                        Console.WriteLine("\nNumero elevado al Cuadrado");
                                        Console.WriteLine("Ingrese el valor:");
                                        double elevado = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("El numero elevado al cuadrado es: " + (elevado * elevado));
                                        break;
                                    }

                                case "4":
                                    {
                                        Console.WriteLine("\nEuros a Dolares");
                                        Console.WriteLine("");
                                        Console.WriteLine("Ingrese el valor que quiera convertir: ");
                                        double Convertido = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("El resultado de la conversion es: " + (Convertido * 1.06) + " USD $");
                                        break;
                                    }

                                case "5":
                                    {
                                        Console.WriteLine("\nCalcular Area y Perimetro de un Cuadrado");
                                        Console.WriteLine("");
                                        Console.WriteLine("Inserte el valor del lado de un Cuadrado");
                                        double cuadrado = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("El resultado del area es: " + (cuadrado * cuadrado));
                                        Console.WriteLine("El resultado del perimetro es: " + (cuadrado * 4));
                                        break;
                                    }

                                case "6":
                                    {
                                        Console.WriteLine("\nDeterminar Area y Volumen de un Cilindro");
                                        Console.WriteLine("");
                                        Console.WriteLine("Ingrese el valor del Radio del Cilindro: ");
                                        int radio = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Ingrese el valor de la Altura del Cilindro: ");
                                        int altura = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("El resultado del Area del cilindro es: " + ((2 * 3.1416) * (radio * altura) + (2 * 3.1416) * (radio * radio)));
                                        Console.WriteLine("El resultado del Volumen del cilindro es: " + ((radio * radio * 3.1416) * (altura)));
                                        break;
                                    }
                                case "7":
                                    {
                                        Console.WriteLine("\nDeterminar la Longitud y Area de un Circulo");
                                        Console.WriteLine("");
                                        Console.WriteLine("Ingrese el valor del Radio del Cilindro: ");
                                        double radio = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("El resultado de la longitud de la Circunferencia es: " + ((2 * 3.1416) * (radio)));
                                        Console.WriteLine("El resultado del Area del Circulo es: " + ((3.1416) * (radio * radio)));

                                        break;
                                    }
                                case "8":
                                    {
                                        Console.WriteLine("\nPromedio de tres numeros");
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
                                            Console.WriteLine("\nNumero Positivo o Negativo");
                                            Console.WriteLine("");
                                            Console.WriteLine("Ingrese el numero: ");
                                            int numero = Convert.ToInt32(Console.ReadLine());
                                            if (numero > 0)
                                            {
                                                Console.WriteLine("El numero " + numero + " es un numero positivo");
                                            }
                                            else
                                            {
                                                Console.WriteLine("El numero " + numero + " es un numero negativo");
                                            }
                                            break;
                                        }

                                    case "2":
                                        {
                                            Console.WriteLine("\nNumero mayor y menor");
                                            Console.WriteLine("");
                                            Console.WriteLine("Ingrese el primer numero: ");
                                            int numero1 = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Ingrese el segundo numero: ");
                                            int numero2 = Convert.ToInt32(Console.ReadLine());
                                            if (numero2 < numero1)
                                            {
                                                Console.WriteLine("El numero mayor es: " + numero1);
                                            }
                                            else
                                            {
                                                Console.WriteLine("El numero menor es: " + numero1);
                                            }

                                            if (numero1 < numero2)
                                            {
                                                Console.WriteLine("El numero mayor es: " + numero2);
                                            }
                                            else
                                            {
                                                Console.WriteLine("El numero menor es: " + numero2);
                                            }
                                            break;
                                        }
                                    case "3":
                                        {

                                            Console.WriteLine("\nIngresar tres numeros positivos para saber cual es mayor y menor: ");
                                            Console.WriteLine("");
                                            int num1, mayor1 = 0, menor1 = 0;


                                            for (int i = 0; i < 3; i++)
                                            {

                                                Console.WriteLine("Ingrese un numero: ");
                                                num1 = int.Parse(Console.ReadLine());


                                                if (i == 0)
                                                {
                                                    mayor1 = num1;
                                                    menor1 = num1;
                                                }
                                                else if (i != 0)
                                                {
                                                    if (num1 < menor1)
                                                    {
                                                        menor1 = num1;
                                                    }
                                                    if (num1 > mayor1)
                                                    {
                                                        mayor1 = num1;
                                                    }


                                                }

                                            }
                                            Console.WriteLine("El numero mayor es: " + mayor1);
                                            Console.WriteLine("El numero menor es: " + menor1);
                                            Console.ReadKey();
                                            break;
                                        }
                                    case "4":
                                        {
                                            Console.WriteLine("\nDos números A y B, sumarlos si A es menor que B o sino restarlos.");
                                            Console.WriteLine("Ingrese el valor del numero A: ");
                                            int a = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Ingrese el valor del numero B: ");
                                            int b = Convert.ToInt32(Console.ReadLine());
                                            int suma;
                                            int resta;
                                            if (a < b)
                                            {
                                                suma = a + b;
                                                Console.WriteLine("La suma de ambos valores es: " + suma);
                                            }
                                            else if (a > b)
                                            {
                                                resta = a - b;
                                                Console.WriteLine("La resta de ambos valores es: " + resta);
                                            }
                                            break;
                                        }
                                    case "5":
                                        {
                                            Console.WriteLine("\nDos números A y B encontrar el cociente");
                                            double numero1, numero2, division;
                                            Console.WriteLine("Ingrese el valor de A: ");
                                            numero1 = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Ingrese el valor de B: ");
                                            numero2 = Convert.ToDouble(Console.ReadLine());
                                            if (numero2 == 0)
                                            {
                                                Console.WriteLine("No se puede dividir entre cero");
                                            }
                                            else
                                            {
                                                division = numero1 / numero2;
                                                Console.WriteLine("El cociente de la division es: " + division);
                                            }
                                            break;
                                        }
                                    case "6":
                                        {
                                            Console.WriteLine("\nDos números sumarlos si alguno es negativo, sino multiplicarlos");
                                            double numero1, numero2, multiplicacion, suma1, suma;
                                            Console.WriteLine("Ingrese el valor de A: ");
                                            numero1 = (double)Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Ingrese el valor de B: ");
                                            numero2 = (double)Convert.ToDouble(Console.ReadLine());
                                            suma = numero2 + numero1;
                                            multiplicacion = numero1 * numero2;

                                            if (numero1 < 0)
                                            {                                               
                                               Console.WriteLine("La suma de ambos numeros es: " + suma);
                                            }
                                            else if(numero2 < 0)
                                            {
                                               Console.WriteLine("La suma de ambos numeros es: " + suma); 
                                            }
                                            else if (multiplicacion > 0)
                                            {                                                                                        
                                            Console.WriteLine("El resultado de la multiplicacion de ambos numeros es: " + multiplicacion);
                                            }
                                     
                                            break;
                                        }
                                    case "7":
                                        {                                           
                                            Console.WriteLine("\nDeterminar si un año es bisiesto o no");
                                            int x;                                            
                                            Console.WriteLine("Digite el año ");
                                            x = int.Parse(Console.ReadLine());
                                            if (bisiesto(x) == true)
                                            {
                                                Console.WriteLine("El año " + x + " es bisiesto");
                                            }
                                            else
                                            {
                                                Console.WriteLine("El año " + x + " no es bisiesto");
                                            }

                                            break;
                                        }
                                    default:
                                    Console.WriteLine("Error, la opcion no existe");
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
                                        Console.WriteLine("\nTodos los multiplos de 3, entre 1 a 100");
                                        int numero;
                                        Console.WriteLine("Los multiplos de 3 que hay entre 1 y 100 son: ");
                                        Console.WriteLine("");
                                        for (int i = 1; i <= 100; i++)
                                        {
                                            if (i % 3 == 0)
                                            {
                                                Console.WriteLine(i);
                                            }
                                        }                                       
                                     break;
                                    }
                                 case "2":
                                    {
                                        Console.WriteLine("\nNumeros impares entre 0 a 100");
                                        Console.WriteLine("son: ");                                 
                                        for (int numero = 1; numero <= 100; numero +=2)
                                        {
                                            Console.WriteLine(numero);
                                        }
                                        break;
                                    }
                                 case "3":
                                    {
                                        Console.WriteLine("\nNumeros pares entre 1 a 100");
                                        Console.WriteLine("son: ");
                                        for (int numero = 0; numero <= 100; numero +=2)
                                        {
                                            Console.WriteLine(numero);
                                        }
                                        break;
                                    }
                                 case "4":
                                    {
                                        Console.WriteLine("\nNumeros cuadrados del 1 al 30");
                                        Console.WriteLine("son: ");
                                        for (int numero = 1; numero <= 30; numero++)
                                        {
                                            Console.WriteLine("El numero cuadrado de " + numero + " es: " + Math.Pow(numero,2));
                                        }
                                        break;
                                    }
                                 case "5":
                                    {
                                        Console.WriteLine("\nSuma de los cuadrados de los cien primeros numeros naturales");
                                        int i;
                                        int cuadrado, numero1 = 1, suma = 0;
                                        for (i = 0; i <= 100; i++)
                                        {
                                            cuadrado = numero1 * i;
                                            cuadrado = cuadrado * i;
                                            suma = suma + cuadrado;
                                            Console.WriteLine("El cuadrado de " + i + " es: " + cuadrado);
                                        }
                                        Console.WriteLine("La suma de los cuadrados es: " + suma);
                                        break;
                                    }
                                 case "6":
                                    {
                                        Console.WriteLine("\nDados dos números naturales, mostrar todos los números comprendidos entre ellos en secuencia ascendente.");
                                        Console.WriteLine("Ingrese el primer numero: ");
                                        int numero = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Ingrese el segundo numero: ");
                                        int numero2 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("");

                                        Console.WriteLine("Los numeros comprendidos entre: " + numero + " y " + numero2 + " son: ");

                                        for (int i = numero + 1; i < numero2; i++)
                                        {
                                            Console.WriteLine(i);
                                        }
                                        break;
                                    }
                                 case "7":
                                    {
                                        Console.WriteLine("\nSuma de todos los numeros digitados hasta el ingreso de 0");
                                        int suma = 0, numero = 0;
                                        do
                                        {
                                            Console.WriteLine("Ingrese el numero que desea sumar: ");
                                            numero = Convert.ToInt32(Console.ReadLine());
                                            suma = suma + numero;
                                            Console.WriteLine("El resultado de la suma es: " + suma);

                                        } while (true);
                                        
                                        break;
                                    }
                                    default:
                                    Console.WriteLine("Error, la opcion no existe");
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
                        Console.WriteLine("Error, la opcion no existe");
                        break;
                }
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                    Console.WriteLine("");
                } while (linea != "ayuda");

                Console.WriteLine("Has ingresado: \t" + linea);
            }
    }
}
