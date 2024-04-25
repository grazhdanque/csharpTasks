void Square(int number)
{
int count = 1;
while (count != number+1) 
{
    System.Console.WriteLine($"{count}, {Math.Pow(count,2)}");
    count++;
}
}
System.Console.WriteLine("enter the number:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0 || num == 0) 
{
    System.Console.WriteLine("invalid value");
}
else
{
    Square(num);
}
