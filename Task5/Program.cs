// Task 5: DateTime and TimeSpan
Console.WriteLine("=== TASK 5: DateTime ===");

// Create Amit's birthdate and current date
DateTime birthDate = new DateTime(2004, 4, 11); // Amit's birthdate: 2004-04-11
DateTime currentDate = DateTime.Now;

// Calculate age using TimeSpan
TimeSpan ageTimeSpan = currentDate - birthDate;
int ageInYears = (int)(ageTimeSpan.TotalDays / 365.25);

// Add 10 days to birthdate
DateTime birthDatePlus10 = birthDate.AddDays(10);

// Print results
Console.WriteLine($"Amit's Birthdate: {birthDate:yyyy-MM-dd}");
Console.WriteLine($"Current date: {currentDate:yyyy-MM-dd}");
Console.WriteLine($"Amit's Age: {ageInYears} years");
Console.WriteLine($"Birthdate + 10 days: {birthDatePlus10:yyyy-MM-dd}");

// Additional: Calculate exact age
int years = currentDate.Year - birthDate.Year;
int months = currentDate.Month - birthDate.Month;
int days = currentDate.Day - birthDate.Day;

if (days < 0)
{
    months--;
    days += DateTime.DaysInMonth(currentDate.Year, currentDate.Month);
}

if (months < 0)
{
    years--;
    months += 12;
}

Console.WriteLine($"Exact Age: {years} years, {months} months, {days} days");
