using System;
namespace MirasArayuzPolymorhism
{

    public enum TekstilMarka
    {
        Kigili = 1,
        Beymen = 2,
        PierreCarden = 3,
        AltinYildiz = 4,
        Polo = 5
    }
    public class Tekstil:Product
	{
        public string Tur { get; set; }
        public int Beden { get; set; }
        public string Uretici { get; set; }
        public TekstilMarka Marka { get; set; }


        public Tekstil()
		{
		}

        public static List<Tekstil> SearchByBrand(TekstilMarka marka)
        {
            #region DummyDATA
            List<Tekstil> textileProducts = new List<Tekstil>();
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Pantolon",
                Beden = 40,
                Price = 100,
                Marka = TekstilMarka.Beymen
            });
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Ceket",
                Beden = 40,
                Price = 150,
                Marka = TekstilMarka.Kigili
            });
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Gömlek",
                Beden = 40,
                Price = 200,
                Marka = TekstilMarka.Polo
            });
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Tshirt",
                Beden = 40,
                Price = 250,
                Marka = TekstilMarka.AltinYildiz
            });
            #endregion
            List<Tekstil> returnProducts = new List<Tekstil>();
            foreach (var item in  textileProducts)
            {
                if (item.Marka == marka)
                {
                    returnProducts.Add(item);
                }
            }
            return returnProducts;
        }

        public static List<Tekstil> SearchByName(string marka)
        {
            #region DummyDATA
            List<Tekstil> textileProducts = new List<Tekstil>();
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Pantolon",
                Beden = 40,
                Price = 100,
                Marka = TekstilMarka.Beymen
            });
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Ceket",
                Beden = 40,
                Price = 150,
                Marka = TekstilMarka.Kigili
            });
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Gömlek",
                Beden = 40,
                Price = 200,
                Marka = TekstilMarka.Polo
            });
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Tshirt",
                Beden = 40,
                Price = 250,
                Marka = TekstilMarka.AltinYildiz
            });
            #endregion
            List<Tekstil> returnProducts = new List<Tekstil>();
            foreach (var tekstil in textileProducts)
            {
                if (tekstil.ProductName.Contains(marka))
                {
                    returnProducts.Add(tekstil);
                }
            }
            return returnProducts;
        }

    }
}

