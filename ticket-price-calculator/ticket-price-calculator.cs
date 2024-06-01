Console.WriteLine("Please enter your age:");

string? ageInput = Console.ReadLine();

if (ageInput == null)
{
    Console.WriteLine("Input cannot be null.");
}

if (int.TryParse(ageInput, out int age))
{
    if (age < 0)
    {
        Console.WriteLine("Age cannot be negative.");
    }
    else
    {
        int ticketPrice = CalculateTicketPrice(age);
        Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a numeric age.");
}
        


    static int CalculateTicketPrice(int age)
{
    if (age >= 65 || age <= 12)
    {
        return 7;
    }
    else
    {
        return 10;
    }
}