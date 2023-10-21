using FluentValidation;
using LibraryManagement.Business.Constants;
using LibraryManagement.Entities.Concrete;

namespace LibraryManagement.Business.ValidationRules.FluentValidation
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(x => x.BookName).NotEmpty().WithMessage(Messages.BookNameIsNotEmpty);
            RuleFor(x => x.Author).NotEmpty().WithMessage(Messages.AuthorIsNotEmpty);
            RuleFor(x => x.ISBN).NotEmpty().WithMessage(Messages.ISBNIsNotEmpty);
            RuleFor(x => x.ReceivingDate).NotEmpty().WithMessage(Messages.ReceivingDateIsNotEmpty);
            RuleFor(x => x.ReturnDate).NotEmpty().WithMessage(Messages.ReturnDateIsNotEmpty);

            //RuleFor(x => x.Personal.FullName).NotEmpty().WithMessage(Messages.PersonalFullNameIsNotEmpty);
        }
    }
}
