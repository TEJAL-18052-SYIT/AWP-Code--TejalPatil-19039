using System;
class WhileTest 
{
    public static void Main() 
	{
        int n = 1;
        while (n <= 10) {
            if (n%2 == 0) {
                n++;
            }
            else {
                Console.Write(" " + n);
                n++;
            }
        }
    }
}
