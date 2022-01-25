using System.Linq.Expressions;
using DataAccess.Abstract;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EFProductDal : IProductDal
{
    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        using (NorthwindContext context = new())
        {
            return filter == null 
                ? context.Set<Product>().ToList() 
                : context.Set<Product>().Where(filter).ToList();
        }
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        using (NorthwindContext context = new())
        {
            return context.Set<Product>().SingleOrDefault(filter);
        }
    }

    public void Add(Product entity)
    {
        // IDispossable pattern implementation
        using (NorthwindContext context = new NorthwindContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }

    public void Update(Product entity)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var updatedEntry = context.Entry(entity);
            updatedEntry.State = EntityState.Modified;
            context.SaveChanges();
        }
    }

    public void Delete(Product entity)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var deletedEntry = context.Entry(entity);
            deletedEntry.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}