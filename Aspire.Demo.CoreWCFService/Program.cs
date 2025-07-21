var builder = WebApplication.CreateBuilder();

builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();
builder.Services.AddSingleton<IServiceBehavior, UseRequestHeadersForMetadataAddressBehavior>();

builder.AddServiceDefaults();

var app = builder.Build();
app.MapDefaultEndpoints();
app.UseServiceModel(serviceBuilder =>
{
    serviceBuilder.AddService<ICalculator.Calculator>();
    serviceBuilder.AddServiceEndpoint<ICalculator.Calculator, ICalculator>(
        new BasicHttpBinding(BasicHttpSecurityMode.Transport),
        "/CalculatorService.svc");
    var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
    serviceMetadataBehavior.HttpsGetEnabled = true;
});

app.Run();