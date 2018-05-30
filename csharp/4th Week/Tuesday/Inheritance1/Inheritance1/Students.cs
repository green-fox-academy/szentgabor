using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Student : Person, ICloneable
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization) :base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            this.skippedDays = 0;
        }
        public Student()
        {
            previousOrganization = "The School of Life";
            this.skippedDays = 0;
        }
        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }
        public override void Introduce()
        {
            Console.WriteLine(String.Format("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.", Name, Age, Gender, previousOrganization, skippedDays));
        }
        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }

        public object Clone()
        {
            return new Student(this.Name, this.Age, this.Gender, this.previousOrganization);
        }
    }
}