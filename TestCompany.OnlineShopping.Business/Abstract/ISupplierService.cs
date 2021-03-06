﻿using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.Business.Abstract
{
    interface ISupplierService
    {
        List<Supplier> GetAll();
        void Add(Supplier supplier);
        void Update(Supplier supplier);
        void Delete(Supplier supplier);
    }
}
