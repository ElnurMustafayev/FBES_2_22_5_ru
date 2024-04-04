var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}");

app.Run();


// {controller=Home}/{action=Test}

// /            -> /Home/Index
// /Home        -> /Home/Index
// /Home/Index  -> /Home/Index

// {controller=Home}/{action=Test}

// /            -> /Home/Index
// /Test        -> /Test/Index
// /Test/Index  -> /Test/Index
// /Test/Action -> /Test/Action