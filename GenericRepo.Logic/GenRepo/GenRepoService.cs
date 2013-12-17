using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepo.Logic.GenRepo
{
  public class GenRepoService<TEntity> : IGenRepoService<TEntity> where TEntity : class
  {
    private readonly IGenRepoRepository<TEntity> _repository;

    public GenRepoService(IGenRepoRepository<TEntity> repository)
    {
      _repository = repository;
    }

    public List<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
    {
      return _repository.Get(predicate);
    }

    public TEntity GetSingle(Expression<Func<TEntity,bool>> predicate)
    {
      return _repository.GetSingle(predicate);
    }

    public List<TEntity> Get()
    {
      return _repository.Get();
    }

    public TEntity Create(TEntity model)
    {
      return _repository.Create(model);
    }

    public TEntity Update(TEntity model)
    {
      return _repository.Update(model);
    }

    public bool Delete(TEntity model)
    {
      return _repository.Delete(model);
    }
  }
}
