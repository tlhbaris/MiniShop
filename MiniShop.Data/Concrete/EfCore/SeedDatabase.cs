using Microsoft.EntityFrameworkCore;
using MiniShop.Entity;
using System.Linq;

namespace MiniShop.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new MiniShopContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
                if (context.ProductCategories.Count() == 0)
                {
                    context.ProductCategories.AddRange(ProductCategories);
                }
                context.SaveChanges();
            }
        }
        private static Category[] Categories = 
        {
            new Category() {Name="Telefon", Description="Telefon kategorisi", Url="telefon"},
            new Category() {Name="Bilgisayar", Description="Bilgisayar kategorisi", Url="bilgisayar"},
            new Category() {Name="Elektronik", Description="Elektronik kategorisi", Url="elektronik"},
            new Category() {Name="Beyaz Eşya", Description="Beyaz Eşya kategorisi", Url="beyaz-esya"}
        };

        private static Product[] Products = 
        {
            new Product() {Name= "Samsung S20", Price=18000,Description="İyi bir telefondur",Url="samsung-s20", ImageUrl="1.png", IsApproved=true, IsHome=true},

            new Product() {Name= "Samsung S21", Price=19000,Description="İyi bir telefondur",Url="samsung-s21", ImageUrl="2.png", IsApproved=true, IsHome=false},

            new Product() {Name= "Iphone SE", Price=14000,Description="İyi bir telefondur",Url="iphone-se", ImageUrl="3.png", IsApproved=true, IsHome=true},

            new Product() {Name= "Iphone 13", Price=23000,Description="İyi bir telefondur",Url="iphone-13", ImageUrl="4.png", IsApproved=false, IsHome=false},

            new Product() {Name= "Iphone 13 Pro Max", Price=25000,Description="İyi bir telefondur",Url="iphone-13-pro-max", ImageUrl="5.png", IsApproved=true, IsHome=false},

            new Product() {Name= "Xaomi Redmi 9 Plus", Price=17000,Description="İyi bir telefondur",Url="xaomi-redmi-9-plus", ImageUrl="6.png", IsApproved=true, IsHome=false},

            new Product() {Name= "Xaomi Redmi 10", Price=20000,Description="İyi bir telefondur",Url="xaomi-redmi-10", ImageUrl="7.png", IsApproved=true, IsHome=true},

            new Product() {Name= "Huawei Mate 12", Price=18000,Description="İyi bir telefondur",Url="huawei-mate-12", ImageUrl="8.png", IsApproved=true, IsHome=false}
        };
        
        private static ProductCategory[] ProductCategories= 
        {
            new ProductCategory() { Product = Products[0],Category = Categories[0] },
            new ProductCategory() { Product = Products[0],Category = Categories[2] },
            new ProductCategory() { Product = Products[1],Category = Categories[0] },
            new ProductCategory() { Product = Products[1],Category = Categories[2] },
            new ProductCategory() { Product = Products[2],Category = Categories[1] },
            new ProductCategory() { Product = Products[2],Category = Categories[2] },
            new ProductCategory() { Product = Products[3],Category = Categories[1] },
            new ProductCategory() { Product = Products[3],Category = Categories[2] },
            new ProductCategory() { Product = Products[4],Category = Categories[0] },
            new ProductCategory() { Product = Products[4],Category = Categories[2] },
            new ProductCategory() { Product = Products[5],Category = Categories[0] },
            new ProductCategory() { Product = Products[6],Category = Categories[1] },
            new ProductCategory() { Product = Products[6],Category = Categories[3] },
            new ProductCategory() { Product = Products[7],Category = Categories[1] }
        };
        
    }
}