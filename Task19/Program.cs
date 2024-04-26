bool Palindrom(int num)
{
    bool result = false;
    int case1 = num;
    double mun = 0;
    int length = -1;
     while (num > 0)
    {
        num = num / 10;
        length++;
    }
    num =case1;
    while (case1 >0)
    {
        mun = mun +((case1 % 10) * (Math.Pow(10, length)));
        case1 = case1 / 10;
        length--;
    }
    result = true
    ? num == mun
    : false;
    return result;
}
System.Console.WriteLine("enter the number:");
int number = Convert.ToInt32(Console.ReadLine());
bool answer = Palindrom(number);
if (number < 10000 || number > 99999)
{
    System.Console.Write("This number is not five-digit but ");
    if (answer == true) System.Console.Write("it's a palindrom");
    else System.Console.Write("it's not a palindrom");
}
else if (answer == true) System.Console.Write("it's a palindrom");
else System.Console.Write("it's not a palindrom");