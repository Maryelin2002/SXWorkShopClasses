﻿using FluentValidation;
using GenericApi.Bl.Dto;

namespace GenericApi.Bl.Validations
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Member's Name is required");
            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Member's LastName is required");
            RuleFor(x => x.DocumentType)
                .NotEmpty()
                .WithMessage("Member's DocumentType is required");
            RuleFor(x => x.Gender)
                .NotEmpty()
                .WithMessage("Member's Gender is required");
            RuleFor(x => x.PhotoFileName)
                .NotEmpty()
                .WithMessage("Member's PhotoFileName is required");
        }
    }
}
