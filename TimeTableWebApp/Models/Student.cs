using System;
using System.Collections.Generic;

namespace TimeTableWebApp.Models
{
    public partial class Student
    {
        public int Stid { get; set; }
        public string Stname { get; set; } = null!;
        public string? Displayname { get; set; }
    }
}
