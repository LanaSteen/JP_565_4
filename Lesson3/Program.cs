using Lesson3.Models;

namespace Lesson3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//	შექმენით მანქანის კლასი შემდეგი მახასიათებლებით:

			//რენდი,
			//მოდელი,
			//წლოვანება,  --
			//ძრავის მოცულობა, 
			//ფერი

			//დაამატეთ მეთოდები -
			//1.რომელიც გამოთვლის რომელ წელს არის მანქანა გამოშვებული
			//2.რომელიც დაბეჭდავს მანქანის ყველა მახასიათებელს.


			Car car = new();
			car.Brand = "Brand1";
			car.Model = "Model1";
			car.Year = 2;
			car.EngineCapaciry = 2.5;
			car.Color = Color.Red;


			car.GetCarYearInfo();
			Console.WriteLine(car);



			Console.WriteLine(DateTime.Now.Year);
			Console.WriteLine(DateTime.Now.Month);
			Console.WriteLine(DateTime.Now.Day);
			Console.WriteLine(DateTime.Now.TimeOfDay);
			Console.WriteLine(DateTime.Now.DayOfWeek);




			Actor actor = new Actor();
			Actor actor2 = new Actor();
			Actor actor3 = new Actor();
			Producer producer = new Producer();
			Dierctor director = new Dierctor();

			Film film = new Film();
			film.Dierctor = director;
			film.Producer = producer;

			film.Actors = [actor, actor2, actor3];


			actor.GetInfo();   // mshoblidan
			director.GetInfo(); //mshoblidan
			producer.GetInfo();  // sakutari






			Money money1 = new Money(); // lari
			money1.Currency = "GEL";
			money1.Amount = 100;




			Money money2 = new Money();  // euro
			money2.Currency = "EUR";
			money2.Amount = 201;


			Money money3 = new Money();  // euro
			money3.Currency = "EUR";
			money3.Amount = 50;


			var result = money2.Amount + money3.Amount;   // 250

			var sum = money2 + money3;

			Console.WriteLine(sum);


			var sum2 = money2 - money3;
			Console.WriteLine(money2 != money3); // true



			var sum3= money2 % money3; // 0
			Console.WriteLine(sum3);


			money2++;
			Console.WriteLine(money2);


			Console.WriteLine(money2 > money3);  //true
		}
	}
}




//ოპერატორების გადატვირთვა




// film studio  


//Actor
//Director
//Producer

//Film


//მემკვიდრეობა  / აბსტრაქცია