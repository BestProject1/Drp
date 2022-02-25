using System;
using FluentValidation;
using Drp.Domain.Models;

namespace Drp.Domain.Validation
{
    public partial class SystemRoleUpdateModelValidator
        : AbstractValidator<SystemRoleUpdateModel>
    {
        public SystemRoleUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MenuRights).MaximumLength(150);
            RuleFor(p => p.CreateUser).MaximumLength(20);
            RuleFor(p => p.RoleName).MaximumLength(100);
            RuleFor(p => p.Description).MaximumLength(200);
            #endregion
        }

    }
}
