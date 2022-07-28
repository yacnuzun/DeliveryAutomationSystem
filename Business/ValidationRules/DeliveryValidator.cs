using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class DeliveryValidator : AbstractValidator<Delivery>
    {
        public DeliveryValidator()
        {
            RuleFor(d => d.VehicleNumber).NotEmpty();
            RuleFor(d => d.VehicleNumber).MinimumLength(5);
            RuleFor(d => d.VehicleNumber).MaximumLength(20);
            RuleFor(d => d.CargoMan).NotEmpty();
            RuleFor(d => d.CargoMan).MinimumLength(2);
            RuleFor(d => d.CargoMan).MaximumLength(20);
            RuleFor(d => d.DeliveryDate).NotEmpty();
            RuleFor(d => d.DeliveryDate.Year).GreaterThan(DateTime.Now.Year);
            RuleFor(d => d.Status).NotEmpty();

        }
    }
}
