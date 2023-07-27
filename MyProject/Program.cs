using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyProject.Data;
using MyProject.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//
builder.Services.AddCors(options => options.AddDefaultPolicy(policy=>policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
builder.Services.AddDbContext<MyDBContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("MyDB"));
});
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<ISportRepository,SportRepository>();
builder.Services.AddScoped<IRoleRepository,RoleRepository>();
builder.Services.AddScoped<IWorkoutRepository,WorkoutRepository>();
builder.Services.AddScoped<IUserRepository,UserRepository>();
//
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
