// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for parsing dates from strings

string userEntry = "";
DateTime now = DateTime.Today;

while (!userEntry.Contains("exit"))
{
    Console.WriteLine("Which date? (Or 'exit')");
    userEntry = Console.ReadLine();

    if (userEntry.ToLower() == "exit")
    {
        break;
    }

    DateTime result;
    // Use the static class function TryParse to try parsing the dates
    if (DateTime.TryParse(userEntry, out result))
    {
        TimeSpan interval = now - result;
        int dayDifference = interval.Days;
        if (dayDifference > 0)
        {
            Console.WriteLine($"That date went by {dayDifference} since then!");
        }
        else if (dayDifference < 0)
        {
            Console.WriteLine($"That date is {0 - dayDifference} in the future!)");
        }
        else if (dayDifference == 0)
        {
            Console.WriteLine("That is today's date.");
        }
    }
    else
    {
        Console.WriteLine($"Could not parse '{userEntry}'");
    }
}
