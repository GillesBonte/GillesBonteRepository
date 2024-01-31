using MVCRecapture.Models;
using MVCRecapture.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<GameRepo>();
builder.Services.AddTransient<GenreRepo>();
builder.Services.AddTransient<SubgenreRepo>();
builder.Services.AddTransient<CounterTransient>();
builder.Services.AddSingleton<CounterSingleton>();
builder.Services.AddScoped<CounterScoped>();




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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
