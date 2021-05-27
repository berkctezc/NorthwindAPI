using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity
    {
    }
}
