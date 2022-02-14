using System;
using FluentValidation;
using Drp.Domain.Models;

namespace Drp.Domain.Validation
{
    public partial class TaskExtendedUpdateModelValidator
        : AbstractValidator<TaskExtendedUpdateModel>
    {
        public TaskExtendedUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Browser).MaximumLength(256);
            RuleFor(p => p.OperatingSystem).MaximumLength(256);
            RuleFor(p => p.CreatedBy).MaximumLength(100);
            RuleFor(p => p.UpdatedBy).MaximumLength(100);
            #endregion
        }

    }
}
