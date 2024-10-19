using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP066724_Bloque1
{
    class Program
    {
        static void Main(string[] args){
            String continuar = "s";
            while (continuar == "s")
            {
                //Bloque 1 - Actividad 1 - Conociendo los fundamentos de la programacion.
                Console.WriteLine("\n........ISNP066724_Bloque1........");
                Console.WriteLine("\n Guia de Ejercicios:");
                Console.WriteLine("1. Positivo_o_Negativo");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exponeciacion");
                Console.WriteLine("6. Raiz");
                Console.WriteLine("7. Factorial");
                Console.WriteLine("8. Acumulador");
                Console.WriteLine("Salir cualquiera");
                Console.Write("Opcion: ");
                int opcion = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Positivo_o_Negativo();
                        break;
                    case 2:
                        resta();
                        break;
                    case 3:
                        multiplicacion();
                        break;
                    case 4:
                        division();
                        break;
                    case 5:
                        exponenciacion();
                        break;
                    case 6:
                        raiz();
                        break;
                    case 7:
                        factorial();
                        break;
                    case 8:
                        acumulador();
                        break;
                    default:
                        continuar = "n";
                        break;
                }
            }
        }
        static void acumulador()
        {
            int acumulador = 0,
                num = 0;
            do
            {
                Console.Write("Num: ");
                num = int.Parse(Console.ReadLine());
                acumulador += num;
            } while (num > 0);
            Console.WriteLine("El acumulador es igual a: {0}", acumulador);
        }
        static void Positivo_o_Negativo()
        {
            Console.WriteLine("\nPositivo_o_Negativo");
            int numero;

            do
            {
                Console.Write("Ingresa un número (0 para salir): ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else
                {
                    Console.WriteLine("Has ingresado 0, el programa ha finalizado.");
                }

            } while (numero != 0);

            Console.WriteLine("Programa terminado ( ͡° ͜ʖ ͡°)");
        }
        static void resta()
        {
            Console.Write("Num 1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            double num2 = double.Parse(Console.ReadLine());

            double respuesta = num1 - num2;
            Console.WriteLine("La resta es igual a: {0}", respuesta);
        }
        static void multiplicacion()
        {
            Console.Write("Num 1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            double num2 = double.Parse(Console.ReadLine());

            double respuesta = num1 * num2;
            Console.WriteLine("La multiplicacion es igual a: {0}", respuesta);
        }
        static void division()
        {
            Console.Write("Num 1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            double num2 = double.Parse(Console.ReadLine());

            double respuesta = num1 / num2;
            Console.WriteLine("La division es igual a: {0}", respuesta);
        }
        static void exponenciacion()
        {
            Console.Write("Base: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Exponenete: ");
            double num2 = double.Parse(Console.ReadLine());

            double respuesta = Math.Pow(num1, num2);
            Console.WriteLine("La base {0} elevado a {1} es igual a: {2}", num1, num2, respuesta);
        }
        static void raiz()
        {
            Console.Write("Radicando: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Indice: ");
            double num2 = double.Parse(Console.ReadLine());

            double respuesta = Math.Pow(num1, 1 / num2);// raiz 2 de 16 = 16^(1/2)=4
            Console.WriteLine("La raiz del radicando {0} del indice {1} es igual a: {2}", num1, num2, respuesta);
        }
        static void factorial()
        {
            Console.WriteLine("Factorial");
            Console.Write("Num: ");
            double num = double.Parse(Console.ReadLine());
            //5! = 5*4*3*2= 120
            double respuesta = 1;
            for (int i = 2; i <= num; i++)
            {
                respuesta *= i; //factorial = factorial * i;
            }
            Console.WriteLine("El factorial de {0} es igual a: {1}", num, respuesta);
        }
    }
}
