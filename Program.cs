using System;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите число");
			try
			{
				int a = int.Parse(Console.ReadLine());
				int[] arr = new int[10];
				Random r = new Random();
				for (int i = 0; i < arr.Length; i++)
				{
					arr[i] = r.Next(0, a + 1);
					Console.Write(arr[i] + " ");
				}
				for (int i = 0; i < arr.Length; i++)
					for (int j = 1; j < arr.Length - i; j++)
					{
						if (arr[j] < arr[j - 1])
						{
							int s = arr[j];
							arr[j] = arr[j - 1];
							arr[j - 1] = s;
						}
					}
				Console.WriteLine();
				for (int i = 0; i < arr.Length; i++)
				{
					Console.Write(arr[i] + "");
				}
				Console.WriteLine();
				int k = -1, b = int.Parse(Console.ReadLine());
				for (int i = 0; i < arr.Length; i++)
				{
					if (b == arr[i])
					{
						k = i;
						break;
					}
				}

				if (k != -1)
					Console.WriteLine(k);
				else
					Console.WriteLine("такого значения нет");


			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			Console.ReadKey();
		}
	}
}

		

	

