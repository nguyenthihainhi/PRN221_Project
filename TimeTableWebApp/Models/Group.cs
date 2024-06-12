using System;
using System.Collections.Generic;

namespace TimeTableWebApp.Models
{
    public partial class Group
    {
        public Group()
        {
            Sessions = new HashSet<Session>();
        }

        public int Gid { get; set; }
        public int Cid { get; set; }
        public int Subid { get; set; }

        public virtual Class Class { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
