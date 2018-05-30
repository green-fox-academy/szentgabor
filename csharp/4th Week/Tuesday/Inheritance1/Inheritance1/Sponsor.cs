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

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.company = company;
            this.hiredStudents = 0;
        }
        public Sponsor()
        {
            this.company = "Google";
            this.hiredStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine(String.Format($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {company} and hired {hiredStudents} students so far.", Name, Age, Gender, company, hiredStudents));
        }
        
        public void Hire()
        {
            hiredStudents ++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}