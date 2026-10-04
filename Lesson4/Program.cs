using Lesson4.LibraryModels;
using System.ComponentModel;

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






			//Book book = new Book();
			//book.Title = "Test";
			//book.AuthorName = "Test";
			//book.PublishYear = 2020;

			//Book book2 = new Book();
			//book2.Title = "Test2";
			//book2.AuthorName = "Test2";
			//book2.PublishYear = 2022;


			//Manager manager = new Manager();
			//manager.Name = "TestManager";
			//manager.Age = 20;


			//Client client = new Client();
			//client.Name = "TestClient";
			//client.Age = 25;
			//Client client2 = new Client();
			//client2.Name = "TestClient";
			//client2.Age = 25;


			//Library library = new Library();
			//library.Name = "TestLibrary";
			//library.Addresses = ["TestAddress", "TestAddress2"];
			//library.Year = 2000;

			//library.Books = [book, book2]; // 2
			//library.Clients = [client];
			//library.Manager = manager;

			//library.Clients.Add(client2);



			//var bookList = library.Books.ToList();

			//Book book3 = new Book();
			//book3.Title = "Test3";
			//book3.AuthorName = "Test3";
			//book3.PublishYear = 2025;
			//bookList.Add(book3);

			//Book[] books = bookList.ToArray();

			//library.Books = books;




			////library.Books
			////Array.Resize(ref library.Books, 3);

			//library.DisplayInfo();
			//Console.WriteLine();



			//int[] numbers = { 1, 2 };  // 1 2 0

			//Array.Resize(ref numbers, numbers.Length+1); //0
			//numbers[2] = 100;

			//foreach (var item in numbers)
			//{
			//	Console.WriteLine(item);
			//}



			//List<int> list = new();  // 0

			//list.Add(10);
			//list.Add(25);
			//list.Add(33);
			//list.Add(25);

			//foreach (var item in list)
			//{
			//	Console.WriteLine(item);
			//}


			//list.Remove(25);  // პირველი რაც შეხვდება იმ 25 ს წაშლის
			//list.Remove(25);
			//Console.WriteLine("after remove");


			//foreach (var item in list)
			//{
			//	Console.WriteLine(item);
			//}



			//Console.WriteLine(list.Contains(25)); // true / false




			//List<string> names = new() {"John", "James", "John", "James", "Doe", "James", };



			//Contains
			//Remove


			//if (names.Contains("John"))
			//{
			//	names.Remove("John");
			//}


			//while (names.Contains("John"))
			//{
			//	names.Remove("John");
			//}


			//foreach (var item in names)
			//{
			//	Console.WriteLine(item);
			//}
			//
			int[] ints = [1, 2, 3];
			List<int> ints2 = new() {5,6,7 };

			Console.WriteLine(ints.Length);  // 3
			Console.WriteLine(ints2.Count);  //3


			for (int i = 0; i < ints2.Count; i++)
			{
				Console.WriteLine(ints2[i]);
			}

		}
	}
}
