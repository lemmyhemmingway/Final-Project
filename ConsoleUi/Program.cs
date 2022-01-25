// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entites.Concrete;


void ProductManagerTest()
{
    ProductManager pm = new ProductManager(new EfProductDal());
    pm.Add(new Product
    {
        Id = 1, CategoryId = 1, ProductName = "test", UnitPrice = 1, UnitsInStock = 1
    });
}

CategoryManager cm = new(new EfCategoryDal());
var categories = cm.GetAll();
foreach (var category in categories)
{
    Console.WriteLine(category.CategoryName);
}
