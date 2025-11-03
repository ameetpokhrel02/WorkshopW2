// Task 3: Data Types
Console.WriteLine("=== TASK 3: Data Types ===");

byte byteValue = 255;
short shortValue = 32000;
int intValue = 100;
long longValue = 1000000;
float floatValue = 3.14f;
double doubleValue = 3.14159;
decimal decimalValue = 3.14m;
char charValue = 'A';
bool boolValue = true;

string intToString = 42.ToString();
double stringToDouble = double.Parse("3.14");

Console.WriteLine($"byte: {byteValue}");
Console.WriteLine($"short: {shortValue}");
Console.WriteLine($"int: {intValue}");
Console.WriteLine($"long: {longValue}");
Console.WriteLine($"float: {floatValue}");
Console.WriteLine($"double: {doubleValue}");
Console.WriteLine($"decimal: {decimalValue}");
Console.WriteLine($"char: {charValue}");
Console.WriteLine($"bool: {boolValue}");
Console.WriteLine($"int to string: {intToString}");
Console.WriteLine($"string to double: {stringToDouble}");