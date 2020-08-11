using System;
using System.Collections.Generic;
using System.Text;

namespace football_from_scratch_core.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerPosition { get; set; }
        public int? PlayerAge { get; set; }
        public string TeamName { get; set; }
    }
}
