using Core.Entities;

namespace Entites.Concrete;

public class Category: IEntity
{

    public int Id { get; set; }
    public string CategoryName { get; set; }
    
}