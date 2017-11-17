using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero a ingresar: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Potencia: ");
            int npot = int.Parse(Console.ReadLine());

            Op(n, npot);
            Console.ReadKey();
        }

        static int pot(int n, int npot)
        {
            int r;
            if (npot == 0)
                return 1;
            else
                r = npot * pot(n, npot - 1);
            return r;
        }

        static int sumatoria(int n, int c)
        {
            int sum;
            if (c == 0)
                return 0;
            else
                sum = n + sumatoria(n + 2, c - 1);
            return sum;
        }

        static void Op(int n, int i)
        {
            if (pot(n, i) % sumatoria(1, i) == 0)
                Console.WriteLine(1 + pot(n, i) / sumatoria(1, i));
            else
                Console.WriteLine("1 + " + pot(n, i) + "/" + sumatoria(1, i));



        }
    }
}
