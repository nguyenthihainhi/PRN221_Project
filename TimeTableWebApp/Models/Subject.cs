using System;
using System.Collections.Generic;

namespace TimeTableWebApp.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Classes = new HashSet<Class>();
        }

        public int Subid { get; set; }
        public string Subname { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; set; }
    }
}
