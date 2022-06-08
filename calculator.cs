using System;

public class Program
{
	public static void Main(string[] args)
	{
		int operators;
		double num1 = 0;
		double ans = 0;
		double num2 = 0;
		Console.WriteLine("Welcome!\n");
		Console.WriteLine("Press any key to start.\n");
		Console.ReadLine();
		Console.WriteLine("Choose an operator.\n");
		operators = Convert.ToInt32(Console.ReadLine());
		switch (operators)
		{
			case 1:
				Console.WriteLine("\nAddtions:\n");
				Console.WriteLine("Enter first number :");
				num1 = double.Parse(Console.ReadLine());
				Console.WriteLine("\nEnter second number 2:");
				num2 = double.Parse(Console.ReadLine());
				ans = num1 + num2;
				Console.WriteLine("\n" + num1.ToString() + " " + "+" + " " + num2.ToString());
				Console.WriteLine("\nAnswer:" + ans);
				break;
			case 2:
				Console.WriteLine("\nSubtraction:\n");
				Console.WriteLine("Enter first number :");
				num1 = double.Parse(Console.ReadLine());
				Console.WriteLine("\nEnter second number :");
				num2 = double.Parse(Console.ReadLine());
				ans = num1 - num2;
				Console.WriteLine("\n" + num1.ToString() + " " + "-" + " " + num2.ToString());
				Console.WriteLine("\nAnswer:" + ans);
				break;
			case 3:
				Console.WriteLine("\nMultiply:\n");
				Console.WriteLine("Enter first number :");
				num1 = double.Parse(Console.ReadLine());
				Console.WriteLine("\nEnter second number :");
				num2 = double.Parse(Console.ReadLine());
				ans = num1 * num2;
				Console.WriteLine("\n" + num1.ToString() + " " + "*" + " " + num2.ToString());
				Console.WriteLine("\nAnswer:" + ans);
				break;
			case 4:
				Console.WriteLine("\nDivision:\n");
				Console.WriteLine("Enter first number :");
				num1 = double.Parse(Console.ReadLine());
				Console.WriteLine("\nEnter second number :");
				num2 = double.Parse(Console.ReadLine());
				ans = num1 / num2;
				Console.WriteLine("\n" + num1.ToString() + " " + "/" + " " + num2.ToString());
				Console.WriteLine("\nAnswer:" + ans);
				break;
			case 5:
				Console.WriteLine("\nSquare Root:\n");
				Console.WriteLine("\nEnter the number:");
				num1 = double.Parse(Console.ReadLine());
				Console.WriteLine("\nAnswer: " + Math.Sqrt(num1));
				break;
			default:
				Console.WriteLine("\nNot Known");
				break;
		}

		Console.WriteLine("\nPress any key to exit.");
		Console.ReadLine();
	}
}