using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GenericRepo.Logic.GenRepo;
using Microsoft.CSharp;

namespace GenericRepo.Data.GenRepo
{
  public class GenRepoRepository<T, C> : IGenRepoRepository<T>
    where T : class
    where C : DbContext, new()
  {


    public T GetSingle(Expression<Func<T, bool>> predicate)
    {
      using (var db = new C())
      {
        return db.Set<T>().FirstOrDefault(predicate);
      }
    }

    public List<T> Get(Expression<Func<T, bool>> predicate)
    {
      using (var db = new C())
      {
        return db.Set<T>().Where(predicate).ToList();
      }
    }

    public List<T> Get()
    {
      using (var db = new C())
      {
        return db.Set<T>().ToList();
      }
    }

    public T Create(T model)
    {
      using (var db = new C())
      {
        db.Set<T>().Add(model);
        db.SaveChanges();
        return model;
      }
    }

    public T Update(T model)
    {
      using (var db = new C())
      {
        db.Entry(model).State = EntityState.Modified;
        db.SaveChanges();
        return model;
      }
    }

    public bool Delete(T model)
    {
      using (var db = new C())
      {
        db.Entry(model).State = EntityState.Deleted;
        db.SaveChanges();
        return true;
      }
    }
  }
}
