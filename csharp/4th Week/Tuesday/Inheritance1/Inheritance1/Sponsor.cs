using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor(string name, int age, string gender, string level, string company) : base(name, age, gender)
        {
            this.company = company;
            this.hiredStudents = 0;
        }
        public Sponsor()
        {
            this.company = "Google";
            this.hiredStudents = 0;
        }

        public override string Introduce()
        {
            return String.Format($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {company} and hired {hiredStudents} students so far.", Name, Age, Gender, company, hiredStudents);
        }
        
        public void Hire(int NumberOfHiredStudents);
        {
            hiredStudents += NumberOfHiredStudents;
        }

        public override string GetGoal()
        {
            return "Hire brilliant junior software developers.";
        }
    }
}