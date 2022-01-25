using Business.Abstract;
using DataAccess.Abstract;
using Entites.Concrete;

namespace Business.Concrete;

public class CategoryManager: ICategoryService
{
    private ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category GetById(int id)
    {
        return _categoryDal.Get(c => c.Id == id);
    }
}