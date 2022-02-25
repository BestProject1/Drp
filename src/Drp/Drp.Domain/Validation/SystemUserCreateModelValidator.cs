using System;
using FluentValidation;
using Drp.Domain.Models;

namespace Drp.Domain.Validation
{
    public partial class SystemUserCreateModelValidator
        : AbstractValidator<SystemUserCreateModel>
    {
        public SystemUserCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Eid).MaximumLength(36);
            RuleFor(p => p.UserName).MaximumLength(50);
            RuleFor(p => p.Pwd).MaximumLength(50);
            RuleFor(p => p.Phone).MaximumLength(20);
            RuleFor(p => p.LoginIp).MaximumLength(30);
            RuleFor(p => p.MenuRights).MaximumLength(150);
            RuleFor(p => p.UserAgent).MaximumLength(500);
            RuleFor(p => p.CreateRoleName).MaximumLength(500);
            RuleFor(p => p.CreateUser).MaximumLength(50);
            #endregion
        }

    }
}
