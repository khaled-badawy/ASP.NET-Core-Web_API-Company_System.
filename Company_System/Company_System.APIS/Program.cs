using Company.BL;
using Company.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Database 

var connectionString = builder.Configuration.GetConnectionString("Company_Connection");
builder.Services.AddDbContext<CompanyContext>(options =>
    options.UseNpgsql(connectionString));

#endregion

// Add Repo
builder.Services.AddScoped<IDepartmentRepo, DepartmentRepo>();

// Add Manager
builder.Services.AddScoped<IDepartmentManager,DepartmentManager>(); 

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
