using System.ComponentModel.DataAnnotations;

namespace LinqWithSql;
public class Product
{
    public int ProductId { get; set; }
    public string? ProductTitle { get; set; }
    public Category? Category {get; set;}
    
}