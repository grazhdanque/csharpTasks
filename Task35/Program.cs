int[] arrayM = new int[123];
Console.WriteLine("Enter the minimum value in the array:");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the maximum value in the array:");
int maximum = Convert.ToInt32(Console.ReadLine());
int[] Filler(int[] arr,int min, int max)
{
    Random rnd = new Random();
    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = rnd.Next(min,max+1);
    }
    return arr;
}
void Monitor(int[] arr, string ben = ", ")
{
    Console.Write("[");
    for (int i=0;i<arr.Length;i++)
    {
        if (i<arr.Length-1)
        {
            Console.Write($"{arr[i]}{ben}");
        }
        else Console.Write($"{arr[i]}]");
    }
    return;
}
int Counter(int[] arr)
{
    int result = 0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]>=10)
        {
            if (arr[i]<=99)
            {
                result++;
            }
        }
    }
    return result;
}
Filler(arrayM,minimum,maximum);
Monitor(arrayM);
int number = Counter(arrayM);;
Console.WriteLine($" -> {number}");
