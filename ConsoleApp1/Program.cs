// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Calculator;

Console.WriteLine("Hello, World!");

var calculator = new CalculatorClient();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Adding 10 + 10...");
    var result = await calculator.AddAsync(10, 10);

    Console.WriteLine(result);

    Console.WriteLine("Subtracting 10 - 5...");
    result = await calculator.SubtractAsync(10, 5);
    Console.WriteLine(result);

    Console.WriteLine("Multiplying 10 * 10...");
    var result2 = await calculator.MultiplyAsync(10, 10);
    Console.WriteLine(result2);

    Console.WriteLine("Dividing 10 / 2...");
    var result3 = await calculator.DivideAsync(10, 2);
    Console.WriteLine(result3);
}
