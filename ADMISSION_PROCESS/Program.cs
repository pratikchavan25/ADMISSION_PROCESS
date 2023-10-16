using ADMISSION_PROCESS.Repository;
using ADMISSION_PROCESS.Repository.Interfaces;
using ADMISSION_PROCESS.Services;
using ADMISSION_PROCESS.Services.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings:DefaultConnections").Value));
builder.Services.AddCors(options => options.AddDefaultPolicy(
                builder => builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin()
            ));
builder.Services.AddScoped<IAdmission_FormRepository, Admission_FormRepository>();
builder.Services.AddScoped<IAdmission_FormService, AdmissionServices>();
// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
