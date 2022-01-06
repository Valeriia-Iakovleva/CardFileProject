using CardFileProject.DAL.Models;
using CardFileProject.DAL.Repositories;
using System;
using Ninject.Modules;
using System.Linq;
using System.Web;
using CardFileProject.BLL.Services;

namespace CardFileProject.DependencyInjection
{
    public class DependencyResolverModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICardFileRepository>().To<CardFileRepository>();
            Bind<ICardFileService>().To<CardFileService>();
        }
    }
}