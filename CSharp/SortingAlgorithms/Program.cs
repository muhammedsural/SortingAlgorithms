using SortingAlgorithms;





BubbleSortAlgorithm bubble          = new();
HeapSortAlgorithm heap              = new();
InsertionSortAlgorithm insertion    = new();
MergeSortAlgorithm merge            = new();
QuickSortAlgorithm quick            = new();
SelectionSortAlgorithm selection    = new();


int[] numbers = { 5, 2, 7, 91, 0, 6, 3, 4 };
string[] names = { "Ali", "Ayşe", "Fatma", "Veli" }; //Stringlerde alfabetik sıraya göre yapar.


bubble.BubbleSort2(numbers);
bubble.BubbleSort2(names);

Console.WriteLine(string.Join(",", numbers));
Console.WriteLine(string.Join(",", names));

Console.ReadLine();