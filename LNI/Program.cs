using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listMatrix = new List<string>();
            int paso;

            while (true)
            {
                Console.Write("Ingresa el numero de fila y columna que quieres aplicar LRU (numeros del 0 al 2)");
                paso = int.Parse(Console.ReadLine());
                var numbers = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        listMatrix.Add(numbers[i, j].ToString());
                    }
                }

                if (paso == 0)
                {
                    numbers[0, 0] = 1;
                    numbers[0, 1] = 1;
                    numbers[0, 2] = 1;
                    numbers[0, 0] = 0;
                    numbers[1, 0] = 0;
                    numbers[2, 0] = 0;
                }

                else if (paso == 1)
                {
                    numbers[1, 0] = 1;
                    numbers[1, 1] = 1;
                    numbers[1, 2] = 1;
                    numbers[0, 1] = 0;
                    numbers[1, 1] = 0;
                    numbers[2, 1] = 0;
                }


                else if (paso == 2)
                {
                    numbers[2, 0] = 1;
                    numbers[2, 1] = 1;
                    numbers[2, 2] = 1;
                    numbers[0, 2] = 0;
                    numbers[1, 2] = 0;
                    numbers[2, 2] = 0;
                }

                Console.WriteLine("Esta es tu matriz");
                int contador = 0;
                foreach (var item in numbers)
                {
                    Console.Write(item);
                    contador++;
                    if (contador == 3)
                    {
                        contador = 0;
                        Console.WriteLine();
                        paso = 0;
                    }
                }
                Console.Read();
            }
        }
    }
}
