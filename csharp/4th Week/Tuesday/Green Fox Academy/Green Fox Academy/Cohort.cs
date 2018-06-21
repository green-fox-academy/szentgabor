using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Academy
{
    class Cohort
    {
        string name;
        List<Student> students = new List<Student>();
        List<Mentor> mentors = new List<Mentor>();

        public Cohort(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"The {name} cohort has {students.Count()} students and {mentors.Count()} mentors.");
        }
    }
}
