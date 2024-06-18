int NumberSummary(int num)
{
    int caseN = 0;
    while (num > 0)
    {
        caseN = caseN + (num % 10);
        num = num / 10;
    }
    return caseN;
}
System.Console.WriteLine("Input your number:");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Sum is {NumberSummary(number)}");