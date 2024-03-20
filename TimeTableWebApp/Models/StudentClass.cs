using System;
using System.Collections.Generic;

namespace TimeTableWebApp.Models
{
    public partial class StudentClass
    {
        public int Stid { get; set; }
        public int Cid { get; set; }

        public virtual Class Class { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
