using System;

// Circle class definition
public class Circle
{
    // Constant variable inside class
    public const double PI = 3.14;
    
    // Method to calculate area
    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }
    
    // Method to calculate perimeter
    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("TASK 2: Constants");
        
        // Create Circle object
        Circle circle = new Circle();
        
        // ==========================================
        // COMPILATION ERROR DEMONSTRATION (REQUIRED)
        // ==========================================
        // Uncomment the line below to see the compilation error:
        // Circle.PI = 3.14159; // ERROR: The left-hand side of an assignment must be a variable, property or indexer
        
        // ==========================================
        // WORKING CALCULATIONS
        // ==========================================
        double radius = 5.0;
        
        // Use class methods
        double area = circle.CalculateArea(radius);
        double perimeter = circle.CalculatePerimeter(radius);
        
        Console.WriteLine($"Circle with radius {radius}:");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");
        
        // ==========================================
        // EXPLANATION (as required by task)
        // ==========================================
        Console.WriteLine("\nError Explanation:");
        Console.WriteLine("Constants declared with 'const' keyword cannot be modified.");
        Console.WriteLine("They are compile-time constants with fixed values.");
    }
}