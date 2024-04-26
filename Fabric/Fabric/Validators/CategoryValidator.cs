using Fabric.Models;
using FluentValidation;

namespace Fabric.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(prop => prop.CategoryName).NotEmpty().MinimumLength(3).MaximumLength(30);
            RuleFor(prop => prop.CategoryDescription).NotEmpty().MinimumLength(5).MaximumLength(500);
        }
    }
}
