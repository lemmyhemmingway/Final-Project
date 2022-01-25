using System.Linq.Expressions;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;

namespace DataAccess.Concrete.InMemory;

public class InMemoryProductDal: IProductDal
{
    List<Product> _products;

    public InMemoryProductDal()
    {
        _products = new List<Product>()
        {
            new Product{Id = 1,CategoryId = 1,ProductName = "Name", UnitPrice = 15, UnitsInStock = 15},
            new Product{Id = 2,CategoryId = 1,ProductName = "Name 2", UnitPrice = 500, UnitsInStock = 3},
            new Product{Id = 3,CategoryId = 2,ProductName = "Name 3", UnitPrice = 1500, UnitsInStock = 2},
            new Product{Id = 4,CategoryId = 2,ProductName = "Name 4", UnitPrice = 150, UnitsInStock = 65},
            new Product{Id = 5,CategoryId = 2,ProductName = "Name 5", UnitPrice = 85, UnitsInStock = 1},
        };
    }
    public List<Product> GetAll()
    {
        return _products;
    }

    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Update(Product product)
    {
        Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
        productToUpdate.Id = product.Id;
        productToUpdate.CategoryId = product.CategoryId;
        productToUpdate.ProductName = product.ProductName;
        productToUpdate.UnitPrice = product.UnitPrice;
        productToUpdate.UnitsInStock = product.UnitsInStock;
    }

    public void Delete(Product product)
    {
        Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
        _products.Remove(productToDelete);
    }

    public List<ProductDetailDto> GetProductDetail()
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAllByCategory(int categoryId)
    {
        return _products.Where(p => p.CategoryId == categoryId).ToList();
    }
}