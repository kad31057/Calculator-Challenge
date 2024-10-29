using System;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();

        Console.WriteLine("Enter numbers to add, or type 'exit' to quit.");
        Console.WriteLine("Format examples:");
        Console.WriteLine("- Basic: '1,2'");
        Console.WriteLine("- Custom delimiter: '//[***]\\n11***22***33'");
        Console.WriteLine("- Multiple delimiters: '//[*][!!][r9r]\\n11r9r22*hh*33!!44'\n");

        while (true)
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();

            if (input?.ToLower() == "exit")
                break;

            try
            {
                int result = calculator.Add(input);
                Console.WriteLine($"Result: {result}\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}\n");
            }
        }
    }
}
