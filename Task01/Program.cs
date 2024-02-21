// Итерация №1
// Решение в группах задач:
// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

System.Console.Write("Input two numbers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 / num1 == num1) 
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}



