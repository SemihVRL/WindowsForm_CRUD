﻿using Northwind.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Concrete
{
    public class Product:IEntity
    {
        public int ProductID { get; set; } 
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
  
       
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public Int16 UnitsInStock { get; set; }
       
    }
}
