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

        Cohort(name) : public Cohort(string cohortname, List<Student> students, List<Mentor> mentors)
        {
            this.name = cohortname;
            this.students = students;
            this.mentors = mentors;
        }

Create a Cohort class that has the following fields:
        name: the name of the cohort
        students: a list of Students
        mentors: a list of Mentors
    methods:
        addStudent(Student) : adds the given Student to students list
         addMentor(Mentor): adds the given Mentor to mentors list
         info(): prints out "The name cohort has students.size() students and mentors.size() mentors."

The Cohort class has the following constructors:

        beside the given parameter, it sets students and mentors as empty lists

    }
}
