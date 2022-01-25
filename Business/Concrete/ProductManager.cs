using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entites.Concrete;
using Entites.DTOs;

namespace Business.Concrete;

public class ProductManager: IProductService
{
    private IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;

    }
    public List<Product> GetAll()
    {
        return _productDal.GetAll();
    }

    public List<Product> GetAllByCategoryId(int id)
    {
        return _productDal.GetAll(p => p.CategoryId == id);
    }

    public List<Product> GetAllByUnitPrice(decimal minPrice, decimal maxPrice)
    {
        return _productDal.GetAll(p => p.UnitPrice >= minPrice && p.UnitPrice <= maxPrice);
    }

    public void Add(Product product)
    {
        _productDal.Add(product);
    }

    public List<ProductDetailDto> GetProductDetails()
    {
        return _productDal.GetProductDetail();
    }
}