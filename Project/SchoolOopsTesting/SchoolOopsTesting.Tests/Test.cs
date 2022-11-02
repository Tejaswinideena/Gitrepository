using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolOopsTesting;
using NUnit.Framework;


namespace SchoolOopsTesting.Tests
{
    [TestFixture]
    public class Test
    {
        [TestCase]
        public void Test1()
        {
            student s = new student();
            s.student_id = 1;
            s.student_name = "ram";
            Assert.AreEqual(s.student_id, 1);
        }
        [TestCase]
        public void Test2()
        {
            subject s = new subject();
            s.subject_id = 101;
            s.subject_name = "physics";
            s.subject_marks = 95;
            Assert.AreEqual(s.subject_marks, 95);
        }
        [TestCase]
        public void Test3()
        {
            teacher s = new teacher();
            s.teacher_id = 12;
            s.teacher_name = "raj";
            Assert.AreEqual(s.teacher_name, "raj");
        }

    }
}

