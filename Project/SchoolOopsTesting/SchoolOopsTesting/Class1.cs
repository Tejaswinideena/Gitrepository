using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOopsTesting
{
    public class student
    {
        public int student_id { get; set; }
        public string student_name { get; set; }
    }
    public class subject
    {
        public int subject_id { get; set; }
        public string subject_name { get; set; }
        public int subject_marks { get; set; }
    }
    public class teacher
    {
        public int teacher_id { get; set; }
        public string teacher_name { get; set; }
    }
}
