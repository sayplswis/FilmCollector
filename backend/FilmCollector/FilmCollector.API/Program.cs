using FilmCollector.Application.Services;
using FilmCollector.Core.Abstractions;
using FilmCollector.DataAccess;
using FilmCollector.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IFilmsService, FilmsService>();
builder.Services.AddScoped<IFilmsRepository, FilmsRepository>();

builder.Services.AddScoped<ICategoriesService, CategoriesService>();
builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();

builder.Services.AddDbContext<FilmsCollectionDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(FilmsCollectionDbContext)));
});




 var app = builder.Build();

if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
