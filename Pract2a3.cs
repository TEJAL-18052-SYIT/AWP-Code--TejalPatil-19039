class Pract2a3
{
	public static void Main(string[] args)
	{
		int a=System.Convert.ToInt32(args[0]);
		int b=System.Convert.ToInt32(args[1]);
		int c=System.Convert.ToInt32(args[2]);
		
		double d=b*b-4*a*c;
		if(d==0)
		{
			System.Console.WriteLine("both roots are equal");
			double x1 = - b / (2 * a); 
			double x2=x1;
			System.Console.WriteLine("Root 1 is {0} ",x1);
			System.Console.WriteLine("Root 2 is {0}",x2);
 

		}
		else if(d>0)
		{
			System.Console.WriteLine("both roots are different");
			double x1=(-b + System.Math.Sqrt(d) / (2*a));
			double x2=(-b - System.Math.Sqrt(d) / (2*a));
			System.Console.WriteLine("Root 1 is {0} " ,x1);
			System.Console.WriteLine("Root 2 is {0}",x2);
			
		}	
		else
		{
			System.Console.WriteLine("both roots are imaginary");
		}
	}
}