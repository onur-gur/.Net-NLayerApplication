﻿using Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}