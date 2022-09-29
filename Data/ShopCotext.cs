using Microsoft.EntityFrameworkCore;

namespace LinqWithSql;
class ShopContext: DbContext {
    public DbSet<Product> Products {get; set;}
    public DbSet<Category> Categories {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer(@"Server=AJAY-PRADHAN\SQLEXPRESS;Database=EFCoreDemo;Trusted_Connection=True;MultipleActiveResultSets=true;User Id=sa;Password=ciitdc1234#");
    }
}