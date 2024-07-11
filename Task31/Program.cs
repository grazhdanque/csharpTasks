int[] array = new int[12];    
void Filler(int[] array1)
{
    Random rnd = new Random();
    for (int i = 0; i < 12; i++)
    {
        array1[i] = rnd.Next(-9, 10);
    }
    return;
}
void Monitor(int[] array2)
{
    System.Console.Write("[");
    for (int i = 0; i < 11; i++)
    {
        System.Console.Write($"{array2[i]}, ");
    }
    System.Console.WriteLine($"{array2[11]}]");
    return;
}
int Counter(int[] array3)
{
    int pos = 0;
    int neg = 0;
    for (int i = 0; i <12; i++)
    {
        if (array3[i]>=0) 
        {
            pos = pos+array3[i];
        }
        else 
        {
            neg = neg+array3[i];
        }
    }
    System.Console.WriteLine($"Sum of positive numbers: {pos}");
    System.Console.WriteLine($"Sum of negative numbers: {neg}");
    return 0;
}

Filler(array);
Monitor(array);
Counter(array);