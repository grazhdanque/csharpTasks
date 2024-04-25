System.Console.WriteLine("input x & y:");
int numX = Convert.ToInt32(Console.ReadLine());
int numY = Convert.ToInt32(Console.ReadLine());
/* if (numX == 0 || numX == 0) System.Console.WriteLine("Value is invalid");
if (numX > 0 && numY > 0) System.Console.WriteLine("the 1st quarter");
if (numX < 0 && numY > 0) System.Console.WriteLine("the 2nd quarter");
if (numX < 0 && numY < 0) System.Console.WriteLine("the 3rd quarter");
if (numX > 0 && numY < 0) System.Console.WriteLine("the 4th quarter"); */

int quarter = Quarter(numX, numY);
string result = quarter>0
?$"the {quarter} quarter"
: "invalid value";
System.Console.WriteLine(result);
int Quarter(int numA, int numB)
{
    if (numA > 0 && numB > 0) return 1;
    if (numA < 0 && numB > 0) return 2;
    if (numA < 0 && numB < 0) return 3;
    if (numA > 0 && numB < 0) return 4;
    return 0;
}