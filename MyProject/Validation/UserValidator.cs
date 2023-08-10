using FluentValidation;
using MyProject.Models;

namespace MyProject.Validation
{
    public class UserValidator:AbstractValidator<RequestUserModel>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserName).NotEmpty().MaximumLength(50);
            RuleFor(u=>u.FistName).NotEmpty().MaximumLength(50);
            RuleFor(u=>u.LastName).NotEmpty().MaximumLength(50);
            RuleFor(u => u.Address).NotEmpty().MaximumLength(250);
            RuleFor(u=>u.PhoneNumber).NotEmpty().MaximumLength(10);
            RuleFor(u => u.Password).NotEmpty().MinimumLength(8);
        }
    }
}
