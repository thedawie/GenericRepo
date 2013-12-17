using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepo.Logic.GenRepo
{
  public interface IGenRepoRepository<T> where T : class
  {
    T GetSingle(Expression<Func<T, bool>> predicate);
    List<T> Get(Expression<Func<T, bool>> predicate);
    List<T> Get();
    T Create(T model);
    T Update(T model);
    bool Delete(T model);
  }
}
