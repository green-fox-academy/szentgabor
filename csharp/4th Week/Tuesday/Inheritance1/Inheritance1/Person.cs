using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class Person
    {
        private string name;
        private int age;
        private string gender;

        public Person()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
        }

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
        }

        public virtual string Introduce()
        {
        return String.Format("Hi, I'm {0}, a {1} year old {2}", Name, Age, Gender);
        }

        public virtual string GetGoal()
        {
            return "My goal is: Live for the moment.";
        }
    }
}
