using Ninject.Modules;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concreate.EntityFramework;
using Nortwind.Business.Abstract;
using Nortwind.Business.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Business.DependencyResolver.Ninject
{ 
    public class BusinessModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCatergoryDal>().InSingletonScope();
        }
    }
}
