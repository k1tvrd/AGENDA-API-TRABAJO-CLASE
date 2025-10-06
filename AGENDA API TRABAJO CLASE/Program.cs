using AgendaApi.Repositories.Implementations;
using AgendaApi.Repositories.Interfaces;
using AgendaApi.Services.Implementations;
using AgendaApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IContactService, ContactService>(); //por inyección de dependencias
builder.Services.AddScoped<IUserService, UserService>(); //por inyección de dependencias
builder.Services.AddScoped<IContactRepository, ContactRepository>(); //por inyección de dependencias
builder.Services.AddScoped<IUserRepository, UserRepository>(); //por inyección de dependencias



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
