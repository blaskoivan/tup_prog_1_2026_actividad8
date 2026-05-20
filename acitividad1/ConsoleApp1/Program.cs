using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double acumulado;
        static int cantidad;

        static void RegistrarNumero(int numero)
        {
            acumulado += numero;
            cantidad++;
        }
        static void MostrarPantallaSolicitarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            Program.RegistrarNumero(numero);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarTotalAcumulado()
        {
            Console.Clear();
            Console.WriteLine($"El total acumulado es: {acumulado}");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarCantidadNumerosIngresados()
        {
            Console.Clear();
            Console.WriteLine($"La cantidad de numeros ingresados es: {cantidad}");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPromedio()
        {
            Console.Clear();
            if (cantidad > 0)
            {
                double promedio = acumulado / cantidad;
                Console.WriteLine($"El promedio es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se han ingresado numeros.");
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Titulo del programa");
                Console.WriteLine("1. Ingresar numero");
                Console.WriteLine("2.Mostrar total acomulado");
                Console.WriteLine("3. Mostrar cantidad de numeros ingresados");
                Console.WriteLine("4. Mostrar promedio");
                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Program.MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        Program.MostrarTotalAcumulado();
                        break;
                    case 3:
                        Program.MostrarCantidadNumerosIngresados();
                        break;
                    case 4:
                        Program.MostrarPromedio();
                        break;

                }
            } while (opcion != 0);
        }
        }
}
