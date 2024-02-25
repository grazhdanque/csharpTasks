int num = new Random().Next(100,1000);
System.Console.Write($"{num} -> ");
num = (num / 100)*10 + (num % 10);
System.Console.WriteLine(num);
