using System.Collections;
using System.Xml.Linq;

namespace Lesson8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");



			//int[] arr = [20, 50];
			//string[] arr2 = ["Hello", "World"];
			//arr.Print();

			//Collectionhelper.Print(arr);
			//Collectionhelper.Print(arr2);


			//List<int> list = new List<int>() { 20, 50 };
			//Collectionhelper.Print(list);


			//list.Print();

			//int num1 = 20;
			//int num2 = 30;
			//Collectionhelper.sum(num1, num2); // 50

			//num1.sum(num2); // 50



			//Array.Reverse(arr);          // icollection
			//List  // IList<T>  ICollection<T>
			//HashSet            ICollection<T>

			//Dictionary         ICollection


			//IEnumerable


			List<string> list = new List<string>() {"name1", "name" };
			int[] arr = [20,60, 50,25,40,60,75,98];

			Console.WriteLine(arr.CustomFind(10));

			list.CustomFind("name1");
			//arr.CustomFIlter(rame);




			//bool rame(int num)
			//{
			//	return num > 50;
			//}
			//bool rame2(int num)
			//{
			//	return num > 90;
			//}

			//bool rame3(string name)
			//{
			//	return name.Length ==5;
			//}

			//list.CustomFirstorDefault(delegate(string name)
			//{
			//	return name.Length == 5;
			//});
			//list.CustomFirstorDefault(delegate (string name)
			//{
			//	return name.Length >4;
			//});


			list.CustomFirstorDefault(name=> name.Length == 4);


			//list.CustomFirstorDefault(rame3);

			//arr.CustomFirstorDefault(rame2);
			//arr.CustomFirstorDefault(rame);  // 60

			arr.CustomFirstorDefault(num => num > 90);
			arr.CustomFirstorDefault(num => num > 60);

			int[] arr2 = [20, 60, 50, 25, 40, 60, 75, 98];

			arr2.CustomSelect(x => x * 10);

			decimal[] Prices = [20, 60, 50, 25, 40, 60, 75, 98];  //usd

			Prices.CustomSelect(x => x * 2.62m); //gel




			var convertedArr = Prices.CustomSelect2(x=>(int)x);
		}



		public static int test(int num)=> num + 10;
	

	}
}
