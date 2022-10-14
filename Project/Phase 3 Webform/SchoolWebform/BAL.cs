using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolWebform
{
    public class ClassBAL
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
    }
    public class StudentsBAL
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int ClassID { get; set; }
    }
    public class SubjectsBAL
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int ClassID { get; set; }
    }
}


