namespace Lesson28
{
	internal class Program
	{
		static async Task Main(string[] args)
		{

			#region thread 
			//Thread.CurrentThread.Name = "Main Thread";

			//Console.WriteLine(Thread.CurrentThread.Name);
			//Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 2



			//Thread thread1 = new Thread(() =>
			//{
			//	Thread.Sleep(2000); // Simulate some work being done in the new thread

			//	Thread.CurrentThread.Name = "New Thread ";
			//	Console.WriteLine(Thread.CurrentThread.Name);
			//	Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 9

			//});

			//thread1.Priority = ThreadPriority.Highest;


			//thread1.Start();



			//Thread thread2 = new Thread(Working);
			//thread2.Start();





			//Thread.Sleep(2000); // Simulate some work being done in the new thread

			//thread1.Join(); // Wait for thread1 to finish 
			//Console.WriteLine("Main Thread finished.");




			//bool threadRunning = true;
			//long lowThreadCounter = 0;
			//long highThreadCounter = 0;

			//Thread lowThread = new Thread(() =>
			//{
			//	while (threadRunning)
			//	{
			//		lowThreadCounter++;
			//	}
			//});


			//Thread highThread = new Thread(() =>
			//{
			//	while (threadRunning)
			//	{
			//		highThreadCounter++;
			//	}
			//});

			//lowThread.Priority = ThreadPriority.Lowest;
			//highThread.Priority = ThreadPriority.Highest;

			//lowThread.Start();
			//highThread.Start();

			//Thread.Sleep(2000); // Let the threads run for 1 second
			//threadRunning = false;


			//lowThread.Join();
			//highThread.Join();



			//Console.WriteLine($"Low Thread Counter: {lowThreadCounter}");
			//Console.WriteLine($"High Thread Counter: {highThreadCounter}");



			#endregion


			#region Task
			//Console.WriteLine("program started.....");

			//Task t =  Task.Delay(2000);
			//await t;

			//Console.WriteLine("program finished.....");
			#endregion


			UserService userService = new UserService();

			User newuser = new User
			{
				Id = 3,
				Name = "Alice Johnson",
				Email = "dssdsd@fgfg"
			};

			 await userService.AddUserAsync(newuser);



			var users = await userService.GetAllUsersAsync();

			foreach (var item in users)
			{
				Console.WriteLine(item);
			}


			User user = await userService.GetUserByIdAsync(1);
			Console.WriteLine(user);
		}


		static void Working()
		{
			Thread.CurrentThread.Name = "Working Thread";
			Console.WriteLine(Thread.CurrentThread.Name);
			Console.WriteLine(Thread.CurrentThread.ManagedThreadId); // 9
		}
	
	}
}
