using advancedC_;
using System;

class Program
{
    static void PrintArray<T>(T[] array)
    {
        foreach (T item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    static void BubbleSortOptimized<T>(T[] array) where T : IComparable<T>
    {
        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {

                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }
    static void Main()
    {

        #region q1
        int[] intArray = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original integer array:");
        PrintArray(intArray);

        BubbleSortOptimized(intArray);

        Console.WriteLine("Sorted integer array:");
        PrintArray(intArray);

        string[] stringArray = { "banana", "apple", "cherry", "date" };
        Console.WriteLine("Original string array:");
        PrintArray(stringArray);

        BubbleSortOptimized(stringArray);

        Console.WriteLine("Sorted string array:");
        PrintArray(stringArray);
        #endregion

        #region q2
        var intRange = new Range<int>(1, 10);
        Console.WriteLine($"Range: {intRange.Min} to {intRange.Max}");
        Console.WriteLine($"Is 5 in range? {intRange.IsInRange(5)}");
        Console.WriteLine($"Length of range: {intRange.Length()}");

        var doubleRange = new Range<double>(1.5, 5.5);
        Console.WriteLine($"\nRange: {doubleRange.Min} to {doubleRange.Max}");
        Console.WriteLine($"Is 3.5 in range? {doubleRange.IsInRange(3.5)}");
        Console.WriteLine($"Length of range: {doubleRange.Length()}"); 
        #endregion
    }

  
}
