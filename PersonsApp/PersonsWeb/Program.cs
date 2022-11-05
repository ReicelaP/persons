using Microsoft.EntityFrameworkCore;
using Persons.Data;
using Persons.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PersonsDbContext>(options =>
    options.UseSqlServer(builder.Configuration
    .GetConnectionString("persons-database")));

builder.Services.AddScoped<IPersonsDbContext, PersonsDbContext>();
builder.Services.AddScoped<CrudService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Person}/{action=Index}/{id?}");

app.Run();
