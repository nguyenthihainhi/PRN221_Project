using System;
using System.Collections.Generic;

namespace TimeTableWebApp.Models
{
    public partial class Attandance
    {
        public int Sesid { get; set; }
        public int Stid { get; set; }
        public bool Present { get; set; }
        public string Description { get; set; } = null!;
        public DateTime? RecordTime { get; set; }

        public virtual Session Session { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
