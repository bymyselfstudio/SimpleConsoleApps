using System;
					
class Program
{
	static void Main()
	{
		Console.WriteLine($"\nResult = {AddAllNumbers(100)}");
	}
	
	static int AddAllNumbers(int number)
	{
		int sum = 0;
		
		while (number > 0)
		{
			// Just for debugging
			if (number > 0)
			{
				Console.WriteLine(number);
			}
			
			sum += number--;
		}
		return sum;
	}
}
