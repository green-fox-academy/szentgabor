using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Academy
{
    class Sponsor : Person
    {
        private string company;
        public int hiredStudents = 0;

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.company = company;
        }

        public Sponsor() : base()
        {
            company = "Google";
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender} who represents {company} and hired {hiredStudents} students so far.");
        }

        public void Hire()
        {
            hiredStudents++;
        }
    }
}
