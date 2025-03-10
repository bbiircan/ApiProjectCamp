using ApiProjectCamp.WebApi.Entities;
using FluentValidation;

namespace ApiProjectCamp.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x=>x.ProductName).NotEmpty().WithMessage("Enter the product name ").MinimumLength(2)
                .WithMessage("The product name cannot be less than 2 characters").MaximumLength(50)
                .WithMessage("The product name cannot be more than 50 characters.");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Enter the product price").GreaterThan(0)
                .WithMessage("The product price cannot be a negative value").LessThan(1000)
                .WithMessage("The product price is too high, check the value you entered");

            RuleFor(x => x.Content).NotEmpty().WithMessage("Enter the product description");
        }
    }
}
