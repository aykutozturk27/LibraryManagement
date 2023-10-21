using FluentValidation;
using LibraryManagement.Business.Constants;
using LibraryManagement.Entities.Concrete;

namespace LibraryManagement.Business.ValidationRules.FluentValidation
{
    public class PersonalValidator : AbstractValidator<Personal>
    {
        public PersonalValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage(Messages.FirstNameIsNotEmpty);
            RuleFor(x => x.LastName).NotEmpty().WithMessage(Messages.LastNameIsNotEmpty);
            RuleFor(x => x.IdentityNumber).NotEmpty().WithMessage(Messages.IdentityNumberIsNotEmpty);
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage(Messages.PhoneNumberIsNotEmpty);
        }
    }
}
