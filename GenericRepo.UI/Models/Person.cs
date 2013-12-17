using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericRepo.UI.Models
{
  public class Person
  {
    public Person()
    {
      
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
  }
}