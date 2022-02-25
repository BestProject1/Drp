using Drp.Data.Definitions;
using System;
using System.Collections.Generic;

namespace Drp.Data.Entities
{
    public partial class SystemPageAction : IHaveIdentifier
    {
        public SystemPageAction()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public DateTime DataChangeLastTime { get; set; }

        public long MenuId { get; set; }

        public string ActionId { get; set; }

        public string ActionName { get; set; }

        public string ControlName { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
