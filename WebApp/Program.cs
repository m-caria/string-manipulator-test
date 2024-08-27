using StringManipulator.Endpoints.StringManipulator;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllersWithViews()
    .AddRazorRuntimeCompilation();

builder.Services.AddSwaggerGen(setup =>
{
    setup.SwaggerDoc("phrase-checker-api-v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "v1",
        Title = "Phrase Checker API",
        Description = "API for check phrase words",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Email = "mail@manuelcaria.dev",
            Name = "Manuel Caria",
            Url = new Uri("https://www.manuelcaria.dev")
        }
    });
});

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(setup =>
    {
        setup.SwaggerEndpoint("/swagger/phrase-checker-api-v1/swagger.json", "Phrase Checker API - v1");
    });
}

app.UseRouting();
app.UseStaticFiles();

app.MapDefaultControllerRoute();

app.StringManipulatorEndpointsMap();

app.Run();