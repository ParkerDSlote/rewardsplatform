﻿// TODO: Copyright

namespace Planet.Dashboard.Rewards.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// Refer documentation for details : https://docs.google.com/document/d/1ZSCsIiMyTydRYW9p0uYF0yrWoHJ8WB9flHt9pB9NRZQ/edit
    /// </summary>
    public class User : Entity
    {
        public override string PartitionId
        {
            get
            {
                return this.Id;
            }

            set
            {
            }
        }

        public override EntityType EntityType
        {
            get
            {
                return EntityType.User;
            }
            set
            {
            }
        }

        public IList<CauseEnrolled> Causes
        {
            get;
            set;
        }
    }
}