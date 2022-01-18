// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.InMemory;

ProductManager pm = new ProductManager(new InMemoryProductDal());
foreach (var p in pm.GetAll())
{
    Console.WriteLine(p.ProductName);
}