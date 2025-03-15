using eCommerce.Infrastructure;
using eCommerce.Core;
using eCommerce.API.Middlewares;
using System.Text.Json.Serialization;
using eCommerce.Core.Mappers;
using FluentValidation.AspNetCore;


var builder = WebApplication.CreateBuilder(args);

// Add Infrastructure Services
builder.Services.AddInfrastructure();
builder.Services.AddCore();

//Add Controllers
builder.Services.AddControllers().AddJsonOptions(options =>
{ 
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());  
});

builder.Services.AddAutoMapper(typeof(ApplicationUserMappingProfile).Assembly);

// FluentValidation
builder.Services.AddFluentValidationAutoValidation();


var app = builder.Build();

app.UseExceptionHandlingMiddleware();

//Routing
app.UseRouting();

//Authentication
app.UseAuthentication();
app.UseAuthorization();

//Controllers Routes
app.MapControllers();

app.Run();
