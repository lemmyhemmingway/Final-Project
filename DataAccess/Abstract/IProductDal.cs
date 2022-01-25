using Core.DataAccess;
using Entites.Concrete;
using Entites.DTOs;

namespace DataAccess.Abstract;

public interface IProductDal:IEntityRepository<Product>
{
    List<ProductDetailDto> GetProductDetail();
}