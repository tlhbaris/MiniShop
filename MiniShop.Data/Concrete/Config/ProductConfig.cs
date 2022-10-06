using Microsoft.EntityFrameworkCore;
using MiniShop.Entity;

namespace MiniShop.Data.Concrete
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        }
    }
}