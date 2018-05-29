using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Cohort
    {
        private string name;
        private List<Student> students;
        private List<Mentor> mentors;

        public Cohort(string name, List<Student> students, List<Mentor> mentors)
        {
            this.name = name;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public void addMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public string info()
        {
            return $"The {name}\n cohort has {students.Count}\n students and {mentors.Count}\n mentors.";
        }
    }
}
