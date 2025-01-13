using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.BusinessCore.Models
{
    public abstract class Entity<TKey>
    {
        public TKey Id { get; protected set; }

        protected Entity(TKey id)
        {
            Id = id;
        }
    }
}
