// // Задача 4: Напишите программу, которая принимает на
// // вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22
System.Console.WriteLine("Enter three numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1+num2+num3 < num1*3)
{
    System.Console.WriteLine($"Number {num1} is the biggest number");
}
else if (num1+num2+num3 < num2*3)
{
    System.Console.WriteLine($"Number {num2} is the biggest number");
}
else if (num1+num2+num3 < num3*3)
{
    System.Console.WriteLine($"Number {num3} is the biggest number");
}