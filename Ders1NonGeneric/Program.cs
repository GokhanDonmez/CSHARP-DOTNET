using System;
using System.Collections;

namespace Ders1NonGeneric
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region NonGeneric
            //farklı türden verilerin bir arada saklanabildiği koleksiyon türleridir.
            //içerisindeki verinin elde edilip kullanılabilmesi için boxing//unboxing işlemine tabi tutulması gerekir.
            //System.Collections namespacinde yer alır.
            //Mesala tiplerin tamamı aynı ise non generic kullanma boşuna performans kaybı olmasın.
            #region Arraylist example
            //ArrayList Sehirler = new ArrayList();
            //Sehirler.Add("İstanbul");
            //Sehirler.Add("Ankara");
            //Sehirler.Add("İzmir");
            //Sehirler.Add("Antalya");
            //Sehirler.Add("Adana");
            //foreach(var sehir  in Sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}
            //Console.WriteLine("Count : " + Sehirler.Count);
            //Console.WriteLine("Capacity : " + Sehirler.Capacity);
            //Sehirler.Capacity = 100;
            //Sehirler.Contains("İzmir");
            //Sehirler.Add(3);
            //Sehirler.Add(true);
            //Sehirler.Add(new MainClass());
            //Console.WriteLine(Sehirler[2]);
            #endregion

            #region Hashtable
            Hashtable hashtable = new Hashtable();
            hashtable.Add("001", "Adana");
            hashtable.Add("002", 5);
            foreach(DictionaryEntry dictionary in hashtable)
            {
                Console.WriteLine(dictionary.Key);
            }
            #endregion
            #endregion
        }
    }
}
