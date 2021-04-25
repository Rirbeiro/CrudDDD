using CrudDDD.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudDDD.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Entre com o nome.")
                .NotNull().WithMessage("Entre com o nome.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Entre com o e-mail.")
                .EmailAddress().WithMessage("Entre com o e-mail valido.")
                .NotNull().WithMessage("Entre com o e-mail.");

            RuleFor(c => c.Password)
                .NotEmpty().WithMessage("Entre com o password.")
                .NotNull().WithMessage("Entre com o password.");
        }
    }
}
