using SchoolWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolWebAPI.Controllers
{
    public class MarksController : ApiController
    {
        // GET api/values
        StuMarkEntities db = new StuMarkEntities();
        public IEnumerable<StudentMark> Get()
        {
            return db.StudentMarks.ToList();
        }
        public StudentMark Get(int id)
        {
            StudentMark student = db.StudentMarks.Find(id);
            return student;
        }
        public string Post([FromBody]StudentMark student)
        {
            db.StudentMarks.Add(student);
            db.SaveChanges();
            return " Mark Details Added";
        }
        public string Put(int id, [FromBody] StudentMark student)
        {
            var students = db.StudentMarks.Find(id);
            students.StudentName = student.StudentName;
            students.SubjectID = student.SubjectID;
            students.SubjectName = student.SubjectName;
            students.Marks = student.Marks;
            db.Entry(students).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "Marks updated";
        }
        public string Delete(int id)
        {
            StudentMark student = db.StudentMarks.Find(id);
            db.StudentMarks.Remove(student);
            db.SaveChanges();
            return "Deleted Successfully";
        }
    }
}
