using Entites.Concrete;
using Entites.DTOs;

namespace Business.Abstract;

public interface IProductService
{
    List<Product> GetAll();

    List<Product> GetAllByCategoryId(int id);
    List<Product> GetAllByUnitPrice(decimal minPrice, decimal maxPrice);
    void Add(Product product);
    List<ProductDetailDto> GetProductDetails();


}