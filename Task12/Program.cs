System.Console.WriteLine("Введите два числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1%num2==0)
{
    System.Console.WriteLine("Кратно");
}
else{System.Console.WriteLine($"Не кратно, остаток {num1%num2}");}