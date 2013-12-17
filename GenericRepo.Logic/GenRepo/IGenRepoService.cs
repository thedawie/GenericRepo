using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepo.Logic.GenRepo
{
  public interface IGenRepoService<TEntity> where TEntity : class
  {
    List<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
    TEntity GetSingle(Expression<Func<TEntity, bool>> predicate);
    List<TEntity> Get();
    TEntity Create(TEntity model);
    TEntity Update(TEntity model);
    bool Delete(TEntity model);
  }
}
