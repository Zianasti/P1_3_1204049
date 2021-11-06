using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_3_1204049
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("INPUT : 1 SAMPAI 10\n----------------------------------------------------------\n");
            Console.Write("ANAK AYAM TURUN : ");

            int n = Convert.ToInt32(Console.ReadLine());

            for (int k = n; k >= 1; k--)
            {
                if (k >= 2 && n<=10)
                {
                    Console.WriteLine("Anak ayam turunlah " + k + ", mati satu tinggallah " + (k - 1));
                }
                else if (k <= 1 && n<=10)
                {
                    Console.WriteLine("Anak ayam turunlah " + k + ", mati satu tinggallah induknya");
                }
            }
        }
    }
}
