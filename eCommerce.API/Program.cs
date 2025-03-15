using eCommerce.Infrastructure;
using eCommerce.Core;
using eCommerce.API.Middlewares;
var builder = WebApplication.CreateBuilder(args);

// Add Infrastructure Services
builder.Services.AddInfrastructure();
builder.Services.AddCore();

//Add Controllers
builder.Services.AddControllers();

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
