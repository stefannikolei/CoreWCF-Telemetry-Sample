// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Calculator;

Console.WriteLine("Hello, World!");

var calculator = new CalculatorClient();

Console.WriteLine("Adding 10 + 10...");
var result = await calculator.AddAsync(10, 10);

Console.WriteLine(result);

Console.ReadKey();