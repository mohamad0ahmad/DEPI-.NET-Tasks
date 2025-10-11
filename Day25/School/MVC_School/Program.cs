using MVC_School.Data.DbContexts;
using MVC_School.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Remove DbContext configuration from here as it's handled in the DbContext itself
builder.Services.AddDbContext<SchoolDbContext>();

// Add services for controllers with views (MVC)
builder.Services.AddControllersWithViews();

// Register the Business Logic Layer services
builder.Services.AddScoped<DepartmentBL>();
builder.Services.AddScoped<StudentBL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Default route setup
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
