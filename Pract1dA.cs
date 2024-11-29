class Pract1dA
{
	public static void Main(string[] args) 
	{
		int number=System.Convert.ToInt32(args[0]);
		int a=0;
		int b=1;
		int c;
		System.Console.WriteLine("{0}\n{1}", a, b);
		for(int i=1;i<=number;i++)
		{
			c=a+b;
			System.Console.WriteLine("{0}\n", c);
			a=b;
			b=c;
		}
	
	}
}