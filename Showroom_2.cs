class Showroom_2
{
	public static void Main(string[] args)
	{
		int purchased_amt = System.Convert.ToInt32(args[0]);
		System.Console.WriteLine("1.purchased item btw 0 - 100\n2.purchased item btw 101 - 200\n3.purchased item btw 201 - 300\n4.purchased item above 300  \nSelect a Number : ");
		double final_amt;
		string switch_s = System.Console.ReadLine();
		int switch_i = System.Convert.ToInt32(switch_s);
		switch(switch_i)
		{
			case 1:
					final_amt = (purchased_amt * 100)/5;
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
			case 2: 
	
					final_amt = (purchased_amt * 200)/(5*7.5);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;
			case 3:

					final_amt = (purchased_amt * 200)/(7.5*10);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;


			case 4:
					final_amt = (purchased_amt * 200)/(10*15);
					System.Console.WriteLine("Final Amt = "+final_amt);
					break;

			default: System.Console.WriteLine("INVALID NUMBER");
				break;
		}
	}
}