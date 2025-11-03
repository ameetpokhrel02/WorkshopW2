// Task 4: Arrays
Console.WriteLine("=== TASK 4: Arrays ===");

int[] numbers = { 7, 0, 9, 1, 5 };

Console.WriteLine($"Original array: [{string.Join(", ", numbers)}]");

Array.Sort(numbers);
Console.WriteLine($"Sorted array: [{string.Join(", ", numbers)}]");

Array.Reverse(numbers);
Console.WriteLine($"Reversed array: [{string.Join(", ", numbers)}]");

int index = Array.IndexOf(numbers, 0);
Console.WriteLine($"Index of 0: {index}");