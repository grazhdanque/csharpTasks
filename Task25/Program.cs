int Exponentiation(int numA, int numB)
{
    int caseN = 1;
    for (int i = 0; i <numB; i++)
    {
        caseN = caseN * numA;
    }
    return caseN;
}
System.Console.WriteLine("Input number A:");
int NumberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number B:");
int NumberB = Convert.ToInt32(Console.ReadLine());
if (NumberB < 0)
{
System.Console.WriteLine("Invalid degree value! ");
}
else 
{
    System.Console.WriteLine($"Number is {Exponentiation(NumberA,NumberB)}");
}