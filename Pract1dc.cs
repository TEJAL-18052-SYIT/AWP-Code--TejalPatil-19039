class Pract1dc
{
	public static void Main(string[] args)
	{
		char s = System.Convert.ToChar(args[0]);
		if( s=='a' || s=='e' || s=='i' || s=='o' || s=='u' || s=='A' || s=='E' || s=='I' || s=='O' || s=='U' )
		{
			System.Console.WriteLine("Vowels");

		}
		else
		{
			System.Console.WriteLine(" Not a Vowels");
		}
	}
}
