using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Aspire_Demo_CoreWCFService>("CalculatorService");   

builder.Build().Run();