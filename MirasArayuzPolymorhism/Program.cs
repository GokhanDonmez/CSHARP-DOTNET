// See https://aka.ms/new-console-template for more information
namespace MirasArayuzPolymorhism
{
    class Program
    {
        static void Main(string[] args)
        {

            Basket basket = new Basket();
            
            Bread ekmek = new Bread(BreadType.Odun);
            Tekstil tekstil = new Tekstil();
            tekstil.Marka = TekstilMarka.Beymen;
            tekstil.ProductName = "Özel Dikim";
            tekstil.Price = 250.5;
            basket.Add(ekmek);
            basket.Add(tekstil);
            Console.WriteLine("Toplam Fiyat (Kdv hariç) : " + basket.TotalPrice());
            Console.WriteLine("Toplam Fiyat (Kdv dahil) : " + basket.TotalPriceWithKDV());
        }

    }

 
}