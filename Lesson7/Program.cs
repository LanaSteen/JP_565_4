namespace Lesson7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");




			//Console.WriteLine();

			//   var firstElement=	ArrayHelper.GetFirstElement([20,30,60]);  //20
			//Console.WriteLine(firstElement);



			//int[] numbers = [20, 30, 60];
			//numbers.GetFirstElement();


			//Console.WriteLine(numbers.ContainsElement(20));  // true




			//string name = "john";
			//name.PrintUpper();


			//User[] users = []
			//User user = new User();

			//იუზერის კლასი რომელსაც აქვს სახელი და პაროლი 
			//	ობიექტი და ამ იუზერების მასივი

			//	FindIndex
			//	
			//User[] users = [new User{Name = "John", Password ="123" }, new User{Name ="Jane", Password="456" }];
			//User searchUser = new User() { Name = "John", Password = "123" };

			//Console.WriteLine(users.FindIndex(searchUser));  // -1




			//User user1 = new User();  //

			//User user2 = new User();  // 


			//Console.WriteLine(user1.Equals(user2));



			//List<int> numbers123 = new List<int>() { 20,60,30,70};





			//numbers123.Where(x => numbers123.Contains(x));





			//List<string> names = new List<string>() { "dsd", "dsd"};
			//numbers123.Count();
			//names.Add("Sds");


			//numbers123.Print();

			//List<User> usersList = new List<User>() { new User { Name = "John", Password = "123" }, new User { Name = "Jane", Password = "456" } };




			//FIFO

			//Queue<int> queue = new Queue<int>();

			//  queue.Enqueue(1);

			//Lifo
			//Stack 


			//queue.Print();

			//Dictionary<int, int> names123456 = new Dictionary<int, int>();

			//names123456.Print();
			//
			//

			string[] names = ["John", "Jan6565656", "Jack12"];

			var fileterednAmes = names.CustomWhere(LengIsSmallerthen5);

			foreach (var item in fileterednAmes)
			{
				Console.WriteLine(item);
			}




			int[] numbers = [50, 60, 70, 80, 15];
			var filtered = numbers.CustomWhere(GreateThen50);
			var filtered2 = numbers.CustomWhere(GreateThen60);

			foreach (var item in filtered2)
			{
				Console.WriteLine(item);
			}



			//GreateThen50(70); // true
		}




		public static bool GreateThen50(int num)
		{
			return num > 50;
		}

		public static bool GreateThen60(int num)
		{
			return num > 60;
		}


		public static bool LengIsSmallerthen5(string name)
		{
			return name.Length < 5;
		}
	}
}
