using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_3_1204055
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("ANAK AYAM TURUN ");

            int jmlhAyam = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");

            int ayam = jmlhAyam;
            int goin = jmlhAyam;

                for (int i = ayam; i > 1; i--)
                {
                    Console.Write("Anak ayam turunlah " + i + ", mati satu tinggalah " + (i - 1) + "\n");
                }
                    Console.Write("Anak ayam turunlah 1" + ", mati satu tinggalah induknya\n");
        }
    }
}
