using System;
using System.Collections.Generic;
using System.Text;

namespace tablesmock
{
    public class StudentParent
    {
       
        public Int64 StudentId { get; set; }
        public Student Student { get; set; }
        public Int64 ParentId { get; set; }
        public Parent Parent { get; set; }
    }
}
