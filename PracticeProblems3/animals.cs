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
        public string breed;
        public int age;
        public int animalType;
        public Animals(string name, int animalType, string breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.animalType = animalType;
        }
    }
}
