System.Console.WriteLine("input the quarter number");
int numIn = Convert.ToInt32(Console.ReadLine());

string Range(int num)
{
    if (num == 1) return "x>0;y>0";
    if (num == 2) return "x<0;y>0";
    if (num == 3) return "x<0;y<0";
    if (num == 4) return "x>0;y<0";
    return "invalid number";
}
string range = Range(numIn);
System.Console.WriteLine(range);