System.Console.WriteLine("input a number:");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = (number/10)%10;
System.Console.WriteLine(secondDigit);
