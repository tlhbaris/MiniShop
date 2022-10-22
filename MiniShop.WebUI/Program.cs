using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.EfCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
builder.Services.AddScoped<IProductRepository, EfCoreProductRepository>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();


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
    name: "createproduct",
    pattern: "admin/createproduct",
    defaults: new { controller = "Admin", action = "ProductCreate" }
    );
app.MapControllerRoute(
    name: "adminproductlist",
    pattern: "admin/products",
    defaults: new { controller = "Admin", action = "ProductList" }
    );
app.MapControllerRoute(
    name: "search",
    pattern: "search",
    defaults: new { controller = "MiniShop", action = "search" }
    );
app.MapControllerRoute(
    name: "products",
    pattern: "products/{category?}",
    defaults: new { controller = "MiniShop", action = "List" }
    );
app.MapControllerRoute(
    name: "productdetails",
    pattern: "{url}",
    defaults: new { controller = "MiniShop", action = "Details" }
    );


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
