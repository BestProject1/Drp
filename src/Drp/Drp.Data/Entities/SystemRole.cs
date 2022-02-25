using Drp.Data.Definitions;
using System;
using System.Collections.Generic;

namespace Drp.Data.Entities
{
    public partial class SystemRole : IHaveIdentifier
    {
        public SystemRole()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public DateTime DataChangeLastTime { get; set; }

        public bool IsActive { get; set; }

        public string MenuRights { get; set; }

        public string ActionList { get; set; }

        public string CreateUser { get; set; }

        public long CreateRoleId { get; set; }

        public string RoleName { get; set; }

        public string Description { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
