using System;
using System.Collections.Generic;

namespace TimeTableWebApp.Models
{
    public partial class Class
    {
        public Class()
        {
            Groups = new HashSet<Group>();
        }

        public int Cid { get; set; }
        public string Cname { get; set; } = null!;

        public virtual ICollection<Group> Groups { get; set; }
    }
}
