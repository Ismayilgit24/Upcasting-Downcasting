using System.Reflection;
using System.Security.Cryptography;

namespace Upcasting__Downcasting
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Apple apple = new Apple { Price = 1.2m, Sort = "Golden", VitaminA = 50, VitaminB = 30 };
			PineApple pineapple = new PineApple { Price = 2.5m, Sort = "Hawaiian", VitaminE = 40, VitaminD = 60 };
			Orange orange = new Orange { Price = 1.8m, Sort = "Navel", VitaminC = 70 };

			Fruit[] Basket = { apple, pineapple, orange };

			Assembly assembly = Assembly.GetExecutingAssembly();

			Type[] types = assembly.GetTypes();

			foreach (var fruit in Basket)
			{
				Type type = fruit.GetType();
				Console.WriteLine($"Type: {type.Name}");

				FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);


				foreach (FieldInfo field in fields)
				{
					object value = field.GetValue(fruit);
					Console.WriteLine($"Field: {field.Name} Value: {value}");

                    
				}
				Console.WriteLine("---------------------------------------------------");

			}
		}
	}
}





