System.Console.WriteLine("Input array length:");
int arrayL = Convert.ToInt32(Console.ReadLine());
int[] arrayM = new int[arrayL];
void Filler(int[] array1, int length1)
{
    Random rnd = new Random();
    for (int i =0; i < length1; i++)
    {
        array1[i] = rnd.Next(1,101);
    }
    return;
}
void Monitor(int[] array2, int length2)
{
    System.Console.Write("[");
    int i=0;
    while (i<length2-1)
    {
        System.Console.Write($"{array2[i]},");
        i++;
    }
    System.Console.WriteLine($"{array2[length2-1]}]");
    return;
}
Filler(arrayM,arrayL);
Monitor(arrayM,arrayL);
