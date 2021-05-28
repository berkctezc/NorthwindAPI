using System.Collections.Generic;
using Core.Utilities.Results;
using Entitites.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetById(int categoryId);
        IDataResult<List<Category>> GetList();
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
    }
}