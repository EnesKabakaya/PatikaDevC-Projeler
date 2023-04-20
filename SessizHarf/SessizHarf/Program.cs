using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessizHarf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Boşluk bırakıp kelimelerİ girin");

                foreach (var item in Console.ReadLine().Split())
                {
                    bool def = false;
                    for (int i = 1; i < item.Length; i++)
                    {
                        if (sessizMi(item[i]) == sessizMi(item[i - 1]))
                            def = true;
                    }
                    Console.Write(def + " ");
                }

                bool sessizMi(char c)
                {
                    return !"aeıioöuüAEIİOÖUÜ".ToCharArray().Contains(c);
                }
            }
        }
    }
}
