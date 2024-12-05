using API.Models;
using API.Models.Requests;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.Services;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserServices, UserServices>();

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<AppDbContext>
    (option => option.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=DBAZUREPROJECT;User Id=postgres;Password=root;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.MapGet("/user", (IUserRepository userRepository) =>
//{
//    return userRepository.GetAll();
//})
//.WithName("GetAll")
//.WithOpenApi();

app.MapGet("/users", async (IUserServices userServices) =>
    Results.Ok(await userServices.GetAllUserAsync()));

app.MapGet("/users/{id}", async (long id, IUserServices userServices) =>
{
    var userGetId = await userServices.GetByIdUserAsync(id);
    return userGetId is not null ? Results.Ok(userGetId) : Results.NotFound();
});


app.MapPost("/users", async (UserRequest userRequest, IUserServices userServices) =>
{
    var user = Utils.CreateUser(userRequest);
    
    await userServices.AddUserAsync(user);
    return Results.Created($"/users/{user.Email}", user);
});


app.MapPut("/users/{id}", async (long id, User updatedUser, IUserServices userServices) =>
{
    var user = await userServices.GetByIdUserAsync(id);
    if (user is null) return Results.NotFound();

    user.Name = updatedUser.Name;
    user.Email = updatedUser.Email;
    user.Endereco = updatedUser.Email;
    await userServices.UpdateUserAsync(user);
    return Results.NoContent();
});

app.Run();
