using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcgenCizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgenin kenar uzunluğunu girin: ");
            int kenarUzunlugu=Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= kenarUzunlugu; i++)
            {
                for(int j = 0; j <= kenarUzunlugu - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
