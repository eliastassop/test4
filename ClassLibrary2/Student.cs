using System;
using System.Collections.Generic;
using System.Text;

namespace tablesmock
{
    public class Student
    {
        public Int64 Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string FullName { get; set; }

        //nav props
        public ICollection<StudentPoints> StudentPoints { get; set; }
        public IList<StudentParent> Parents { get; set; }

    }
}
