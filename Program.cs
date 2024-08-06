// See https://aka.ms/new-console-template for more information
using implementandoQuickSort;

int[] arr ={24,
 12,
 88,
 8,
 18,
 11,
 90,
 29,
 44,
 67,
 55,
 51,
 3,
 84,
 76,
 91,
 63,
 61,
 98,
 47,
 79,
 4,
 94,
 32,
 14,
 7,
 60,
 37,
 83,
 97};

System.Console.WriteLine("Array:");

foreach (var i in arr)
{   
    System.Console.Write(i + ",");
}
QuickSort.SortArray(arr);

System.Console.WriteLine("\nOrdenando...");
foreach (var i in arr)
{
    System.Console.Write(i + ",");
}
