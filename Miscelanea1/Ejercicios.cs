using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Ejercicios
    {
        public static double n1, n2, n3, n4;

        //OPERADORES
        public static void AreaTriangulo()
        {
            Console.WriteLine("\nCalcular Area de un Triangulo");
            Console.WriteLine("");
            Console.WriteLine("Ingrese dos valores enteros");
            Console.WriteLine("Ingrese el valor de la base: ");

            try
            {
                n1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Ingrese el valor de la altura: ");
            try
            {
                n2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
             Console.WriteLine("El Area del triangulo es " + ((n1 * n2) / 2));
            
        }
        public static void SUMA()
        {
            Console.WriteLine("\nSuma");
            Console.WriteLine("");
            Console.WriteLine("Ingrese dos valores enteros");
            Console.WriteLine("Ingrese el primer valor:");
            try
            {
                n1 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Ingrese el segundo valor: ");
            try
            {
                n2 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("El resultado de la suma es: " + (n1 + n2));
        }
        public static void Numeroalcuadrado()
        {
            Console.WriteLine("\nNumero elevado al Cuadrado");
            Console.WriteLine("Ingrese el valor:");
            try
            {
                n1 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            
            Console.WriteLine("El numero elevado al cuadrado es: " + (n1 * n1));
        }
        public static void EurosDolares()
        {
            Console.WriteLine("\nEuros a Dolares");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el valor que quiera convertir: ");
            try
            {
                n1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;

            }
            Console.WriteLine("El resultado de la conversion es: " + (n1 * 1.06) + " USD $");
        }
        public static void AreaCuadrado()
        {
            Console.WriteLine("\nCalcular Area y Perimetro de un Cuadrado");
            Console.WriteLine("");
            Console.WriteLine("Inserte el valor del lado de un Cuadrado");
            try
            {
                n1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("El resultado del area es: " + (n1 * n1));
            Console.WriteLine("El resultado del perimetro es: " + (n1 * 4));
        }
        public static void Areayvolumen()
        {
            Console.WriteLine("\nDeterminar Area y Volumen de un Cilindro");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el valor del Radio del Cilindro: ");
            try
            {
                n1 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Ingrese el valor de la Altura del Cilindro: ");
            try
            {
                n2 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("El resultado del Area del cilindro es: " + ((2 * 3.1416) * (n1 * n2) + (2 * 3.1416) * (n1 * n1)));
            Console.WriteLine("El resultado del Volumen del cilindro es: " + ((n1 * n1 * 3.1416) * (n2)));
        }
        public static void Longitudyarea()
        {
            Console.WriteLine("\nDeterminar la Longitud y Area de un Circulo");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el valor del Radio del Cilindro: ");
            try
            {

                n1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;

            }

            Console.WriteLine("El resultado de la longitud de la Circunferencia es: " + ((2 * 3.1416) * (n1)));
            Console.WriteLine("El resultado del Area del Circulo es: " + ((3.1416) * (n1 * n1)));
        }
        public static void Promedio()
        {
            Console.WriteLine("\nPromedio de tres numeros");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el primer valor: ");
            try
            {


                n1 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {

                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Ingrese el segundo valor: ");
            try
            {
                n2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Ingrese el tercer valor: ");
            try
            {


                n3 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("La suma de los numeros es: " + (n1 + n2 + n3));
            Console.WriteLine("El promedio de los numeros es: " + (n1 + n2 + n3) / (3));
        }
        //CONDICIONALES
        public static void PosioNega()
        {
            Console.WriteLine("\nNumero Positivo o Negativo");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el numero: ");
            try
            {
                n1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            if (n1 > 0)
            {
                Console.WriteLine("El numero " + n1 + " es un numero positivo");
            }
            else
            {
                Console.WriteLine("El numero " + n1 + " es un numero negativo");
            }
        }
        public static void MayorOMenor()
        {
            Console.WriteLine("\nNumero mayor y menor");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el primer numero: ");
            try
            {
                n1 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Ingrese el segundo numero: ");
            try
            {
                n2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            if (n2 < n1)
            {
                Console.WriteLine("El numero mayor es: " + n1);
            }
            else
            {
                Console.WriteLine("El numero menor es: " + n1);
            }

            if (n1 < n2)
            {
                Console.WriteLine("El numero mayor es: " + n2);
            }
            else
            {
                Console.WriteLine("El numero menor es: " + n2);
            }
        }
        public static void TresNum()
        {
            Console.WriteLine("\nNumero mayor y menor de tres numeros");
            Console.WriteLine("Ingrese el primer numero: ");
            try
            {
                n1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Ingrese el segundo numero: ");
            try
            {
                n2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Ingrese el tercer numero: ");
            try
            {
                n3 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            if ((n1 == n2) && (n2 == n3))
            {
                Console.WriteLine("Todos los numeros son iguales.");
            }
            else if ((n1 > n2) && (n1 > n3))
            {
                if (n2 > n3)
                {
                    Console.WriteLine("El numero " + n1 + " es el numero mayor.");
                    Console.WriteLine("El numero " + n3 + " es el numero menor.");
                }

                else if (n3 > n2)
                {
                    Console.WriteLine("El numero " + n1 + " es el numero mayor.");
                    Console.WriteLine("El numero " + n2 + " es el numero menor.");
                }
                else
                {
                    Console.WriteLine("El numero " + n1 + " es el numero mayor.");
                    Console.WriteLine("Los otros numeros son iguales.");
                }
            }
            else if ((n2 > n1) && (n2 > n3))
            {
                if (n1 > n3)
                {
                    Console.WriteLine("El numero " + n2 + " es el numero mayor.");
                    Console.WriteLine("El numero " + n3 + " es el numero menor.");
                }

                else if (n3 > n1)
                {
                    Console.WriteLine("El numero " + n2 + " es el numero mayor.");
                    Console.WriteLine("El numero " + n1 + " es el numero menor.");
                }
                else
                {
                    Console.WriteLine("El numero " + n2 + " es el numero mayor.");
                    Console.WriteLine("Los otros numeros son iguales.");
                }
            }
            else if ((n3 > n1) && (n3 > n2))
            {
                if (n1 > n2)
                {
                    Console.WriteLine("El numero " + n3 + " es el numero mayor.");
                    Console.WriteLine("El numero " + n2 + " es el numero menor.");
                }

                else if (n2 > n1)
                {
                    Console.WriteLine("El numero " + n3 + " es el numero mayor.");
                    Console.WriteLine("El numero " + n1 + " es el numero menor.");
                }
                else
                {
                    Console.WriteLine("El numero " + n3 + " es el numero mayor.");
                    Console.WriteLine("Los otros numeros son iguales.");
                }
            }
        }
        public static void AyB()
        {
            Console.WriteLine("\nDos números A y B, sumarlos si A es menor que B o sino restarlos.");
            Console.WriteLine("Ingrese el valor del numero A: ");
            try
            {
                n1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Ingrese el valor del numero B: ");
            try
            {
                n2 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            if (n1 < n2)
            {
                n3 = n1 + n2;
                Console.WriteLine("La suma de ambos valores es: " + n3);
            }
            else if (n1 > n2)
            {
                n4 = n1 - n2;
                Console.WriteLine("La resta de ambos valores es: " + n4);
            }
        }
        public static void AyB2()
        {
            Console.WriteLine("\nDos números A y B encontrar el cociente");
            Console.WriteLine("Ingrese el valor de A: ");
            try
            {


                n1 = Convert.ToDouble(Console.ReadLine());
            } 
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Ingrese el valor de B: ");
            try
            {
                n2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            if (n2 == 0)
            {
                Console.WriteLine("No se puede dividir entre cero");
            }
            else
            {
                n3 = n1 / n2;
                Console.WriteLine("El cociente de la division es: " + n3);
            }
        }
        public static void Dosnumeros()
        {
            Console.WriteLine("\nDos números sumarlos si alguno es negativo, sino multiplicarlos");
            Console.WriteLine("Ingrese el valor de A: ");
            try
            {
                n1 = (double)Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Ingrese el valor de B: ");
            try
            {
                n2 = (double)Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            n3 = n2 + n1;
            n4 = n1 * n2;

            if (n1 < 0)
            {
                Console.WriteLine("La suma de ambos numeros es: " + n3);
            }
            else if (n2 < 0)
            {
                Console.WriteLine("La suma de ambos numeros es: " + n3);
            }
            else if (n4 > 0)
            {
                Console.WriteLine("El resultado de la multiplicacion de ambos numeros es: " + n4);
            }

        }
        public static void Añobisiesto()
        {
            static bool bisiesto()
            {
                if (n2 % 4 == 0 && (n2 % 100 != 0 || n2 % 400 == 0))
                    return true;
                return false;
            }
            Console.WriteLine("\nDeterminar si un año es bisiesto o no");
            Console.WriteLine("Digite el año ");
            try
            {

                n2 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            if (bisiesto() == true)
            {
                Console.WriteLine("El año " + n2 + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + n2 + " no es bisiesto");
            }
        }

        //CICLOS 
        public static void Multi3()
        {
            Console.WriteLine("\nTodos los multiplos de 3, entre 1 a 100");
            Console.WriteLine("Los multiplos de 3 que hay entre 1 y 100 son: ");
            Console.WriteLine("");
            for (n1 = 1; n1 <= 100; n1++)
            {
                if (n1 % 3 == 0)
                {
                    Console.WriteLine(n1);
                }
            }
        }
        public static void NumImp()
        {

            Console.WriteLine("\nNumeros impares entre 0 a 100");
            Console.WriteLine("son: ");
            for (n1 = 1; n1 <= 100; n1 += 2)
            {
                Console.WriteLine(n1);
            }
        }
        public static void NumPar()
        {
            Console.WriteLine("\nNumeros pares entre 1 a 100");
            Console.WriteLine("son: ");
            for (n1 = 0; n1 <= 100; n1 += 2)
            {
                Console.WriteLine(n1);
            }
        }
        public static void NumCuad()
        {
            Console.WriteLine("\nNumeros cuadrados del 1 al 30");
            Console.WriteLine("son: ");
            for (n1 = 1; n1 <= 30; n1++)
            {
                Console.WriteLine("El numero cuadrado de " + n1 + " es: " + Math.Pow(n1, 2));
            }
        }
        public static void SumaCuadra()
        {

            Console.WriteLine("\nSuma de los cuadrados de los cien primeros numeros naturales");
            for (n3 = 0; n3 <= 100; n3++)
            {
                n1 = 1 * n3;
                n1 = n1 * n3;
                n2 = n2 + n1;
                Console.WriteLine("El cuadrado de " + n3 + " es: " + n1);
            }
            Console.WriteLine("La suma de los cuadrados es: " + n2);
        }
        public static void NumerosNatu()
        {
            Console.WriteLine("\nDados dos números naturales, mostrar todos los números comprendidos entre ellos en secuencia ascendente.");
            Console.WriteLine("Digite el primer numero: ");
            try
            {
                n1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Digite el segundo numero: ");
            try
            {


                n2 = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Los numero comprendidos entre: " + n1 + " y " + n2 + " son: ");
            for (n3 = n1 + 1; n3 < n2; n3++)
            {

                Console.WriteLine(n3);
            }

            Console.ReadKey();
        }
        public static void SumaTodo()
        {
            Console.WriteLine("\nSuma de todos los numeros digitados hasta el ingreso de 0");
            do
            {
                Console.WriteLine("\nIngrese el numero que desea sumar o 0 para Salir: ");
                try
                {


                    n1 = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR DE DIGITACION, VOLVIENDO AL MENU PRINCIPAL. ");
                    Console.WriteLine(ex.Message);
                    return;
                }
                n2 = n2 + n1;
                Console.WriteLine("El resultado de la suma es: " + n2);

            } while (n1 != 0);
        }
     }           
}
            
        
     

