System.Console.WriteLine("enter the day of the week number(1-7)");
int numDay = Convert.ToInt32(Console.ReadLine());
if (numDay < 1 || numDay >7) System.Console.WriteLine("invalid number");
else if (numDay<6) System.Console.WriteLine("no");
else System.Console.WriteLine("yes");