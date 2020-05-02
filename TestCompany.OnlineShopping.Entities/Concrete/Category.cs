using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.Core.Entities;

namespace TestCompany.OnlineShopping.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //bunun veri tipi ne olmalı ??
        public int Image { get; set; }

     
    }
}
