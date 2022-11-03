using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_EJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, maq, horas, min, seg, cant, maxcant = 0;
            double prom = 0, sum = 0, totseg = 0, totmin = 0, toths = 0;

            Console.Write("Ingrese cuántas maquinas son: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                do
                {
                    Console.Write("Ingrese el Número de Maquina: ");
                    maq = Convert.ToInt32(Console.ReadLine());

                    do
                    {
                        Console.Write("Ingrese las horas: ");
                        horas = Convert.ToInt32(Console.ReadLine());

                        do
                        {
                            Console.Write("Ahora, los minutos: ");
                            min = Convert.ToInt32(Console.ReadLine());

                            do
                            {
                                Console.Write("Por último, los segundos: ");
                                seg = Convert.ToInt32(Console.ReadLine());

                                do
                                {
                                    Console.Write("Ingrese la cantidad de piezas producidas: ");
                                    cant = Convert.ToInt32(Console.ReadLine());

                                    if (cant > 0)
                                    {
                                        maxcant += cant;
                                    }

                                } while (cant < 0);

                            } while (seg < 0 && seg > 59);

                        } while (min < 0 && min > 59);

                    } while (horas < 0);

                } while (maq < 0);

                toths = (horas * 60);
                totmin = ((min + toths) * 60);
                totseg = (totmin + seg);
                sum = (totseg / 60);
                prom = (cant / sum);

                Console.WriteLine();
                Console.WriteLine($"La máquina nro: {maq}, funcionó durante: {horas} hrs:{min} min:{seg} seg, realizando {cant} piezas.");
                Console.WriteLine($"El rendimiento de la máquina nro: {maq} fue de: {prom} pieza/s x minuto.");
            }
            Console.WriteLine();
            Console.WriteLine($"El total de piezas realizada por las máquinas fue de: {maxcant}.");
            Console.ReadKey();
        }
    }
}
