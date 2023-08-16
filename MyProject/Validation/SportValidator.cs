using FluentValidation;
using MyProject.Data;
using MyProject.Models;

namespace MyProject.Validation
{
    public class SportValidator:AbstractValidator<RequestSportModel>
    {
        public SportValidator()
        {
            RuleFor(s => s.SportName).NotEmpty().MaximumLength(50).Matches(@"^[A-Za-z\s]*$");
        }
    }
}
