using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entites.Concrete;

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
}