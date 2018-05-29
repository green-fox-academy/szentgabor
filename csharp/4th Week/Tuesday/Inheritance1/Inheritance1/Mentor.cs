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
            this.level = level;
        }
        public Mentor()
        {
            this.level = "intermediate";
        }

        public override string GetGoal()
        {
            return "Educate brilliant Be a junior software developer.";
        }
        public override string Introduce()  
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2} {3} mentor.", Name, Age, Gender, level);
        }
        /*
        level: the level of the mentor (junior / intermediate / senior)
    methods:
        Introduce(): "Hi, I'm name, a age year old gender level mentor."
         */
    }
}
