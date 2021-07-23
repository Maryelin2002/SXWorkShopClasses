using FluentValidation;
using GenericApi.Bl.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApi.Bl.Validations
{
    public class MemberValidator : AbstractValidator<MemberDto>
    {
        public MemberValidator()
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
