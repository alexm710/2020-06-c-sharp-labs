using System;
using System.Collections.Generic;

namespace dog_owner_entity_first_code_api.Models
{
    public partial class Owners
    {
        public Owners()
        {
            Dogs = new HashSet<Dogs>();
        }

        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public int? OwnerAge { get; set; }

        public virtual ICollection<Dogs> Dogs { get; set; }
    }
}
