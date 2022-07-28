using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(o => o.StartPoint).NotEmpty();
            RuleFor(o => o.StartPoint).MinimumLength(2);
            RuleFor(o => o.StartPoint).MaximumLength(50);
            RuleFor(o => o.EndPoint).NotEmpty();
            RuleFor(o => o.EndPoint).MinimumLength(2);
            RuleFor(o => o.EndPoint).MaximumLength(50);
            RuleFor(o => o.OrderDate).NotEmpty();
            RuleFor(o => o.ContactNumber).NotEmpty();
            RuleFor(o => o.ContactNumber).MinimumLength(10);
            RuleFor(o => o.ContactNumber).MaximumLength(30);
        }
    }
}
