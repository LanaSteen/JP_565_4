using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11
{
	internal static class Menu
	{



		private static readonly string _path = @"C:\Users\l4nst\Desktop\JP_565_4 online\Lesson11\Data\product.txt";


		private static void AddProduct()
		{
			var products = GetAllProducts();
			int maxId = 0;
			if (products.Count != 0)
			{
				maxId = products.Max(x => x.Id);
			}
		
			Product product = new Product();
			product.Id =++maxId;
			Console.WriteLine("Enter product name:");
			product.Name = Console.ReadLine();
			Console.WriteLine("Enter product price:");
			product.Price = decimal.Parse(Console.ReadLine());
			Console.WriteLine("Enter product description:");
			product.Description = Console.ReadLine();

			File.AppendAllLines(_path, [product.ToString()]);
		}

		private static List<Product> GetAllProducts()
		{
			var productsLines = File.ReadAllLines(_path).ToList();  // "0|dsdsd|20|dsdsds"
			List<Product> productList = new List<Product>(); /// carieli

			foreach(var line in productsLines)
			{
				var parts = line.Split('|');   ///  ["0", "dsdsd", "20", "dsdsds"]
				Product product = new Product();
				product.Id = int.Parse(parts[0]);
				product.Name = parts[1];
				product.Price = decimal.Parse(parts[2]);
				product.Description = parts[3];
				productList.Add(product);
			}
			return productList;
		}

		private static void ShowAllProducts()
		{
			var products = GetAllProducts();
			foreach (var product in products)
			{
				Console.WriteLine(product);
			}
		}


		private static void ShowProductById()
		{
			Console.WriteLine("Enter product id:");
			int id = int.Parse(Console.ReadLine());

			var products = GetAllProducts();

			var searchProduct = products.FirstOrDefault(x => x.Id == id);

			if (searchProduct != null)
			{
				Console.WriteLine(searchProduct);
			}
			else
			{
				Console.WriteLine("Product not found");
			}

		}

		private static void ShowSortedProducts()
		{
			var products = GetAllProducts();
			var sortedProducts = products.OrderBy(x => x.Price).ToList();
			foreach (var product in sortedProducts)
			{
				Console.WriteLine(product);
			}
		}

		public static void ShowMenu()
		{
			string choice ="";

			while (choice != "0")
			{

				Console.WriteLine("Enter 1 to add product");
				Console.WriteLine("Enter 2 to show all products");
				Console.WriteLine("Enter 3 to show product by id");
				Console.WriteLine("Enter 4 to show sorted products" );
				Console.WriteLine("Enter 0 to exit");

				choice = Console.ReadLine();
				switch (choice)
				{
					case "1":
						/// add product
						AddProduct();
						break;
					case "2":
						/// show all products
						ShowAllProducts();
						break;
					case "3":
						/// show product by id
						ShowProductById();
						break;
					case "4":
						/// show sorted products
						ShowSortedProducts();
						break;
					case "0":
						Console.WriteLine("Exiting...");
						break;

				}



			}
		}
	}
}
