// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

System.Console.WriteLine("Enter the number of the day of the week ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1 ) 
{
System.Console.WriteLine($"{1} -> Monday");
}
else if (num == 2 ) 
{
System.Console.WriteLine($"{2} -> Tuesday");
}
else if (num ==3 ) 
{
System.Console.WriteLine($"{3} -> Wednesday");
}
else if (num == 4 ) 
{
System.Console.WriteLine($"{4} -> Thursday");
}
else if (num == 5 ) 
{
System.Console.WriteLine($"{5} -> Friday");
}
else if (num == 6 ) 
{
System.Console.WriteLine($"{6} -> Saturday");
}
else if (num == 7 ) 
{
System.Console.WriteLine($"{7} -> Sunday");
}