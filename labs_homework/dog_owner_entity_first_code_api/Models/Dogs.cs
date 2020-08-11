using System;
using System.Collections.Generic;

namespace dog_owner_entity_first_code_api.Models
{
    public partial class Dogs
    {
        public int DogsId { get; set; }
        public string DogName { get; set; }
        public string DogBreed { get; set; }
        public int? DogAge { get; set; }
        public string DogSize { get; set; }
        public int? OwnerId { get; set; }

        public virtual Owners Owner { get; set; }
    }
}
