using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Calculator
{
    public int Add(string input)
    {
        // Return 0 if the input is null, empty, or whitespace.
        if (string.IsNullOrWhiteSpace(input))
            return 0;

        // Define default delimiters
        var delimiters = new List<string> { ",", "\n" };

        // Handle custom delimiter syntax if the input starts with "//"
        if (input.StartsWith("//"))
        {
            var match = Regex.Match(input, @"^//(.+)\n");
            var delimiterPart = match.Groups[1].Value;
            input = input.Substring(match.Length);

            // Handle multiple or multi-character delimiters specified in square brackets
            if (delimiterPart.StartsWith("[") && delimiterPart.EndsWith("]"))
            {
                delimiters.AddRange(Regex.Matches(delimiterPart, @"\[(.*?)\]")
                                          .Cast<Match>()
                                          .Select(m => m.Groups[1].Value));
            }
            else
            {
                // Single custom delimiter
                delimiters.Add(delimiterPart);
            }
        }

        // Split the input based on the identified delimiters
        var numbers = input.Split(delimiters.ToArray(), StringSplitOptions.None)
                           .Select(n => ParseNumber(n))
                           .ToList();

        // Requirement 4: Check for negatives and throw exception if any are found
        var negatives = numbers.Where(n => n < 0).ToList();
        if (negatives.Any())
        {
            throw new ArgumentException($"Negatives not allowed: {string.Join(", ", negatives)}");
        }

        // Requirement 5: Ignore numbers greater than 1000
        return numbers.Where(n => n <= 1000).Sum();
    }

    private int ParseNumber(string number)
    {
        // Convert invalid numbers to 0
        return int.TryParse(number, out var result) ? result : 0;
    }
}
