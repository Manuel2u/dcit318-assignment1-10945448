Console.WriteLine("Please enter the length of the first side of the triangle:");
string? side1Input = Console.ReadLine();

Console.WriteLine("Please enter the length of the second side of the triangle:");
string? side2Input = Console.ReadLine();

Console.WriteLine("Please enter the length of the third side of the triangle:");
string? side3Input = Console.ReadLine();

if (side1Input == null || side2Input == null || side3Input == null)
{
    Console.WriteLine("Input cannot be null.");
}

if (double.TryParse(side1Input, out double side1) && double.TryParse(side2Input, out double side2) && double.TryParse(side3Input, out double side3))
{
    if (side1 <= 0 || side2 <= 0 || side3 <= 0)
    {
        Console.WriteLine("The lengths of the sides must be positive numbers.");
    }
    else
    {
        string triangleType = DetermineTriangleType(side1, side2, side3);
        Console.WriteLine($"The triangle is: {triangleType}");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter numeric values for the sides.");
}

static string DetermineTriangleType(double side1, double side2, double side3)
{
    if (side1 == side2 && side2 == side3)
    {
        return "Equilateral";
    }
    else if (side1 == side2 || side2 == side3 || side1 == side3)
    {
        return "Isosceles";
    }
    else
    {
        return "Scalene";
    }
}