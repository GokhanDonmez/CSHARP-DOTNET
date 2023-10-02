using System;
using System.Collections.Generic;
using System.Linq;

namespace Ders2Generic
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region List Example
            //List<string> Diller = new List<string>();
            //Diller.Add("c");
            //Diller.Add("c#");
            //foreach (var dil in Diller)
            //{
            //    Console.WriteLine(dil);
            //}
            //Console.WriteLine(Diller[Diller.Count-1]);//SON elemanı verir
            #endregion

            #region Dictoniary //Hashtableın karşılığı
            Dictionary<int, string> sozluk = new Dictionary<int, string>()
            {
                {1,"C#" },
                {2,"C++" },
                {3,"C" }

            };

            List<string> dilListesi = sozluk.Values.ToList();
            foreach(var dil in dilListesi)
            {
                Console.WriteLine(dil);
            }

            #endregion
        }
    }
}
