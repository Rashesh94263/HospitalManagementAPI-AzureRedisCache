using FluentValidation;
using FluentValidation.AspNetCore;
using HospitalManagementSystem.API.src.Data;
using HospitalManagementSystem.API.src.Mappings;
using HospitalManagementSystem.API.src.Repositories;
using HospitalManagementSystem.API.src.Services;
using HospitalManagementSystem.API.src.Validators;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Connection string for the DbContext Class
builder.Services.AddDbContext<DataHospitalManagementSystemDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("HospitalManagementSystemConnectionString")));


// Connection String for the Redis Cache
builder.Services.AddStackExchangeRedisCache(options =>
{
   options.Configuration = builder.Configuration.GetConnectionString("ClinicDataRedisConnectionString");
    options.InstanceName = "ClinicResources";
});

// Register repositories
builder.Services.AddScoped<IClinicRepository, ClinicRepository>();

// Register services
builder.Services.AddScoped<IClinicService, ClinicService>();

// Register AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

// Register custom services
builder.Services.AddSingleton<RedisCacheServices>();

// Register all validators from the current assembly
builder.Services.AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters()
                .AddValidatorsFromAssemblyContaining<ClinicValidator>();

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
