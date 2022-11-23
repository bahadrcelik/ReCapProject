using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserFirstName).NotEmpty();
            RuleFor(u => u.UserFirstName).MinimumLength(5);
            RuleFor(u => u.UserLastName).NotEmpty();
            RuleFor(u => u.UserLastName).MinimumLength(5);
            RuleFor(u => u.Passaword).NotEmpty();
            //RuleFor(u => u.Passaword).Must(StartWithUppercaseLetter).WithMessage("Şifre büyük harfla başlamalı.");
            RuleFor(u => u.UserEmail).NotEmpty();
        }

        
    }
}
