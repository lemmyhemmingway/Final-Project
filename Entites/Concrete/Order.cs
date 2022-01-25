using System.Reflection.Metadata.Ecma335;
using Core.Entities;

namespace Entites.Concrete;

public class Order: IEntity
{
    public int OrderId  { get; set; }
    public int EmployeeId { get; set; }
    public string CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public string ShipCity { get; set; }
    
}