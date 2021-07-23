﻿using FluentValidation;
using GenericApi.Bl.Dto;

namespace GenericApi.Bl.Validations
{
    public class WorkShopMemberValidator : AbstractValidator<WorkShopMemberDto>
    {
        public WorkShopMemberValidator()
        {
            RuleFor(x => x.Role)
                .NotEmpty()
                .WithMessage("WorkShopMember's Role is required");
            RuleFor(x => x.WorkShopId)
                .NotEmpty()
                .WithMessage("WorkShopMember's WorkShopId is required");
            RuleFor(x => x.MemberId)
                .NotEmpty()
                .WithMessage("WorkShopMember's MemberId is required");

        }
    }
}
