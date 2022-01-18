using Entites.Abstract;

namespace Entites.Concrete;

public class Product: IEntity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public short UnitsInStock { get; set; }
    public decimal UnitPrice { get; set; }
    
    
}