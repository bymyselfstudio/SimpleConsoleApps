using System;
					
class Program
{
	static void Main()
	{
		Console.WriteLine($"\nResult = {Factorial(6)}");
	}
	
	static int Factorial(int number)
	{
		int sum = 1;
		while (number > 0)
		{
			// Just for debugging
			if (sum > 1)
			{
				Console.WriteLine(sum);
			}
			sum *= number--;
		}
		return sum;
	}
}
