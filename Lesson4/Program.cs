using Lesson4.LibraryModels;

namespace Lesson4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region hw
			//Temperature temp1 = new();
			//Temperature temp2 = new();
			//temp1.Amount = 20;
			//temp1.Measurement = "celsius";

			//temp2.Amount =0;
			//temp2.Measurement = "celsius";

			//Console.WriteLine(temp1/temp2);  // 2

			//temp1 + temp2  // Temperature

			//int +int  // int


			#endregion




         

			Book book = new Book();
			book.Title = "Test";
			book.AuthorName = "Test";
			book.PublishYear = 2020;

			Book book2 = new Book();
			book2.Title = "Test2";
			book2.AuthorName = "Test2";
			book2.PublishYear = 2022;


			Manager manager = new Manager();
			manager.Name = "TestManager";
			manager.Age = 20;


			Client client = new Client();
			client.Name = "TestClient";
			client.Age = 25;



			Library library = new Library();
			library.Name = "TestLibrary";
			library.Addresses = ["TestAddress", "TestAddress2"];
			library.Year = 2000;

			library.Books = [book, book2];
			library.Clients = [client];
			library.Manager= manager;


			Console.WriteLine();
		}
	}
}
