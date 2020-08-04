using System;
using System.Collections.Generic;

namespace api_from_scratch.Models
{
    public partial class Dogs
    {
        public Dogs()
        {
            Owners = new HashSet<Owners>();
        }

        public int DogsId { get; set; }
        public string DogName { get; set; }
        public string DogBreed { get; set; }
        public int? DogAge { get; set; }
        public string DogSize { get; set; }

        public virtual ICollection<Owners> Owners { get; set; }
    }
}
