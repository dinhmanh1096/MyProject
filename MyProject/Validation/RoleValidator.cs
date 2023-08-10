using FluentValidation;
using MyProject.Models;

namespace MyProject.Validation
{
    public class RoleValidator: AbstractValidator<RequestRoleModel>
    {
        public RoleValidator() 
        {
            RuleFor(r => r.RoleName).NotEmpty().MaximumLength(50);
        }
    }
}
