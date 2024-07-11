Console.WriteLine("Input the length of array:");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the minimal number value:");
int minimal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximal number value:");
int maximal = Convert.ToInt32(Console.ReadLine());
int[] Filler(int length1, int min, int max)
{
    int[] array1 = new int[length1];
    Random rnd = new Random();
    for (int i = 0; i < length1; i++)
    {
        array1[i] = rnd.Next(min, max + 1);
    }
    return array1;
}
void Monitor(int[] arr, string ben = ", ")
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}{ben}");
        }
        else Console.Write($"{arr[i]}]");
    }
    return;
}
int[] Reverse(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}
int[] array = Filler(length, minimal, maximal);
Monitor(array);
Console.WriteLine();
Reverse(array);
Monitor(array);