using Microsoft.EntityFrameworkCore;
using PetTracker.API.Data;
using PetTracker.API.Repository;
using PetTracker.API.Service;

var builder = WebApplication.CreateBuilder(args);

//Add dbcontext and connect it to connection string
builder.Services.AddDbContext<PetContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("PetsDB")));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Inject the proper services
builder.Services.AddScoped<IPetService, PetService>();
builder.Services.AddScoped<IPetRepository, PetRepository>();

//Add our controllers
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();