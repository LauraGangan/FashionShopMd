namespace FashionShopMd.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Image { get; set; }
		public string Name { get; set; }

		public string Description { get; set; }

		public decimal Cost { get; set; }

		public int Discount { get; set; }

		public string Size { get; set; }
		public string Color { get; set; }
		public string OnStok { get; set; }

		public DateTime CreatedOn { get; set; }
		

	}
}
