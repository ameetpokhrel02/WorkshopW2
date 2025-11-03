// Task 6: Generic Collections (List and Dictionary)
Console.WriteLine("=== TASK 6: Collections ===");

// List operations - Amit's favorite fruits
List<string> favoriteFruits = new List<string> { "Apple", "Mango", "Orange" };

Console.WriteLine("Amit's original fruits list:");
PrintList(favoriteFruits);

// Add new fruit
favoriteFruits.Add("Banana");
Console.WriteLine("After adding Banana:");
PrintList(favoriteFruits);

// Remove one fruit
favoriteFruits.Remove("Orange");
Console.WriteLine("After removing Orange:");
PrintList(favoriteFruits);

// Dictionary operations - Amit's fruit collection
Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
{
    { 1, "Apple" },
    { 2, "Mango" },
    { 3, "Banana" }
};

// Add new entry with Amit's lucky number 0
fruitDictionary.Add(0, "Special Fruit"); // Using Amit's lucky number as key

Console.WriteLine("Amit's Fruit Dictionary:");
foreach (var kvp in fruitDictionary)
{
    Console.WriteLine($"ID: {kvp.Key}, Fruit: {kvp.Value}");
}

// Special message for lucky number
if (fruitDictionary.ContainsKey(0))
{
    Console.WriteLine($"Special item with Amit's lucky number (0): {fruitDictionary[0]}");
}

// Helper method to print list
void PrintList(List<string> list)
{
    foreach (string fruit in list)
    {
        Console.WriteLine($"- {fruit}");
    }
}
