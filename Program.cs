using demokhaithocode.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsProduction())
{
    builder.WebHost.UseUrls("http://+:80");
}
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
//entity framework
var connectionString = builder.Configuration.GetConnectionString("ConnectionStrings");
builder.Services.AddDbContext<StoreContext>(options =>
    options
        .UseLazyLoadingProxies(false)
        .UseSqlServer(connectionString));
var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

