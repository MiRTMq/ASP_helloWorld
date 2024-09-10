var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for
    // production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

Company com = new Company("Bread Company", 333, "Bakes bread");

app.MapGet("/company", () => com.ToString());

app.MapGet("/rand", () =>
{
    Random rand = new Random();
    int num = rand.Next(0, 101);
    return num.ToString();
});

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "default",
                       pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
