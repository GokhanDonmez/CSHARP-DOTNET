using System;
namespace MirasArayuzPolymorhism
{
	public class Basket
	{
		private List<Product> products = new List<Product>();

		public void Add(Product newProduct)
		{
			if(newProduct !=null)
			{
				products.Add(newProduct);
			}
		}

		public double TotalPrice()
		{
			double totalPrice = 0;
			foreach(var product in products)
			{
				totalPrice += product.Price;
			}
			return totalPrice;
		}
		public double TotalPriceWithKDV()
		{
			double _totalPrice = 0;
			foreach (var product in products)
			{
				_totalPrice += product.SetKDV();
			}
			return _totalPrice;
		}
		public List<Product> GetProducts()
		{
			return products;
		}
		public Basket()
		{
		}
	}
}

