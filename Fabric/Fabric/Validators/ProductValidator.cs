using Fabric.Models;
using FluentValidation;

namespace Fabric.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(prop => prop.ProductName).NotEmpty().MaximumLength(30);
            RuleFor(prop=>prop.ProductDescription).NotEmpty().MaximumLength(100);
            RuleFor(prop => prop.Price).NotNull();
        }
    }
}
