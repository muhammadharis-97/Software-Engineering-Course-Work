using Operator;

// See https://aka.ms/new-console-template for more information

Class1 a = new Class1();
Class1 b = new Class1();

int q = a.sum2num(4,5);
int p = b.diff2num(q,5);

Console.WriteLine("sum of two number");
Console.WriteLine(q);
Console.WriteLine("diff of two number ");
Console.WriteLine(p);

Console.WriteLine("Enter your surname ");
string name = Console.ReadLine();


Console.WriteLine($"the entered name is :{name}");

Console.WriteLine("Enter your matriculation No ");
string matriculationNo = Console.ReadLine();


Console.WriteLine($"the entered matriculation is :{matriculationNo}");

Console.WriteLine("Enter your Batch No ");
string batch = Console.ReadLine();


Console.WriteLine($"the entered batch is :{batch}");

