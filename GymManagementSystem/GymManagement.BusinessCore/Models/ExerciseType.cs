
using System.Text.Json.Serialization;

namespace GymManagement.BusinessCore.Models
{
    public class ExerciseType : Entity<byte>
    {
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Subscription> Subscriptions { get; set; }

        public ExerciseType(byte id, string name):base(id) 
        {
            Name = name;
        }
    }
}
