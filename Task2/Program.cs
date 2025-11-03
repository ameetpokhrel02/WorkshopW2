// Task 2: Constants
Console.WriteLine("=== TASK 2: Constants ===");

// Using the Circle class
Circle circle = new Circle();
double radius = 5.0;

// Calculate area and perimeter
double area = circle.CalculateArea(radius);
double perimeter = circle.CalculatePerimeter(radius);

Console.WriteLine($"Circle with radius {radius}:");
Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimeter: {perimeter}");

// This will cause compilation error if uncommented:
// Circle.PI = 3.14159; // Error: A const field cannot be assigned to

public class Circle
{
    public const double PI = 3.14;
    
    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }
    
    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}
