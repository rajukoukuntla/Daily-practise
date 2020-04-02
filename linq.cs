using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class linq
    {
        class student
        {
            public int studentid { get; set; }
            public string studentname { get; set; }
            public int age { get; set; }
            public int standardid { get; set; } 
        }

        class standard
        {
            public int standardid { get; set; }
            public string standardname { get; set; }
        }


      

        static void main(string[] args)
        {
            student[] students = {
                               
                               new student() {studentid = 1,studentname="uday",age=20},
                               new student() {studentid = 2,studentname="uday",age=21},
                               new student() {studentid = 3,studentname="uday",age=22},
                               new student() {studentid = 4,studentname="uday",age=23}
                               };

            student[] stu = students.Where(s => s.studentid > 2).ToArray();
            student bill = students.Where(s => s.studentname == "").FirstOrDefault();
            //oftype

            var sftype = from s in students.OfType<string>() select s;
            var ss = from s in students orderby s.studentname descending select s;
            var thenby = students.OrderBy(s => s.studentname).ThenBy(s => s.age);
            
        }

        public static void das ()
        {
            IList<string> stringlist = new List<string>() { "a", "b" };

            //query method with where
            var stu = from s in stringlist where s.Contains("a") select s;
            var sti = stringlist.Where(s => s.Contains("a"));
        }

        public static void testinsert()
        {

            var studentnamefirst = "";
            var studentidfirst = "";


            IList<student> studentlist = new List<student>()
            {
                new student{studentname="raju",studentid=Convert.ToInt32(studentidfirst)}
            };

            var strin = from s in studentlist where s.studentid == 4 where s.studentname == "" select s.studentname;
            student studentl = studentlist.Where(s => s.studentid == 4).FirstOrDefault();
            student[] studentd = studentlist.Where(s => s.studentid > 4 && s.studentid < 2).ToArray();
            var studentde = studentlist.Where(s => s.studentid > 4 && s.studentid < 2);
        }

        public static void join()
        {
            List<student> studentlists = new List<student>();
            List<standard> standardlidt = new List<standard>();
            var join = studentlists.Join(standardlidt, student => student.standardid, standard => standard.standardid, (student, standard) => new { });
        }

    }
}
