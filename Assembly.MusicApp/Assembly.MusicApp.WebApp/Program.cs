using Assembly.MusicApp.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddRazorPages();

builder.Services.ConfigureWebApp();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.Use(async (context, next) =>
//{
//    using var stream = context.Request.Body; // {"username": ""}

//    string x = await stream.Read();

//   var user = JsonSerializer.Serialize<AccountRequest>(x);
//    return;

//    return next();
//}
//)

app.MapRazorPages();

app.Run();
