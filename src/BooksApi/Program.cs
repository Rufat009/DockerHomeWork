using BooksApi.Repositories;
using BooksApi.Repositories.Base;
using BooksApi.Services;
using BooksApi.Services.Base;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

builder.Services.AddScoped<IBookRepository>(options =>
{
    var mongoConnectionString = builder.Configuration.GetConnectionString("MongoBooksDb");

    return new MongoBooksRepository(mongoConnectionString!);
});

builder.Services.AddScoped<IBookService, BookService>();

app.UseSwagger();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
