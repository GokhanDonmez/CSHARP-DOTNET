using System;
namespace MirasArayuzPolymorhism
{
	public class Product
	{

		public int ProductID { get; set; }
		public string ProductCode { get; set; }
		public string ProductName { get; set; }
		public double Price { get; set; }
		public Product()
		{

		}

		public Product(
            int productId,
            string productCode,
            string productName,
            double price)
		{
			this.ProductID = productId;
			this.ProductCode = productCode;
			this.ProductName = productName;
			this.Price = price;
		}

		public double SetKDV()
		{
			return this.Price *1.18;
		}
	}
}

