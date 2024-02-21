// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// System.Console.WriteLine($"{num} -> ");

System.Console.WriteLine("Enter the number");
int num = Convert.ToInt32(Console.ReadLine());
if (num<0)
{
    System.Console.WriteLine("Invalid number");
}
else if (num % 2 == 0)
{
    System.Console.Write($"{num} -> {num}");
    while (num > 1)
    {
        System.Console.Write($", {num -2}");
        num = num-2;
    }
}
else 
{
    System.Console.Write($"{num} -> {num-1}");
    num = num-3;
    while (num > 1)
    {
        System.Console.Write($", {num}");
        num = num-2;
    }
}