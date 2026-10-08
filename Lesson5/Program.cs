using System.Globalization;

namespace Lesson5
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region list


			List<int> saxeli = new List<int>() { 20, 30, 60, 60 };
			List<int> saxeli2 = new();
			saxeli2.Add(20);
			saxeli2.Add(30);
			saxeli2.AddRange(saxeli);

			saxeli2.Remove(60);

			//Console.WriteLine(saxeli2.Contains(60)); /// true

			while (saxeli2.Contains(60))
			{
				saxeli2.Remove(60);
			}


			saxeli2.Insert(0, 500);


			//Console.WriteLine(saxeli2.IndexOf(20)); //1


			//saxeli2.Clear();  
			//saxeli2.RemoveAt(saxeli2.Count-1);
			//saxeli2.RemoveRange(1, 2);

			saxeli2.Sort();

			saxeli2.Reverse();

			var sorted = saxeli2;




			//foreach (var item in saxeli2)
			//{
			//	Console.WriteLine(item);
			//}




			//,15, 20, 30, 50,
			//a,b=> a-b
			//a, b => a - b  true





			//for (int i = 0; i <= saxeli2.Count/2; i++)
			//{
			//	Console.WriteLine(saxeli2[i]);
			//}


			//20,30 , 20,30,60

			//saxeli2.AddRange(20, 30, 60);


			User saxeliuser = new User();





			List<int> numbers = new List<int>();

			numbers.Add(20);
			numbers.Add(20);
			numbers.Add(20);
			numbers.Add(20);

			numbers.Add(20);
			numbers.Add(20);
			numbers.Add(20);
			numbers.Add(20);

			numbers.Add(20);
			numbers.Add(20);
			numbers.Add(20);
			numbers.Add(20);

			numbers.Add(20);
			numbers.Add(20);
			numbers.Add(20);
			numbers.Add(20);

			numbers.Add(20);
			numbers.Add(20);
			numbers.Add(20);
			numbers.Add(20);

			numbers.Add(20);
			numbers.Add(20);
			numbers.Add(20);
			numbers.Add(20);

			numbers.Add(20);

			//Console.WriteLine(numbers.Count);  /// ramdeni elementia
			//Console.WriteLine(numbers.Capacity); // ramdeni elementi eteva

			//numbers.TrimExcess();


			//Console.WriteLine(numbers.Count);  /// ramdeni elementia
			//Console.WriteLine(numbers.Capacity); 





			#endregion


			#region hashset


			//კოლექცია  array 
			//list
			//HashSet<int> nums = new() { 2,3,2,4};  // უნიკალური ელემეტებია მხოლოდ
			//nums.Add(2);
			////{ 2,3,4}


			//foreach (var item in nums)
			//{
			//	Console.WriteLine(item);
			//}


			//List<string> countries = new List<string>() {"Georgia", "Italy", "USA", "Italy", };

			//var distinct = countries.ToHashSet();

			//foreach (var item in distinct)
			//{
			//	Console.WriteLine(item);
			//}



			//List<string> empty = new List<string>();

			//foreach (var item in countries)
			//{
			//	if (!empty.Contains(item))
			//	{
			//		empty.Add(item);
			//	}
			//}

			//foreach (var item in empty)
			//{
			//	Console.WriteLine(item);
			//}


			#endregion



			//F I F O
			//Queue<string> queue = new Queue<string>();  // პირველი ვინც დაემატება პირველი ის გადის
			//queue.Enqueue("John");
			//queue.Enqueue("Jane");

			//Console.WriteLine(queue.Peek());  // ვისი რიგია John

			//queue.Dequeue();  // John

			//Console.WriteLine(queue.Peek());  // jane
			//queue.Dequeue(); // jane



			//L I F O 
			//Stack<string> stack = new Stack<string>();  // პირველი შემოსული ბოლო გავა

			//stack.Push("hello");
			//stack.Push("gamarjoba");

			//Console.WriteLine(stack.Peek()); // gamarjoba

			//stack.Pop();///   gamarjoba


			//Console.WriteLine(stack.Peek());  // hello



			//Print();



			//Console.WriteLine(Powerer(5,3));

			//0 1 2

			//"hELLO" -  "GAMARJOBA"
			
			//Dictionary<string, string> translator = new();

			//translator.Add("hello", "gamarjoba");
			//translator.Add("Good bye", "naxvamdis");
			//translator.Add("thank you", "madloba");


			//Console.WriteLine(translator["hello"]);




			Dictionary<string, string> hotLine = new();
			
			hotLine.Add("Manager", "+99559959959");
			hotLine.Add("marketing", "+9955454545");
			hotLine.Add("support",  "+995787878");
			hotLine.Add("support2", "+995787878");


			Console.WriteLine(hotLine["support"]);


			foreach (var item in hotLine)
			{
				Console.Write(item.Key);
				Console.Write(" - ");
				Console.Write(item.Value);
				Console.WriteLine();
			}

			


		}

		//    2 ^ 4
		//2 * 2 ^ 3
		//2 * 2 ^ 2
		//2 * 2 ^ 1
		//2

		//recursion

		//public static int Powerer(int num,  int pow)
		//{
		//	if(pow == 1)
		//	{
		//		return num;
		//	}

		//	return num * Powerer(num, pow-1);
		//}


		//public static void Print()
		//{
		//	Print();
		//}




		//5!  =  120
		//5 * 4 * 3 * 2 * 1


		//public static int Factorial(int num)
		//{
		//	if(num == 1)
		//	{
		//		return 1;
		//	}
		//           //5 *     //4   *   3  *  2 * 1 FACTORIALZE
		//	return num * Factorial(num - 1);
		//}
	}

}