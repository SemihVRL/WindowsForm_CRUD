﻿using Northwind.Businnes.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Businnes.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;
       

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        
        
        public List<Category> GetAll()
        {

            return _categoryDal.GetAll();
        }
    }
}
