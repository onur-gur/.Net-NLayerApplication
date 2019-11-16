using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concreate.EntityFramework
{
    public class EfCatergoryDal :EfRepositoryBase<Category,NortwindContext>,ICategoryDal
    {
    }
}
