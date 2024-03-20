using System;
using System.Collections.Generic;

namespace TimeTableWebApp.Models
{
    public partial class Student
    {
        public Student()
        {
            Attandances = new HashSet<Attandance>();
        }

        public int Stid { get; set; }
        public string Stname { get; set; } = null!;
        public string? Displayname { get; set; }

        public virtual StudentClass? StudentClass { get; set; }
        public virtual ICollection<Attandance> Attandances { get; set; }
    }
}
