using Core.DataAccess;
using Entitites.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product> { }
}
