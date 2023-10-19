using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string str = "мой номер телефона 11-11-11 а городской 222-222, но звони по номеру 123-00-12";
        string pattern = @"(\d{2}-\d{2}-\d{2}|\d{3}-\d{3}|\d{3}-\d{2}-\d{2})";
        MatchCollection matches = Regex.Matches(str, pattern);
        Console.WriteLine("Найдено {0} номеров телефонов:", matches.Count);
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}