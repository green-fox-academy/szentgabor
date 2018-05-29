using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Students : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Students(string name, int age, string gender, string previousOrganization) :base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            this.skippedDays = 0;
        }
        public Students()
        {
            this.previousOrganization = "The School of Life";
            this.skippedDays = 0;
        }
        public override string GetGoal()
        {
            return "Be a junior software developer.";
        }
        public override string Introduce()
        {
            String.Format("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.", Name, Age, Gender, previousOrganization, skippedDays);
        }
        public int SkipDays(int numberOfDays)
        {
            return numberOfDays + skippedDays;
        }
    }
}