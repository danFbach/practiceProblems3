using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class Animals
    {
        public string name;
        public Enum breed;
        public int age;
        public Animals(string name, Enum breed, int age)
        {
            this.breed = breed;
            this.name = name;            
            this.age = age;
        }
        public override string ToString()
        {
            return String.Format("Pet Name:{0}, Age:{1}, Breed:{2}", name, age, breed);
        }
    }
}
