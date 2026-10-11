using static System.Net.Mime.MediaTypeNames;

namespace Lesson6
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region hw
			//			ამოცანის აღწერა
			//შექმენით Console Application, სადაც მართავთ სტუდენტების ქულებს.
			//________________________________________
			//მოთხოვნები
			//1.გამოიყენეთ ორი სტრუქტურა:
			//•	List<string> → სტუდენტების სახელებისთვის 
			//•	Dictionary<string, int> → სტუდენტის სახელი და მისი ქულა
			//________________________________________


			//key - value 
			//         index - value



			//List<string> names = new() {"John", "Jane", "Bob" };

			//Dictionary<string, int> namesAndScores = new()
			//{
			//	{ "John", 18 },
			//	{ "Jane", 17 },
			//	{ "Bob", 20 }
			//};


			//string name = Console.ReadLine();
			//if (namesAndScores.ContainsKey(name))
			//{
			//	Console.WriteLine(name + " " + namesAndScores[name]);
			//	Console.WriteLine("If you want to change enter score or press x to exit");
			//	string exit = Console.ReadLine();
			//	if(exit == "x")
			//	{
			//		foreach (var item in namesAndScores)
			//		{
			//			Console.WriteLine(item.Key + " " + item.Value);
			//		}
			//	}
			//	else
			//	{
			//		Console.WriteLine("Enter new score");
			//		int score = int.Parse(Console.ReadLine());
			//		namesAndScores[name] = score;
			//		foreach (var item in namesAndScores)
			//		{
			//			Console.WriteLine(item.Key + " " + item.Value);
			//		}
			//	}
			//}
			//else
			//{
			//	Console.WriteLine(name + " not found");
			//	Console.WriteLine("If you want to add enter score");
			//	int score = int.Parse(Console.ReadLine());
			//	namesAndScores.Add(name, score);
			//	names.Add(name);
			//	foreach (var item in namesAndScores)
			//	{
			//		Console.WriteLine(item.Key + " " + item.Value);
			//	}
			//}




			//2.ფუნქციონალი
			//პროგრამამ უნდა შეძლოს:
			//			სტუდენტის დამატება
			//•	მომხმარებელი შეიყვანს სახელს და ქულას
			//•	დაამატეთ List-ში და Dictionary-ში
			// სტუდენტის ძებნა
			//•	მომხმარებელი შეიყვანს სახელს
			//•	თუ არსებობს → აჩვენეთ ქულა 
			//•	თუ არა → დაბეჭდეთ „სტუდენტი ვერ მოიძებნა“ 
			// ქულის განახლება
			//•	მომხმარებელი შეიყვანს სახელს და ახალ ქულას 
			//•	თუ სტუდენტი არსებობს → განაახლეთ ქულა Dictionary - ში
			// ყველა სტუდენტის ჩვენება
			//•	List - ის მიხედვით დაბეჭდეთ ყველა სტუდენტი და მათი ქულა



			//Console.WriteLine("Enter 1 to add student");
			//Console.WriteLine("Enter 2 to find student");
			//Console.WriteLine("Enter 3 to change score");
			//Console.WriteLine("Enter 4 to Show all");

			//string choose = Console.ReadLine();
			//switch (choose)
			//{
			//	case "1":
			//		string name = Console.ReadLine();
			//		int score = int.Parse(Console.ReadLine());
			//		names.Add(name);
			//		namesAndScores.Add(name, score);

			//		Console.WriteLine("Student added succesfully");

			//		break;

			//	case "2":
			//		string findName = Console.ReadLine();
			//		if (namesAndScores.ContainsKey(findName))
			//		{
			//			Console.WriteLine(findName + " " + namesAndScores[findName]);
			//		}
			//		else
			//		{
			//			Console.WriteLine("Studetn not found");
			//		}

			//		break;
			//	case "3":
			//		string changeName = Console.ReadLine();
			//		if (namesAndScores.ContainsKey(changeName))
			//		{
			//			 int changeScore = int.Parse(Console.ReadLine());
			//			 namesAndScores[changeName] = changeScore;
			//		}
			//		else
			//		{
			//			Console.WriteLine("Studetn not found");
			//		}
			//		break;

			//	case "4":

			//		foreach (var item in namesAndScores)
			//		{
			//			Console.WriteLine(item.Key + " " + item.Value);
			//		}

			//		break;
			//	default:
			//		Console.WriteLine("wring menu choose");
			//		break;
			//}

			#endregion
			
			//int[] arr = [20, 60, 50, 60, 70];

			//ArrayHelper ah = new();

			//ah.PrintArray(arr);

			//arr.PrintArray();

			//ArrayHelper.PrintArray(arr);




			//Console.WriteLine(arr.FindElement(100));


			//string[] names = ["dfd", "Fdf", "fdf"];

			User[] users = [new User() {Name = "fdfd", Password = "dsd" }, new User() {Name = "gggg", Password = "fdfd" }];

			//names.PrintArray();
			//users.PrintArray();



			//User user1 = new User() { Name = "John", Password = "123" }; // c/fdf/cfdfdgf
			//User user2 = new User() { Name = "John", Password = "123" };  // c/fdgghg/gfgfg


			//Console.WriteLine(user1.Equals(user2)); // faalse

			User findUser = new User() { Name = "fdfd", Password = "dsd" };

			Console.WriteLine(users.FindElement(findUser));

		}
	}
}


//generic - ზოგადი