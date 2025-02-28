using GarbleSortConsoleApp;
using System;

Console.WriteLine("Hello! This is a Garble Sort Console App on .NET 8.");

// Started at 1:37PM PHT

foreach (var num in SortHelper.GarbleSort([1, 2, 3]))
{
    Console.Write($"{num} ");
}
Console.WriteLine(string.Empty);

foreach (var num in SortHelper.GarbleSort([5, 6, 3]))
{
    Console.Write($"{num} ");
}
Console.WriteLine(string.Empty);
foreach (var num in SortHelper.GarbleSort([5, 6, 3]))
{
    Console.Write($"{num} ");
}
Console.WriteLine(string.Empty);

foreach (var num in SortHelper.GarbleSort(null))
{
    Console.Write($"{num} ");
}

// Finished at 1:50PM PHT