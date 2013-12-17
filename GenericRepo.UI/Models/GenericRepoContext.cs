using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GenericRepo.UI.Models
{
  public class GenericRepoContext : DbContext
  {
    public DbSet<Person> Persons { get; set; }
  }
}