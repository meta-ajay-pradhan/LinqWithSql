
namespace LinqWithSql;
public class Category
{
    public int CategoryId { get; set; }
    public string? CategoryTitle { get; set; }
    public ICollection<Product> Products { get; set; } = new List<Product>();
}