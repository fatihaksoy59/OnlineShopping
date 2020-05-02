using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.Business.ValidationRules.FluentValidation
{
    //Aspect Oriented Programming (AOP ) kullanıyoruz.
    //Fluent Validation kullanmamızın amacı , Single responsibility ' e uyması.
    class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //.WithMessage ile kendi mesajını donebilirsin.
            RuleFor(p => p.CategoryID).NotEmpty();
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThan(20).When(p=>p.CategoryID==1);

            /*  
             //Aşağıdaki gibi özel kural yazabiliyoruz.
            RuleFor(p => p.ProductName).Must(StartWithA);
            */

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
