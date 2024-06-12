using System;
using System.Collections.Generic;

namespace TimeTableWebApp.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Groups = new HashSet<Group>();
        }

        public int Subid { get; set; }
        public string Subname { get; set; } = null!;

        public virtual ICollection<Group> Groups { get; set; }
    }
}
