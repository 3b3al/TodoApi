using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TodoContext>(opt=>
opt.UseInMemoryDatabase("TodoList"));


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
  //  app.UseSwaggerUI();
   
    app.UseStaticFiles();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
