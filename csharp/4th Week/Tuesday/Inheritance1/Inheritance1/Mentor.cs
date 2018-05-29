using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Mentor : Person
    {
        private string level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            this.skippedDays = 0;
        }
        public Students()
        {
            this.previousOrganization = "The School of Life";
            this.skippedDays = 0;
        }
        /*
        level: the level of the mentor (junior / intermediate / senior)
    methods:
        GetGoal(): prints out "Educate brilliant junior software developers."
        Introduce(): "Hi, I'm name, a age year old gender level mentor."

The Mentor class has the following constructors:

    Mentor(name, age, gender, level)
    Mentor(): sets name to Jane Doe, age to 30, gender to female, level to intermediate

         */
    }
}
