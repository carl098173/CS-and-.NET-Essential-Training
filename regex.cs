// Takes a date in the form mm/dd/yyyy and returns the date
// formatted as yyyy-mm-dd. Month and day can be 1 or 2 digits,
// and the year can be 2 or 4 digits

using System.Text.RegularExpressions;

static string ReverseDate(string userDate)
{
    const int TIMEOUT = 1000;
    try
    {
        return Regex.Replace(userDate, @"^(?<mon>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})$", "${year}-${mon}-${day}", RegexOptions.None, TimeSpan.FromMilliseconds(TIMEOUT));
    }
    catch (RegexMatchTimeoutException)
    {
        return userDate;
    }
}

while (true)
{
    Console.WriteLine("Date to convert? (Use mm/dd/yyyy, or 'exit' to quit)");
    string input = Console.ReadLine();
    if (input == "exit") break;
    DateOnly userDate;
    if (DateOnly.TryParse(input, out userDate))
    {
        string reverseDate = ReverseDate(input);
        Console.WriteLine($"The reversed format is {reverseDate}");
    }
    else
    {
        Console.WriteLine($"{input} is not a valid date");
    }

}

