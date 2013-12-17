using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GenericRepo.Logic.GenRepo;
using GenericRepo.UI.Models;

namespace GenericRepo.UI.Controllers
{
  public class HomeController : Controller
  {
    private readonly IGenRepoService<Person> _genRepoService;

    public HomeController(IGenRepoService<Person> genRepoService)
    {
      _genRepoService = genRepoService;
    }

    public ActionResult Index()
    {

      var result = _genRepoService.Get(x => x.Id == 1);

      //Create
      //var person = new Person()
      //  {
      //    FirstName = "John",
      //    LastName = "Doe"
      //  };
      //var createResult = _genRepoService.Create(person);

      //Update
      //var getPerson = _genRepoService.GetSingle(x => x.Id == 1);
      //if (getPerson != null)
      //{
      //  getPerson.LastName = "VanDer";
      //  var updateResult = _genRepoService.Update(getPerson); 
      //}

      //Delete
      //var getPerson = _genRepoService.GetSingle(x => x.Id == 1);
      //if (getPerson != null)
      //{
      //  var deleteResult = _genRepoService.Delete(getPerson);
      //}

      //GetAll
      var getAll = _genRepoService.Get();



      return View("Index");
    }

  }
}
