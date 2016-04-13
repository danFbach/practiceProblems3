using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public string birthday;
        public Person(string firstName, string lastName, int age, string birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.birthday = birthday;
        }
        public static Person operator +(Person person, int age)
        {
            person.age = age + 12;
            return person;
        }
        public string ToString(int whatever)
        {
            if (whatever == 1)
            {
                return (String.Format("Person: {0} {1} || Age: {2}", firstName, lastName, this.age));
            }
            else if (whatever == 2)
            {
                return (String.Format("Person: {0} {1} || Age: {2} || Birthday: {3}", firstName, lastName, this.age, birthday));
            }
            else return String.Format(firstName);
                
        }

    }
}
