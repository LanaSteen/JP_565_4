using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson9
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region delegate

			//arr.filter( x => x>5);
			//arr.sort((a, b) => a-b));
			//arr.find(x => x > 5
			//
			//



			//int[] numbers = { 20, 30, 60, 75, 18 };

			//numbers.CustomAny(x => x > 50); // true
			//numbers.CustomAny(x => x > 80); // false


			//numbers.CustomCount(x => x > 50); // 2
			//numbers.CustomCount(); // 5



			//string[] names = { "John", "Jane", "Alice", "Bob" };
			//names.PrintByLogic(x => x.StartsWith("J"));


			//CollectionHelper.PrintByLogic(numbers, x => x > 50);
			//numbers.PrintByLogic(x => x > 50);



			//bool rame(string el)
			//{
			//   return el.Length > 3;
			//}

			//bool rame2(string el)
			//{
			//	return el.StartsWith("J");
			//}
			//bool rame3(int x)
			//{
			//	return x > 50;
			//}
			//bool rame4(int x)
			//{
			//	return x > 60;
			//}

			//numbers.PrintByLogic(delegate (int x)
			//{
			//	return x > 60;
			//});

			//numbers.PrintByLogic(delegate (int x)
			//{
			//	return x > 40;
			//});

			//numbers.PrintByLogic( x => x%2==0);

			//         numbers.PrintByLogic3(x => x * 2); // This will print each number multiplied by 2
			//numbers.PrintByLogic4(x => x.ToString()); // This will print each number as a string

			//numbers.PrintByLogic4(x => x * 2.62);




			//numbers.Print();
			//numbers.PrintByLogic(x => x % 5 ==0);
			//numbers.PrintByLogic(x => x >50);

			//Where ფილტრავს კოლექციას და აბრუნებს მხოლოდ იმ ელემენტებს,
			//რომლებიც მოცემულ პირობას აკმაყოფილებენ.


			//FirstOrDefault აბრუნებს პირველ ელემენტს, რომელიც შეესაბამება პირობას.
			//ხოლო თუ ვერ იპოვა — აბრუნებს default მნიშვნელობას(null, 0, false და ა.შ.).


			//Any ამოწმებს არსებობს თუ არა მინიმუმ ერთი ელემენტი,
			//რომელიც პირობას აკმაყოფილებს. აბრუნებს true ან false.


			//All ამოწმებს აკმაყოფილებს თუ არა ყველა ელემენტი მოცემულ პირობას.
			//აბრუნებს true ან false.



			//Count ითვლის ელემენტების რაოდენობას(სურვილის შემთხვევაში მხოლოდ იმათ,
			//რომლებიც პირობას აკმაყოფილებენ).

			#endregion





			#region linq

			// where  --> filter
			// select --> map --> convertacia

			// orderby --> sort
			// orderByDescending --> sort desc
			// ThenBy
			// ThenByDescending
			// Reverse
			// take
			// skip


			int[] nums = [20, 60, 30, 15];

			Array.Reverse(nums); // 15,30,60,20)
			nums.Reverse(); // 20,60,30,15

			//nums.Where(x => x > 50);
			//nums.Where(x => x %3 ==0);

			//   var converted =	nums.Select(x => x / 0.5);
			//var converted2 = nums.Select(x => x * 0.5);

			//foreach (var item in converted2)
			//{
			//	Console.WriteLine(item);
			//}
			//var sorted = nums.OrderBy(x => x);  // 15,20,30,60
			//var sordted2 = nums.OrderByDescending(x => x); // 60,30,20,15


			List<string> names = new List<string> { "John", "Jane", "Alice", "Bob" };

			//names.OrderBy(x => x.Length); // Alice, John, Jane, Bob




			Student stu1 = new Student { Age = 20, Grade = 90, Name = "Alice" };
			Student stu2 = new Student { Age = 25, Grade = 91, Name = "Bob" };
			Student stu3 = new Student { Age = 21, Grade = 80, Name = "John" };
			Student stu4 = new Student { Age = 21, Grade = 78, Name = "Jane" };

			List<Student> students = new List<Student> { stu1, stu2, stu3, stu4 };

			students.Reverse(); // stu4, stu3, stu2, stu1

			var sortedStudents = students
							.OrderBy(x => x.Age)
							.ThenBy(x => x.Grade)
							.Where(x => x.Grade > 75)
							.Skip(1)
							.Take(2); // stu1, stu3,

			foreach (var item in sortedStudents)
			{
				Console.WriteLine(item);
			}







			int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13];


			int pageIndex = 1;
			int pageSize = 6;

			pageIndex++;

			var page = numbers.Skip((pageIndex-1)* pageSize).Take(pageSize);


			foreach (var item in page)
			{
				Console.WriteLine(item);
			}

			#endregion
		}
	}
}
