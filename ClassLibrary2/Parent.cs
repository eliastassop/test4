using System;
using System.Collections.Generic;
using System.Text;

namespace tablesmock
{
    public class Parent
    {
       

        public Int64 Id { get; set; }
        public string ParentName { get; set; }
        public int Phone { get; set; }

        public virtual IList<StudentParent> Students { get; set; }
    }
}
