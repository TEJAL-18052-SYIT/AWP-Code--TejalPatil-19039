using System;

class Reverse
{
	static void Main(String[] args)
	{
		Console.Write("enter the numbers: ");
		int number=int.Parse(Console.ReadLine());
		int reversedNumber=ReverseDigits(number);
		Console.WriteLine("Reversed number is:  "+reversedNumber);
	}

static int ReverseDigits(int number)
{
	int reversedNumber=0;
	while(number!=0)
	{
		int remainder=number%10;
		reversedNumber=reversedNumber*10+remainder;
		number/=10;
	}
	
	return reversedNumber;
}
}