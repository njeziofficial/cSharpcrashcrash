using CrashCourseWeb.CQRS.Commands;
using CrashCourseWeb.Helpers;
using CrashCourseWeb.Models;
using FluentValidation;

namespace CrashCourseWeb.Validations;

public class StudentValidator : AbstractValidator<CreateStudentCommand>
{
    public StudentValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("First name can not be empty")
            .NotNull().WithMessage("First name can not be null")
            .Length(25).WithMessage("First name has exceeded max length allowed")
            .Must(p => StringHelper.IsAlphabelts(p)).WithMessage("An unaccepted character is present");

        RuleFor(x => x.LastName)
           .NotEmpty().WithMessage("Last name can not be empty")
           .NotNull().WithMessage("Last name can not be null")
           .Length(25).WithMessage("Last name has exceeded max length allowed")
           .Must(p => StringHelper.IsAlphabelts(p)).WithMessage("An unaccepted character is present");

        RuleFor(x => x.Username)
          .NotEmpty().WithMessage("User name can not be empty")
          .NotNull().WithMessage("User name can not be null")
          .Length(25).WithMessage("User name has exceeded max length allowed")
          .Must(p => StringHelper.IsAlphabelts(p)).WithMessage("An unaccepted character is present");

        RuleFor(x => x.Tel)
            .NotEmpty()
            .NotNull()
            .Length(11)
            .Must(p => StringHelper.IsNumbers(p));

        RuleFor(x => x.Email)
            .NotEmpty()
            .NotNull()
            .Must(p => StringHelper.IsValidEmail(p));
    }
}
