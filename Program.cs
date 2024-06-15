// See https://aka.ms/new-console-template for more information
using implementandoQuickSort;

int[] arr={1,2,3,4,15,6,7,8,9,10,11,12,13,14,5};
QuickSort.SortArray(arr);
System.Console.WriteLine("((---------------))");
foreach(var i in arr){
    System.Console.Write(i+",");
}
