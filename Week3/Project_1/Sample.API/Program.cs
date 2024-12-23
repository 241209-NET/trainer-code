using Microsoft.EntityFrameworkCore;
using Sample.API.Data;
using Sample.API.Repository;
using Sample.API.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add dbcontext with connection string
builder.Services.AddDbContext<SampleContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Sample")));

//Add service dependencies
builder.Services.AddScoped<IStudentService, StudentService>();

//Add repo dependencies
builder.Services.AddScoped<IStudentRepository, StudentRepository>();

//Add controllers
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//Map controllers
app.MapControllers();
app.Run();