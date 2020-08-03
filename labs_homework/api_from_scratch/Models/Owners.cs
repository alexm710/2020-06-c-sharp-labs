using System;
using System.Collections.Generic;

namespace api_from_scratch.Models
{
    public partial class Owners
    {
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public int? OwnerAge { get; set; }
        public int? DogsId { get; set; }

        public virtual Dogs Dogs { get; set; }
    }
}
