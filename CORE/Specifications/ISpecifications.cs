using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CORE.Specifications
{
    public interface ISpecifications<T>
    {
      Expression<Func<T, bool>> Creteria {get;}
      List<Expression<Func<T, object>>> Includes {get;}
    }
}