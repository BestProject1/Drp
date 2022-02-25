using System;
using FluentValidation;
using Drp.Domain.Models;

namespace Drp.Domain.Validation
{
    public partial class SystemPageActionUpdateModelValidator
        : AbstractValidator<SystemPageActionUpdateModel>
    {
        public SystemPageActionUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ActionId).MaximumLength(100);
            RuleFor(p => p.ActionName).MaximumLength(255);
            RuleFor(p => p.ControlName).MaximumLength(255);
            #endregion
        }

    }
}
