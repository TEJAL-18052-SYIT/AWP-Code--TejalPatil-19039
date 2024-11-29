class Pract1db
{
	public static void Main(string[] args)
	{
		int num=System.Convert.ToInt32(args[0]);
		int p=0;
		for(int i=1;i<=num;i++)
		{
			if(num%i==0)
			{	
				p++;
			}


			
		}
		if(p==2)
		{	
			System.Console.WriteLine("prime");
		}
		else
		{
			System.Console.WriteLine("Not   prime");
		}
	} 
}