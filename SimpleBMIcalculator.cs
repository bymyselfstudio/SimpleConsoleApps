using System;

namespace CalculateBMI
{
    internal class Program
    {
		public static void Main()
		{
			// Example input: 85;1,87 --> 85kg, 1,87m (no space in between!)
			Console.Write("Type your weight in kg and your size in m. Separate values with semikolon: ");
			string values = Console.ReadLine();
			Console.WriteLine($"Your BMI is: {GetBMI(values)}");
		}

		static double GetBMI(string _values)
		{
			string[] seperatedValues = _values.Split(';');
			double[] numberValues = new double[seperatedValues.Length];

            for (int i = 0; i < seperatedValues.Length; i++)
            {
				numberValues[i] = Convert.ToDouble(seperatedValues[i]);
            }

			double bmi = Math.Round((numberValues[0] / numberValues[1] / numberValues[1]), 2);
			
			return bmi;
		}
	}
}
