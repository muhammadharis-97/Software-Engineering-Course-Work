using class_interface;
using System;
using System.Collections.Generic;
using System.Transactions;
using System;
using System.IO;
using System.Runtime.InteropServices;


string filepath = @"C:\Users\Lenovo\Documents\GitHub\se-cloud-2023-2024\MyWork\Ex8\class_interface_oop\class_interface\Result.txt";


var list = new List<double>();
string read;
double read_int;


Class1 train = new Class1();
Class2 values = new Class2();
values.load(filepath);

Console.WriteLine("Add 6 number to the list you want Sum for");
for (int i = 0; i < 6; i++)
{
    read = Console.ReadLine();
    read_int = double.Parse(read);
    list.Add(read_int);
} 



double resut = train.train(list);
Console.WriteLine("the result of list sum according to condition is " + resut);


values.train(list);
Result result1 = values.GetResult();
Console.WriteLine($"Average: {result1.average}  and Median is: {result1.Median} and Variance is: {result1.Variance}");
//Console.WriteLine("the variance of " + variance);
//Console.WriteLine("the stddev of " + stddev);

values.save(filepath);





// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
