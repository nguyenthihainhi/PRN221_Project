using System;
using System.Collections.Generic;

namespace TimeTableWebApp.Models
{
    public partial class Class
    {
        public Class()
        {
            Sessions = new HashSet<Session>();
            StudentClasses = new HashSet<StudentClass>();
        }

        public int Cid { get; set; }
        public string Cname { get; set; } = null!;
        public int Subid { get; set; }
        public int Lid { get; set; }
        public string Sem { get; set; } = null!;
        public int Year { get; set; }

        public virtual Lecturer Lecturer { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
