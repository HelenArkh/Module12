using System;
using System.Collections.Generic;
using System.Threading;

namespace Module12
{
    class Program
    {
        static void Main(string[] args)
        {
			List<User> users = new List<User>(3);
			users.Add(new User() { Login = "tommy",Name = "Том", IsPremium = false });
			users.Add(new User() { Login = "billy", Name = "Билл", IsPremium = true });
			users.Add(new User() { Login = "ann", Name = "Аня", IsPremium = false });

			GreetingAndAdvertisement(users);

			Console.WriteLine("Конец программы");
		}

		static void GreetingAndAdvertisement(List<User> users)
        {
			foreach (User user in users)
			{
				Console.WriteLine($"Привет, {user.Name}");

				if(user.IsPremium == false)
                {
					ShowAds();
                }
			}
		}

		static void ShowAds()
		{
			Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
			// Остановка на 1 с
			Thread.Sleep(1000);

			Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
			// Остановка на 2 с
			Thread.Sleep(2000);

			Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
			// Остановка на 3 с
			Thread.Sleep(3000);
		}
	}
}
