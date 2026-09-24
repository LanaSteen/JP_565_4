using System.Text;
using System.Text.RegularExpressions;

namespace Lesson1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//test change

			#region   console    datatypes




			//Console.WriteLine("Hello, World!");
			//Console.ReadLine();
			//Console.Write("Press any key to continue...");


			//Console.OutputEncoding =  Encoding.UTF8;  // 
			//Console.InputEncoding = Encoding.UTF8;   //

			//Console.WriteLine("გამარჯობა");


			//Console.BackgroundColor = ConsoleColor.DarkBlue;
			//Console.ForegroundColor = ConsoleColor.Red;


			//int num = 5;
			//var x = 10;

			//int z;  //0


			//var rame = 2.3;


			// მთელი ტიპი  0

			//byte  -- 0 - 255
			//short
			//int   ---------- default
			//long

			///  წილადური ტიპი
			// float 
			// double   -------- default
			// decimal

			//	bool  /// true false  /// false

			//	string    "Hello"     /// null
			//	char     '2'  'a'  '1'





			// method   vs  function



			#endregion

			#region oppertors   loops   conditionals

			//   +  -  *  /    %  
			//++ --    +=   -= *=  /=   %=
			//>  <  >=  <=  ==  !=    
			//&&  ||   !  

			//    ?  ternary operator  :   if else

			//Console.WriteLine(5>3 ? "Yes" : "No");


			////??   null coalescing operator

			//string name = Console.ReadLine();

			//Console.WriteLine(name ?? "user");





			//      int age =  int.Parse(Console.ReadLine());

			//int score = Convert.ToInt32(Console.ReadLine());




			//   int result;


			//   bool isValidNumber = int.TryParse(Console.ReadLine(), out  result);  // true is parse was successful, false if it failed



			//if (isValidNumber)
			//{
			//	Console.WriteLine("result is " + result);
			//}
			//else
			//{
			//	Console.WriteLine("Invalid number");
			//}

			//int day = 3;

			//if(day == 1)
			//{
			//	Console.WriteLine("Monday");
			//}
			//else if (day == 2)
			//{
			//	Console.WriteLine("Tuesday");
			//}
			//else if (day == 3)
			//{
			//	Console.WriteLine("Wednesday");
			//}
			//else
			//{
			//	Console.WriteLine("Unknown day");
			//}


			//switch (day)
			//{

			//	case 1:
			//		Console.WriteLine("Monday");
			//		break;

			//	case 2:
			//		Console.WriteLine("Tuesday");
			//		break;
			//	case 3:
			//		Console.WriteLine("Wednesday");
			//		break;
			//	default:
			//		Console.WriteLine("Unknown day");
			//		break;
			//}




			//Array  --  ფიქსირებული ზომა აქვს და ტიპიზირებულია

			//int[] numbers = {2,3,6 };

			//int[] numbers = [1,6,3];

			//int[] nums = new int[5];   //   [0,0,0,0,0]

			//	nums[0] = 50;
			//   nums[1] = 60; 
			////  [50, 60, 0, 0, 0]


			//string[] names = new string[3];  // [null, null, null]



			//loop


			//for (int i = 0; i < 5; i++)
			//{
			//	Console.WriteLine(i);
			//}   // for


			//for (int i = 10; i >= 0; i--)
			//{

			//}  //  forr



			//int x = 11;


			//while (x<10)
			//{
			//	Console.WriteLine("hi while");
			//	x++;
			//}



			//do
			//{
			//	Console.WriteLine("hi do while");
			//	x++;  // 12
			//}
			//while (x < 10);
			//
			//
			//int[] numers = { 1, 2, 3, 4, 5 };


			//for (int i = 0; i < numers.Length; i++)
			//{
			//	Console.WriteLine(numers[i]);
			//}

			//foreach (int number in numers)
			//{
			//	Console.WriteLine(number);
			//}


			#endregion



			#region local functions vs methods


			//void //  return არ აქვს

			//void print()
			//{
			//	Console.WriteLine("Hello from local function");
			//}
			//print();


			//   string textToUpper(string text)
			//{
			//	return text.ToUpper();
			//}



			//    string result = textToUpper("text");  // "TEXT"
			// Console.WriteLine(result);


			#endregion


			//PrintMessage("Hello from method");


			Console.WriteLine(AddNumbers(3, 5));

		}
	
	  
		
		
	   static void PrintMessage(string message)
		{
			Console.WriteLine(message);
		}




		static int AddNumbers(int a, int b)
		 {
			return a + b;

		  }
}
}

//static  - უცვლელი
