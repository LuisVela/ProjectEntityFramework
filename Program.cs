using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectEF;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<JobContext>(p => p.UseInMemoryDatabase("TasksDB"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", () => async ([FromServices] JobContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok($"Base de datos en memoria: {dbContext.Database.IsInMemory()}");
});

app.Run();
