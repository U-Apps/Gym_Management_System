
using System.Text.Json.Serialization;

namespace GymManagement.BusinessCore.Models
{
    public class ExerciseType
    {
        
        public byte ExerciseTypeId { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
