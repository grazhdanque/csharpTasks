/* 
    int[] arrayNums = new int[8];
    for (int i=0; i<arrayNums.Length;i++)
    {
        arrayNums[i] = new Random().Next (0,2);
        System.Console.Write($"{arrayNums[i]} ");
    }
 */
System.Console.WriteLine("Input array length:");
int arrayL = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayL];
void Filler(int[] array1, int length)
{
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array1[i] = rnd.Next(0, 2);
    }
    return;
}
void Monitor(int[] array2,int lastDigit)
{
    System.Console.Write("[");
    int i = 1;
    while (i<lastDigit)
    {
        System.Console.Write($"{array2[i]},");
        i++;
    }
    System.Console.WriteLine($"{array2[lastDigit-1]}]");
    return;
}

Filler(array,arrayL);
Monitor(array,arrayL);