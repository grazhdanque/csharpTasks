System.Console.WriteLine("Enter array length:");
int lengthM = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter mimimal number value:");
int minimal = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter maximal number value:");
int maximal = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the number you are looking for:");
int number = Convert.ToInt32(Console.ReadLine());
int[] Filler(int length,int min, int max)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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
void Finder(int[] arr, int num)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            count++;
        }
    }
    if (count != 0) Console.WriteLine(" -> yes");
    else Console.WriteLine(" -> no");
}
int[] array = Filler(lengthM,minimal,maximal);
Monitor(array);
Finder(array,number);