using eCommerce.Infrastructure;
using eCommerce.Core;
var builder = WebApplication.CreateBuilder(args);

// Add Infrastructure Services
builder.Services.AddInfrastructure();
builder.Services.AddCore();

//Add Controllers
builder.Services.AddControllers();

var app = builder.Build();

//Routing
app.UseRouting();

//Authentication
app.UseAuthentication();
app.UseAuthorization();

//Controllers Routes
app.MapControllers();

app.Run();
