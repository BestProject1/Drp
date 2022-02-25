using System;
using FluentValidation;
using Drp.Domain.Models;

namespace Drp.Domain.Validation
{
    public partial class SystemPageActionCreateModelValidator
        : AbstractValidator<SystemPageActionCreateModel>
    {
        public SystemPageActionCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ActionId).MaximumLength(100);
            RuleFor(p => p.ActionName).MaximumLength(255);
            RuleFor(p => p.ControlName).MaximumLength(255);
            #endregion
        }

    }
}
