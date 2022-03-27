using Microsoft.EntityFrameworkCore;
using Features.Libraries.BooksFeatures.Commands;
using Features.Libraries.LibraryFeatures.Commands;
using Features.Members.BooksFeatures.Commands;
using Features.Members.UsersFeatures.Commands;

using Features.Libraries.BooksFeatures.Queries;
using Features.Libraries.LibraryFeatures.Queries;
using Features.Members.BooksFeatures.Queries;
using Features.Members.UsersFeatures.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IBooksFeaturesCommand,BooksFeaturesCommand>();
builder.Services.AddSingleton<ILibrariesCommand, LibrariesCommand>();
builder.Services.AddSingleton<ILoandBookFeaturesCommand, ILoandBookFeaturesCommand>();
builder.Services.AddSingleton<IUserFeaturesCommand, IUserFeaturesCommand>();


builder.Services.AddSingleton<IBooksFeaturesQuery, BooksFeaturesQuery>();
builder.Services.AddSingleton<ILibrariesQuery, LibrariesQuery>();
builder.Services.AddSingleton<ILoandBookFeaturesQuery, ILoandBookFeaturesQuery>();
builder.Services.AddSingleton<IUserFeaturesQuery, IUserFeaturesQuery>();


builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Infrastructure.Data.EFContext>(options => {
	options.UseSqlServer(builder.Configuration.GetConnectionString("EFConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
