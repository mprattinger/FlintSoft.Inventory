using FlintSoft.Inventory.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddPresentation();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.Run();