double Distance(int x1,int y1, int z1, int x2, int y2,int z2)
{   
    //d = √((x2 — x1)^2 + (y2 — y1)^2 + (z2 — z1)^2)
    double dis = Math.Sqrt((Math.Pow((x2-x1),2))+(Math.Pow((y2-y1),2))+(Math.Pow((z2-z1),2)));
    return dis;
}
System.Console.WriteLine("input x of the 1st point:");
int x11 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input y of the 1st point:");
int y11 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input z of the 1st point:");
int z11 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input x of the 2nd point:");
int x21 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input y of the 2nd point:");
int y21 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("input z of the 2nd point:");
int z21 = Convert.ToInt32(Console.ReadLine());
double range = Distance(x11,y11,z11,x21,y21,z21);
double rangeR = Math.Round(range, 2, MidpointRounding.ToZero);
System.Console.WriteLine($"The distance between two points is {rangeR}");