namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liste<decimal> liste = new Liste<decimal>();
            //Liste<string> liste = new Liste<string>();
            //liste.Add("Ali");
            //liste.Add("veli");
            //liste.Get();

            Mylist<string> liste = new Mylist<string>();
            liste.Ekle("Ali");
            liste.Ekle("veli");
            Console.WriteLine("Eleman Sayisi = " + liste.ElementSayi);

        }
    }


    class Liste
    {

    }

    //class Liste<T>//class overloading
    //{
    //    public Liste()
    //    {
    //        Console.WriteLine(typeof(T));
    //    }
    //}
    #region    version 1
    //class Liste<T>
    //{
    //    List<T> list = new List<T>();
    //    public void Add(T guccukT)
    //    {
    //        list.Add(guccukT);
    //    }
    //    public void Get()
    //    {
    //        foreach (var t in list)
    //        {
    //            Console.WriteLine("t -> "+ t);
    //        }
    //    }
    //}
    #endregion


    class Mylist<T>
    {
        T[] dizi;
        public void Ekle(T deger)
        {
            try
            {
                T[] geciciDizi = new T[dizi.Length];
                geciciDizi = dizi;
                dizi = new T[geciciDizi.Length + 1];
                for (int i = 0; i < geciciDizi.Length; i++)
                {
                    dizi[i] = geciciDizi[i];
                }
                dizi[dizi.Length - 1] = deger;
            }
            catch 
            {
                dizi = new T[1];
                dizi[0] = deger;
            }
             
        }

        public int ElementSayi
        {
            get { return dizi.Length; }
       }
    }

}

