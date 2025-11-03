// Task 3: Data Types and Type Conversion
Console.WriteLine("=== TASK 3: Data Types ===");

// Declare and initialize variables of different types
byte byteValue = 255;
short shortValue = 32000;
int intValue = 2147483647;
long longValue = 9223372036854775807;
float floatValue = 3.14f;
double doubleValue = 3.14159265359;
decimal decimalValue = 3.141592653589793238m;
char charValue = 'A';
bool boolValue = true;

// Type conversions
string intToString = 42.ToString(); // Convert integer to string
double stringToDouble = double.Parse("3.14"); // Convert string to double

// Print all variables with labels
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
