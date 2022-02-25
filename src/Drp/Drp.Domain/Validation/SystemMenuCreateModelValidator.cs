using System;
using FluentValidation;
using Drp.Domain.Models;

namespace Drp.Domain.Validation
{
    public partial class SystemMenuCreateModelValidator
        : AbstractValidator<SystemMenuCreateModel>
    {
        public SystemMenuCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).MaximumLength(50);
            RuleFor(p => p.Ico).MaximumLength(100);
            RuleFor(p => p.Url).MaximumLength(200);
            RuleFor(p => p.Class).MaximumLength(100);
            #endregion
        }

    }
}
