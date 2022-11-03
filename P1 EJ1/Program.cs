using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_EJ1
{
    class Program
    {
        const int MAX = 2;
        static void Main(string[] args)
        {
            int cod, edad;
            int contTemp = 0, contPer = 0;

            for (int i = 1; i <= MAX; i++)
            {
                do
                {
                    Console.WriteLine($"REGISTRO DE SOCIOS DEL CLUB Nª {i}.");
                    Console.WriteLine("1) Temporal. \n2) Permanente. \n3) Next.");
                    Console.Write("Ingrese su código de socio: ");
                    cod = Convert.ToInt32(Console.ReadLine());

                } while (cod <= 0 && cod > 3);

                while (cod != 3)
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("Ahora, ingrese su edad: ");
                        edad = Convert.ToInt32(Console.ReadLine());

                    } while (edad < 0 || edad > 120);

                    if (edad >= 18)
                    {
                        switch (cod)
                        {
                            case 1:
                                contTemp++;
                                break;
                            case 2:
                                contPer++;
                                break;
                        }
                    }

                    do
                    {
                        Console.Clear();
                        Console.WriteLine($"REGISTRO DE SOCIOS DEL CLUB Nª {i}.");
                        Console.WriteLine("1) Temporal. \n2) Permanente. \n3) Next.");
                        Console.Write("Ingrese su código de socio: ");
                        cod = Convert.ToInt32(Console.ReadLine());

                    } while (cod <= 0 && cod > 3);
                }
                Console.Clear();
                Console.WriteLine($"En el Club Nª{i}:");
                Console.WriteLine();

                if (contPer > contTemp)
                {
                    Console.WriteLine("El porcentaje de Permanentes es mayor al de Temporales.");
                }
                else if (contTemp > contPer)
                {
                    Console.WriteLine("El porcentaje de Temporales es mayor al de Permanentes.");
                }
                else
                {
                    Console.WriteLine("El porcentaje de Temporales y Permanentes es igual.");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
