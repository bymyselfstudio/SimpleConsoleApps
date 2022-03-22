using System;

public class Program
{
	public static void Main()
	{
		int num = 0;
		Console.WriteLine("Please type a word or a sentence");
		string input = Console.ReadLine().ToLower();
		char[] charArray = input.ToCharArray();

		foreach (char c in charArray)
		{
			if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
				num++;
		}

		if (input.Contains(' ') && num == 1)
		{
			Console.Write("\nThis sentence contains {0} vowel.", num);
		}

		else if (input.Contains(' ') && num > 1)
		{
			Console.Write("\nThis sentence contains {0} vowels.", num);
		}

		else if (!input.Contains(' ') && num == 1)
		{
			Console.Write("\nThis word contains {0} vowel.", num);
		}

		else if (!input.Contains(' ') && num > 1)
		{
			Console.Write("\nThis word contains {0} vowels.", num);
		}

		else
		{
			Console.WriteLine("The input doesn't contain any vowels!");
		}
	}
}
