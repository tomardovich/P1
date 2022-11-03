using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias, dia, cantidad;
            char turno;
            int Maximo = int.MinValue, Minimo = int.MaxValue;
            int MaxDia = 0, MinDia = 0;
            char MaxTurno = ' ', MinTurno = ' ';

            do
            {
                Console.Write("Ingrese la cantidad de dias laborables (Máximo 20): ");
                dias = int.Parse(Console.ReadLine());

            } while (dias < 1 || dias > 20);

            dias = dias * 3;

            for (int i = 1; i < dias; i++)
            {
                do
                {
                    Console.Write("Ingrese el día: ");
                    dia = Convert.ToInt32(Console.ReadLine());

                } while (dia < 1 || dia > 31);

                do
                {
                    Console.Write("Ingrese el turno: ");
                    turno = Convert.ToChar(Console.ReadLine());

                } while (turno != 'M' && turno != 'T' && turno != 'N');

                do
                {
                    Console.Write("Ingrese la cantidad de ventiladores: ");
                    cantidad = Convert.ToInt32(Console.ReadLine());

                } while (cantidad < 1);

                if (Maximo < cantidad)
                {
                    Maximo = cantidad;
                    MaxTurno = turno;
                    MaxDia = dia;
                }

                if (Minimo > cantidad)
                {
                    Minimo = cantidad;
                    MinTurno = turno;
                    MinDia = dia;
                }
            }

            Console.Clear();
            Console.WriteLine($"En el día: {MaxDia}, en el turno: {MaxTurno}, se produjo la mayor cantidad de ventiladores: {Maximo}.");
            Console.WriteLine($"En el día: {MinDia}, en el turno: {MinTurno}, se produjo la menor cantidad de ventiladores: {Minimo}.");

            Console.ReadKey();
        }
    }
}
