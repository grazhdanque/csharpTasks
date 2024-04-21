System.Console.WriteLine("input a number:");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 999) {
    while (num >999) 
    {
        num = num /10;
    } 
}
if (num>99) System.Console.WriteLine(num%10);
else System.Console.WriteLine("there is no third digit");