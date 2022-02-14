using System;
using FluentValidation;
using Drp.Domain.Models;

namespace Drp.Domain.Validation
{
    public partial class StatusCreateModelValidator
        : AbstractValidator<StatusCreateModel>
    {
        public StatusCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MaximumLength(100);
            RuleFor(p => p.Description).MaximumLength(255);
            RuleFor(p => p.CreatedBy).MaximumLength(100);
            RuleFor(p => p.UpdatedBy).MaximumLength(100);
            #endregion
        }

    }
}
