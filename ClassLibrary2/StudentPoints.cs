using System;
using System.Collections.Generic;
using System.Text;

namespace tablesmock
{
    public class StudentPoints
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public float GeoX { get; set; }
        public float GeoY { get; set; }

        //nav props

        public Int64 StudentId { get; set; }
        public Student Student { get; set; }
    }
}
