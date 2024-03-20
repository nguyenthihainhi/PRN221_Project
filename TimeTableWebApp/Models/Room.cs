using System;
using System.Collections.Generic;

namespace TimeTableWebApp.Models
{
    public partial class Room
    {
        public Room()
        {
            Sessions = new HashSet<Session>();
        }

        public int Rid { get; set; }
        public string Rname { get; set; } = null!;

        public virtual ICollection<Session> Sessions { get; set; }
    }
}
