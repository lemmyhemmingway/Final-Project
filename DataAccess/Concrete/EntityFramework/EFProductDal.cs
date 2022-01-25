using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
{
    public List<ProductDetailDto> GetProductDetail()
    {
        using (NorthwindContext northwindContext = new())
        {
            var result = from p in northwindContext.Products
                join c in northwindContext.Categories
                    on p.CategoryId equals c.Id
                select new ProductDetailDto
                {
                    CategoryName = c.CategoryName, ProductId = p.Id, ProductName = p.ProductName,
                    UnitsInStock = p.UnitsInStock
                };
            return result.ToList();
        }
    }
}