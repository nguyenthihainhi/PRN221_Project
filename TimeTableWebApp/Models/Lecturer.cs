﻿using System;
using System.Collections.Generic;

namespace TimeTableWebApp.Models
{
    public partial class Lecturer
    {
        public Lecturer()
        {
            Sessions = new HashSet<Session>();
        }

        public int Lid { get; set; }
        public string Lname { get; set; } = null!;
        public string? Displayname { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}
