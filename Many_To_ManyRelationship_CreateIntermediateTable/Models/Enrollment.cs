﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_To_ManyRelationship_CreateIntermediateTable.Models
{
    public class Enrollment
    {
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public int Mark { get; set; }
    }
}
