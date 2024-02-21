// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2

System.Console.WriteLine("Enter the number");
int num = Convert.ToInt32(Console.ReadLine());
int subnum = (-1 *num);
while (subnum != num +1)
{
    System.Console.WriteLine(subnum);
    subnum++;
}