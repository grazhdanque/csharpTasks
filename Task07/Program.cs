// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
System.Console.WriteLine("Enter the number");
int num = Convert.ToInt32(Console.ReadLine());
if (num>999 || num <100)
{
    System.Console.WriteLine("Invalid number");
}
else
{
    System.Console.WriteLine($"{num} -> {num % 10}");
}