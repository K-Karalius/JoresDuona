using JoresDuona.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // This includes both controllers and views
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

/* For future use
using IServiceScope scope = app.Services.CreateScope();
UserSessionService userService = scope.ServiceProvider.GetRequiredService<UserSessionService>();
*/

app.MapDefaultControllerRoute();

app.Run();
