using System;
using System.Collections.Generic;

namespace TimeTableWebApp.Models
{
    public partial class Session
    {
        public int Sesid { get; set; }
        public int Gid { get; set; }
        public int Rid { get; set; }
        public DateTime Date { get; set; }
        public int Tid { get; set; }
        public int Index { get; set; }
        public int Lid { get; set; }
        public bool? Attanded { get; set; }

        public virtual Group Group { get; set; } = null!;
        public virtual Lecturer Lecturer { get; set; } = null!;
        public virtual Room Room { get; set; } = null!;
        public virtual TimeSlot TimeSlot { get; set; } = null!;
    }
}
