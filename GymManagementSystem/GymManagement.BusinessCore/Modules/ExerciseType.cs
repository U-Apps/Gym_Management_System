using System;
using System.Collections.Generic;

namespace GymManagement.BussinessCore.Modules
{
    public class ExerciseType
    {
        
        public byte ExerciseTypeId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
