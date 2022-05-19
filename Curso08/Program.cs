using System;
using System.Collections.Generic;

namespace Curso08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(12);
            idades.Add(21);
            idades.Add(31);
            idades.Add(61);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            Console.ReadKey();
        }
    }
}
