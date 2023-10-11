global using Bookstore.Models;
global using Microsoft.EntityFrameworkCore;
global using Bookstore.Data;
global using Bookstore.Services.AutorService;
global using Bookstore.Services.EditoraService;
global using Bookstore.Services.GeneroService;
global using Bookstore.Services.LivroService;
global using Bookstore.Services.VendaService;
global using Bookstore.Services.ClienteService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Build para a ligação das Interfaces com os Services
builder.Services.AddScoped<IAutorService, AutorService>();
builder.Services.AddScoped<IEditoraService, EditoraService>();
builder.Services.AddScoped<IGeneroService, GeneroService>();
builder.Services.AddScoped<ILivroService, LivroService>();
builder.Services.AddScoped<IVendaService, VendaService>();
builder.Services.AddScoped<IClienteService, ClienteService>();

// Build para a conexão com o DB
builder.Services.AddDbContext<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
