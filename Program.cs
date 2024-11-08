using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using logindlm.Model;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();  // API szolgáltatások hozzáadása

builder.Services.AddDbContext<AuthDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AuthConnectionString")));
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AuthDbContext>();

// Configure authentication with a login path
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/login"; // Bejelentkezési oldal elérési útja
    options.SlidingExpiration = true;
    options.Cookie.HttpOnly = true;
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Csak HTTPS-en keresztül küldhetõ cookie
    options.Cookie.SameSite = SameSiteMode.Strict; // Szoros SameSite beállítás a cookie-khoz
});

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

// Alkalmazza a CORS beállítást
app.UseCors("AllowSpecificOrigin");

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Redirect root path to login
app.MapGet("/", () => Results.Redirect("/termek"));

// Map Razor Pages
app.MapRazorPages();

// Map API controllers
app.MapControllers();  // API végpontok hozzáadása

app.Run();
