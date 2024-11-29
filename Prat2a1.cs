class Prat2a1
{
	public static void Main(string[] args)
	{
		int num=System.Convert.ToInt32(args[0]);
		int fact=1;
		for(int i=num;i>=1;i--){
			if(i==1||i==0)
			{
				break;
			}
			else
			{
				fact*=i;	
			}
		}
		System.Console.WriteLine(fact);
	}
}