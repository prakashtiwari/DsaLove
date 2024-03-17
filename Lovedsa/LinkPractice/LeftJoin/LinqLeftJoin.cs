using System.Collections.Generic;
using System.Linq;

namespace LinkPractice.LeftJoin
{
    public class LinqLeftJoin
    {

        public List<StudentDetail> GetStudentDetail()
        {

            List<Student> students = new List<Student>();
            List<Dept> depts = new List<Dept>();

            depts.Add(new Dept { Id = 1, Name = "Science" });

            students.Add(new Student() { Name = "Prakash", Id = 1, DeptId = 1 });
            students.Add(new Student() { Name = "Ishan", DeptId = 1, Id = 2 });
            students.Add(new Student() { Name = "Beti", Id = 2 });

            var res = (from s in students
                      join de in depts on s.DeptId equals de.Id into temp
                      from d in temp.DefaultIfEmpty()
                      select new StudentDetail
                      {
                          DeptName=d== null?string.Empty:d.Name,
                          Id=s.Id,
                          Name=s.Name
                      }).ToList();
            return res;
        }

    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int DeptId { get; set; }
    }

    public class Dept
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class StudentDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DeptName { get; set; }
    }
}
