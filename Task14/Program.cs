System.Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
// if (num%7==0)
// {
//     if (num%23==0)
//     {
//         System.Console.WriteLine($"{num} -> да");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num} -> нет");
//     }
// }
// else System.Console.WriteLine($"{num} -> нет");
if (num%7==0 && num%23==0) System.Console.WriteLine(($"{num} -> да"));
else System.Console.WriteLine(($"{num} -> нет"));