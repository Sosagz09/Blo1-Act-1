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
                Console.WriteLine("........ISNP066724_Bloque1↓");
                Console.WriteLine("\nLista de programas:");
                Console.WriteLine("1. Positivo o Negativo");
                Console.WriteLine("2. Tabla de multipicar");
                Console.WriteLine("3. Acumulador");
                Console.WriteLine("4. Determinar numero primo");
                Console.WriteLine("5. Calcular promedio");
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
                        TablaMultipicar();
                        break;
                    case 3:
                        Acumulador();
                        break;
                    case 4:
                        DeterminarNumeroPrimo();
                        break;
                    case 5:
                        Calcularpromedio();
                        break;
                    default:
                        continuar = "n";
                        break;
                }
            }
        }
        


        static void Positivo_o_Negativo()
        {
            Console.WriteLine("Positivo o Negativo");
            int numero;

            do
            {
                Console.WriteLine("\nIngresa un número");
                Console.WriteLine("(0 para salir)");
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

            Console.WriteLine("PROGRAMA TERMINADO");
            Console.Clear();
        }
        
        

        static void TablaMultipicar()
        {
            Console.WriteLine("Tabla de multipicar");
            int numero;

            do
            {
                Console.WriteLine("\nIngresa un número entre 1 y 10");
                Console.WriteLine("(0 para salir)");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0 && numero <= 10)
                {
                    Console.WriteLine($"\nTabla de multiplicar del {numero}:");
                    //listar la tabla respectiva
                    
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{numero} x {i} = {numero * i}");
                    }
                    Console.WriteLine();
                }
                else if (numero != 0)
                {
                    Console.WriteLine("Por favor, ingresa un número válido entre 1 y 10.");
                }

            } while (numero != 0);

            Console.WriteLine("PROGRAMA TERMINADO");
            Console.Clear();
        }
        
        
        static void Acumulador()
        {
            Console.WriteLine("Acumulador de numeros");
            int acumulador = 0,
                 num = 0;
            do
            {
                Console.WriteLine("\nIngresa un número");
                Console.WriteLine("(0 para finalizar)");
                num = int.Parse(Console.ReadLine());
                acumulador += num;
            } while (num > 0);
            Console.WriteLine("El acumulador es igual a: {0}\n", acumulador);
        }
       
        
        static void DeterminarNumeroPrimo()
        {
            Console.WriteLine("Determinar numero primo");
            int numero;

            do
            {
                Console.WriteLine("\nIngresa un número para verificar si es primo");
                Console.WriteLine("(0 para salir)");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    if (EsPrimo(numero))
                    {
                        Console.WriteLine($"El número {numero} es primo.");
                    }
                    else
                    {
                        Console.WriteLine($"El número {numero} no es primo.");
                    }
                }

            } while (numero != 0);

            Console.WriteLine("PROGRAMA FINALIZADO\n");
            Console.Clear();
        }
        static bool EsPrimo(int numero)
        {
            // Los números menores o iguales a 1 no son primos
            if (numero <= 1)
            {
                return false;
            }

            // Verificar si el número es divisible por algún número entre 2 y la raíz cuadrada del número
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false; // Si es divisible por otro número, no es primo
                }
            }
            return true; // Si no fue divisible por ningún número, es primo
        }


        static void Calcularpromedio()
        {
            Console.WriteLine("Calcular Promedio");
            int numero;
            int suma = 0;
            int contador = 0;

            do
            {
                Console.WriteLine("Ingresa un número");
                Console.WriteLine("(0 para finalizar)");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    suma += numero;
                    contador++;     // Incrementar el contador de números ingresados
                }

            } while (numero != 0);

            // Calcular el promedio solo si se ingresaron números
            if (contador > 0)
            {
                double promedio = (double)suma / contador;
                Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron números válidos para calcular un promedio.");
            }

            Console.WriteLine("PROGRAMA TERMINADO\n");
            
        }
    }
}