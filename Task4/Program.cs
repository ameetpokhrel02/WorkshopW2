// Task 4: Arrays and Array Methods
Console.WriteLine("=== TASK 4: Arrays ===");

// Create array with Amit's favorite numbers (including his lucky number 0)
int[] favoriteNumbers = { 7, 0, 9, 1, 5 }; // 0 is Amit's lucky number

Console.WriteLine("Original array:");
PrintArray(favoriteNumbers);

// Sort the array
Array.Sort(favoriteNumbers);
Console.WriteLine("Sorted array:");
PrintArray(favoriteNumbers);

// Reverse the sorted array
Array.Reverse(favoriteNumbers);
Console.WriteLine("Reversed array:");
PrintArray(favoriteNumbers);

// Find index of Amit's lucky number (0)
int numberToFind = 0;
int index = Array.IndexOf(favoriteNumbers, numberToFind);
Console.WriteLine($"Index of Amit's lucky number ({numberToFind}): {index}");

// Helper method to print array
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Element [{i}]: {array[i]}");
    }
}
