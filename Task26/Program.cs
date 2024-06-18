int NumberCount(int Num)
{
    int Mun =Num;
    int count = 0;
    while (Num != 0)
    {
        Num = Num / 10;
        count++;
    }
    return Mun == 0 ? 1 : count;
}
System.Console.WriteLine("Input your number:");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Your number has {NumberCount(number)} digit(s)");
