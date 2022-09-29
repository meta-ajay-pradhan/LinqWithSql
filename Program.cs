using Microsoft.EntityFrameworkCore;
namespace LinqWithSql;
class Program
{
    static void Main(string[] args)
    {
        using (var context = new ShopContext())
        {
            DbSet<Product> Products = context.Products;
            DbSet<Category> Categories = context.Categories;

            var getProducts = from p in Products
                              join c in Categories on p.Category.CategoryId equals c.CategoryId
                              select new
                              {
                                  ProductId = p.ProductId,
                                  ProductTitle = p.ProductTitle,
                                  CategoryTitle = c.CategoryTitle
                              };
            foreach (var prod in getProducts)
            {
                Console.WriteLine("{0} {1} {2}", prod.ProductId, prod.ProductTitle, prod.CategoryTitle);
            }

            var getProdAndCategory = from c in Categories
                                     join p in Products on c.CategoryId equals p.Category.CategoryId into prodCat
                                     from pc in prodCat.DefaultIfEmpty()
                                     select new
                                     {
                                         ProdAndCategory = (pc == null ? "No Product" : pc.ProductTitle) + " : " + c.CategoryTitle
                                     };

            foreach(var prodCat in getProdAndCategory) {
                Console.WriteLine("{0}", prodCat.ProdAndCategory);
            }
        }
    }
}
