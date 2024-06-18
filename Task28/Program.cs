int Multiply(int num)
{
    int count = num;
    num = 1;
    while (count > 0)
    {
        checked
        {
            num = num * count;
        }

        count--;
    }
    return num;

}
System.Console.WriteLine("Input your number:");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    System.Console.WriteLine("Incorrect input");
    return;
}
number = Multiply(number);
System.Console.WriteLine($"Result is {number}");