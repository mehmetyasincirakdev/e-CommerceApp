using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(command => command.ProductName).MinimumLength(2);
            RuleFor(command => command.ProductName).NotEmpty();
            RuleFor(command => command.UnitPrice).NotEmpty();
            RuleFor(command => command.UnitPrice).GreaterThan(0);
            RuleFor(command => command.UnitPrice).GreaterThanOrEqualTo(10).When(command => command.CategoryId == 1);
        }
    }
}
