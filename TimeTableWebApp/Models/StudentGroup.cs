using System;
using System.Collections.Generic;

namespace TimeTableWebApp.Models
{
    public partial class StudentGroup
    {
        public int Stid { get; set; }
        public int Gid { get; set; }

        public virtual Group Group { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
