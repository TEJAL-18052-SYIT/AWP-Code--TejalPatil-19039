class Practical1d5
{
	public static void Main(string[] args)
	{
		int n=System.Convert.ToInt32(args[0]);
		int rv=reverse(n);
		int sum=sumofnumber(n);
		
		System.Console.WriteLine("revresed number="+rv);
		System.Console.WriteLine("sum of number="+sum);
	}
	
	static int reverse(int number)
	{
		int reversed=0;
		while(number>0)
		{
			int digit=number%10;
			reversed=reversed*10+digit;
			number/=10;
		}
		return reversed;
	}

	static int sumofnumber(int number)
	{
		int sum=0;
		while(number>0)
		{
			int digit=number%10;
			sum+=digit;
			number/=10;
		}
		return sum;
	}
}