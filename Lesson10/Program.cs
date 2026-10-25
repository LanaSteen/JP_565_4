using System.Data;

namespace Lesson10
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region linq

			//int[] numbers = [20, 80, 45, 32, 98];


			//numbers.Where(x => x > 50);

			//numbers.Where(x => x % 2 == 0);

			//   var sorted = numbers.OrderByDescending(x => x).Skip(1).Take(3);

			//foreach (var item in sorted)
			//{
			//	Console.WriteLine(item);
			//}


			////numbers.Reverse(); // 98,32,45,80,20
			//numbers.Count(x=> x>50);


			//List<string> names = new List<string> { "John", "Jane", "Alice", "Bob" };

			//var result = names.Where(el => el.Length > 4);
			//foreach (var item in names)
			//{
			//	Console.WriteLine(item);
			//}


			//var result2 = names.Count(el => el.StartsWith("J"));


			//var restult4 = names.Select(el => el.ToUpper());

			////""  Any     All 
			////some     every

			//var res = names.Any(x => x == "");
			//var res2 = names.All(x => x != "");





			//Student st = new Student { Name = "John", Age = 20, Grade = 90 };
			//Student st2 = new Student { Name = "Jane", Age = 22, Grade = 85 };
			//Student st3 = new Student { Name = "Alice", Age = 19, Grade = 95 };
			//Student st4 = new Student { Name = "Bob", Age = 22, Grade = 80 };

			//List<Student> students = new List<Student> { st, st2, st3, st4 };


			//var result6 = students.OrderBy(x => x.Age).ThenBy(x => x.Grade).ThenBy(x => x.Name);

			//foreach (var item in result6)
			//{
			//	Console.WriteLine(item);
			//}






			//შექმენით იუზერის კლასი და გააკეთეთ მისი კოლექცია. დაალაგეთ 
			//იუზერის სახელის ანბანური დალაგებით და ასევე დაალაგეთ იუზერების პაროლების
			//სიმბოლოების რაოდენობის მიხედვით და აიღეთ top 5 იუზერი და დაბეჭდეთ ისინი.

			#endregion


			//string path = "C:\\Users\\l4nst\\Desktop\\JP_565_4 online\\Lesson10\\Data\\User.txt";
			string path = @"C:\Users\l4nst\Desktop\JP_565_4 online\Lesson10\Data\User.txt";

			//File.AppendAllLines(path, ["one", "two", "three"]);

			string choice ="";
			while(choice != "0")
			{
				Console.WriteLine("1. Register\n2. Show Users\n0. Exit");
				choice = Console.ReadLine();

				switch (choice)
				{
					case "1":

						var users1 = File.ReadAllLines(path).ToList();
						string maxId = users1.Max(x => x.Split('|')[0]) ?? "0";    // [1|dsdsd|fdf|fdfdd
						int newID = int.Parse(maxId) + 1;

						User user = new User();

						user.Id = newID;
						Console.WriteLine("Enter username:");
						user.Username = Console.ReadLine();
						Console.WriteLine("Enter password:");
						user.Password = Console.ReadLine();
						Console.WriteLine("Enter email:");
						user.Email = Console.ReadLine();

						File.AppendAllLines(path, [user.ToString()]);

						break;

					case "2":
						var users = File.ReadAllLines(path).ToList();
						/// 1|dsdsd|fdf|fdfdd
						foreach (var item in users)
						{
							Console.WriteLine(item);
						}

						break;
					case "0":
						Console.WriteLine("Exiting...");
						break;
				}
			}




	





		



		}
	}
}
