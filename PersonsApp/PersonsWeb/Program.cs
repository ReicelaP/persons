using Microsoft.EntityFrameworkCore;
using Persons.Core.Models;
using Persons.Core.Services;
using Persons.Data;
using Persons.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PersonsDbContext>(options =>
    options.UseSqlServer(builder.Configuration
    .GetConnectionString("persons-database")));

builder.Services.AddScoped<IPersonsDbContext, PersonsDbContext>();
builder.Services.AddScoped<ICrudService, CrudService>();
builder.Services.AddScoped<IEntityService<Person>, EntityService<Person>>();
builder.Services.AddScoped<IEntityService<User>, EntityService<User>>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
