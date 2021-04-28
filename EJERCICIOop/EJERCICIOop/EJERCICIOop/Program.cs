using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOop
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            double a, b;
            int opcion;
            char abc;
            do
            {
            Console.WriteLine("--------MENU------------------");
            Console.WriteLine("\n");
            Console.WriteLine("1. Suma de dos numero");
            Console.WriteLine("2. Resta de dos numero");
            Console.WriteLine("3. Multiplicacion de dos numero");
            Console.WriteLine("4. Division de dos numero");
            Console.WriteLine("5. Listar abecedario");
                Console.WriteLine("0. Salir");
            Console.WriteLine("\n");

            Console.WriteLine("Digite una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

             
            
                switch (opcion)
                {
                case 1: Console.WriteLine("Digite el primer valor: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite el segundo valor: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El resultado de {0} + {1} = {2}", a, b, (a + b));
                    break;

                case 2:
                    Console.WriteLine("Digite el primer valor: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite el segundo valor: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El resultado de {0} - {1} = {2}", a, b, (a - b));
                    break;

                case 3:
                    Console.WriteLine("Digite el primer valor: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite el segundo valor: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El resultado de {0} * {1} = {2}", a, b, (a * b));
                    break;

                case 4:
                    Console.WriteLine("Digite el primer valor: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite el segundo valor: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El resultado de {0} / {1} = {2}", a, b, (a / b));
                    break;

                case 5: for (abc = 'a'; abc <= 'z'; abc++)
                    {
                        Console.WriteLine(abc);
                    }
                    break; 

                case 0: Console.WriteLine("Adios");
                    break;

                default: Console.WriteLine("Ha ingresado un valor incorrecto");
                    break;
            }
            
                Console.WriteLine("---------------------------");
                Console.WriteLine("Deseas regresar al menu? y/n");
                continuar = Console.ReadLine();
                Console.WriteLine("\n");
                Console.Clear();
            } while (continuar != "n");

            //para retornar al menu tiene que escribir una letra diferente a n (no), en este caso seria
            // y (yes)

            Console.ReadKey();
        }
    }
}
