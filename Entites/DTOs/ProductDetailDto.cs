using System.Reflection.Metadata.Ecma335;
using Core.Entities;

namespace Entites.DTOs;

public class ProductDetailDto: IDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string CategoryName { get; set; }
    public short UnitsInStock { get; set; }
    
}
