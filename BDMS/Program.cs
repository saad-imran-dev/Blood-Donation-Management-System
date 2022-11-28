using BDMS.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
<<<<<<< HEAD
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
=======
    builder.Configuration.GetConnectionString("DefaultConnection")));


>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2
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
<<<<<<< HEAD
    pattern: "{controller=Login}/{action=DonorLogin}/{id?}");
=======
    pattern: "{controller=Home}/{action=Index}/{id?}");
>>>>>>> 4efe9cc7413690b909237a22cacc57c20d2ff2a2

app.Run();
