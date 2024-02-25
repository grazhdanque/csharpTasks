int num = new Random().Next(10,99);
System.Console.Write($"{num} -> ");
int nume = num % 10;
num = num / 10;
if (num > nume) 
{
    System.Console.WriteLine(num);
}
else
{
    System.Console.WriteLine(nume);
}
// int maxDigit = num > nume ? num : nume;
