using System.Web.Mvc;
using GenericRepo.Data.GenRepo;
using GenericRepo.Logic.GenRepo;
using GenericRepo.UI.Models;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

namespace GenericRepo.UI
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();    
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {

      container.RegisterType<IGenRepoService<Person>, GenRepoService<Person>>();
      container.RegisterType<IGenRepoRepository<Person>, GenRepoRepository<Person, GenericRepoContext>>();
    }
  }
}