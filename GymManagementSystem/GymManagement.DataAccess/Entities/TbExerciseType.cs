using System;
using System.Collections.Generic;

namespace GymManagement.DataAccess.Entities
{
    public partial class TbExerciseType
    {
        public TbExerciseType()
        {
            TbSubscriptions = new HashSet<TbSubscription>();
        }

        public byte ExerciseTypeId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<TbSubscription> TbSubscriptions { get; set; }
    }
}
