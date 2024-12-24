//-------------------------------services Containers-------------------------------------//

using ServiceStation.Web.Models;

var builder = WebApplication.CreateBuilder(args); //default tell create webapplication
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SeviceDBContext>();  //DbContext Dependency injection

var app = builder.Build();


//-------------------------------Configurations-------------------------------------//

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//-------------------------------Middleware-------------------------------------//

app.UseHttpsRedirection();//use https for every direction
app.UseStaticFiles();//use static files in wwwroot folder.

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
