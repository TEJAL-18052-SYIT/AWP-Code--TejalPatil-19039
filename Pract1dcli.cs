class Pract1dcli
{
	public static void Main(string[] args)
	{
		System.Console.WriteLine("Enter first number ");
		int a=System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine("Enter second number ");	
		int b=System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine("Enter third number ");
		int c=System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine("Enter fourth number ");
		int d=System.Convert.ToInt32(System.Console.ReadLine());
		int result=a*b*c*d;
		System.Console.WriteLine("The Product is " + result);
	}
	
}