using Core.DataAccess;
using Entitites.Concrete;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category> { }
}