// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

System.Console.WriteLine("Input two numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2) 
{
    System.Console.WriteLine("The numbers are equal");
}
 else if (num1 > num2) 
{
    System.Console.WriteLine($"{num1} is bigger than {num2}");  
}
else
{
    System.Console.WriteLine($"{num2} is bigger than {num1}");
}
