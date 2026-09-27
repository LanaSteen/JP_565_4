using Lesson2.Models;

namespace Lesson2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");


			User user = new("Joohn", 2000);
			// user.UserName = "Joohn";


			user.PrintUserName();

			User user2 = new();
			//user2.UserName = "Joohn2";


			user2.PrintUserName();

			User.Test();

			user.BirthYear = 2000;

			int userAge = user.GetAge();

			Console.WriteLine(userAge);  // 26

			User user3 = new();
			User user4 = new(2000);
			User user5 = new("Joohn");
			User user6 = new("Joohn", 1990);

			user.Age = 20;
			Console.WriteLine(user.Age);


			//user.DisplayInfo();


			Console.WriteLine(user);




			User test1Uers = new("test1", 2000);  ///  heap/place/ddfgfh1263
			User test2Uers = new("test1", 2000);  ///  heap/place/ddfgfh1264


			Console.WriteLine(test1Uers == test2Uers);   // false

			Console.WriteLine(test1Uers.Equals(test2Uers));  // true

		}
	}


}




// product   
// სახელი
// ფასი   --   უარყოფითი რიცხვი არ შეიძლება
// ბრენდი 

// დაბეჭდავს ყველა ინფორმაციას