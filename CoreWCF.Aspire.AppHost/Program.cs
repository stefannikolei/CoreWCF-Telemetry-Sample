using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var coreWcf = builder.AddProject<Aspire_Demo_CoreWCFService>("CalculatorService");

builder.AddProject<ConsoleApp1>("CalculatorClient").WaitFor(coreWcf);

builder.Build().Run();