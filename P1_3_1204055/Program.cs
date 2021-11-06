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
            
            if(ayam > 10) {
                Console.Write("Anak ayam harus 1-10 kawan. Terimakasih :)\n");
            }
            else if (ayam < 1)
            {
                Console.Write("Anak ayam harus 1-10 kawan. Terimakasih :)\n");
            }
            else { 
                for (int i = ayam; i > 0; i--)
                {
                    if (i > 1)
                    {
                        Console.Write("Anak ayam turunlah " + i + ", mati satu tinggalah " + (i - 1) + "\n");
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine("Anak ayam turunlah " + i + ", mati satu tinggalah induknya");
                    }
                }
            }

        }
    }
}
