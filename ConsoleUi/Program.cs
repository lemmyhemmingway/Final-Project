// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entites.Concrete;


ProductManager pm = new ProductManager(new EFProductDal());
pm.Add(new Product
{
    Id = 1, CategoryId = 1, ProductName = "test", UnitPrice = 1, UnitsInStock = 1
});