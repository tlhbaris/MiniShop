using MiniShop.Data.Concrete.EfCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();
//Middlewares - uygulamaya her istekte bulunuldu�unda �al��t�r�lan �eylerdir.
if (!app.Environment.IsDevelopment())
{
    
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
} else{
    SeedDatabase.Seed();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
