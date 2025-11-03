// Task 6: Collections
Console.WriteLine("=== TASK 6: Collections ===");

List<string> fruits = new List<string> { "Apple", "Mango", "Orange" };

Console.WriteLine($"Original fruits: {string.Join(", ", fruits)}");

fruits.Add("Banana");
Console.WriteLine($"After adding Banana: {string.Join(", ", fruits)}");

fruits.Remove("Orange");
Console.WriteLine($"After removing Orange: {string.Join(", ", fruits)}");

Dictionary<int, string> fruitDict = new Dictionary<int, string>
{
    { 1, "Apple" },
    { 2, "Mango" },
    { 3, "Banana" }
};

fruitDict.Add(0, "Special Fruit");

Console.WriteLine($"Fruit at key 1: {fruitDict[1]}");
Console.WriteLine($"Fruit at key 2: {fruitDict[2]}");
Console.WriteLine($"Fruit at key 3: {fruitDict[3]}");
Console.WriteLine($"Special fruit at key 0: {fruitDict[0]}");