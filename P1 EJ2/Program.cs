using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, cont = 0;
            double seg, min, horas, suma = 0, prom = 0, menor = double.MaxValue;

            do
            {
                Console.WriteLine("Ingrese la duración de la llamada: ");
                seg = Convert.ToInt32(Console.ReadLine());

                if (seg > 0)
                {
                    i++;

                    min = (seg / 60);
                    horas = (min / 60);
                    suma += seg;

                    if (min > 10)
                    {
                        cont++;
                    }

                    if (seg < menor)
                    {
                        menor = seg;
                    }
                }

            } while (seg != 0);

            if (i > 0)
            {
                Console.WriteLine($"La cantidad de llamadas que superaron los 10 minutos fueron: {cont}.");
                prom = (suma / i);
                Console.WriteLine($"El promedio de las llamadas fueron de: {prom} segundos.");
                Console.WriteLine($"Y la llamada que menos duró fue de: {menor} segundos.");
            }
            else
            {
                Console.WriteLine("No se realizaron llamadas.");
            }

            Console.ReadKey();
        }
    }
}
