using System;
using System.Collections.Generic;

namespace Jym_Management_DataAccessLayer.Entities
{
    public partial class TbSubscription
    {
        public int SubscriptionId { get; set; }
        public int MemberId { get; set; }
        public int CoachId { get; set; }
        public int CreatedByReceptionistId { get; set; }
        public byte ExcerciseTypeId { get; set; }
        public byte PeriodId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte SubscriptionPeriodId { get; set; }

        public virtual TbJobHistory Coach { get; set; } = null!;
        public virtual TbJobHistory CreatedByReceptionist { get; set; } = null!;
        public virtual TbExerciseType ExcerciseType { get; set; } = null!;
        public virtual TbMember Member { get; set; } = null!;
        public virtual TbPeriod Period { get; set; } = null!;
        public virtual TbSubsciptionPeriod SubscriptionPeriod { get; set; } = null!;
    }
}
