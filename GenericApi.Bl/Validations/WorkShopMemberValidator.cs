using FluentValidation;
using GenericApi.Bl.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
