using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class OverloadBirthday
    {
        List<Person> people = new List<Person>();
        public OverloadBirthday()
        {
            newPeople();
        }
        public void selectAPerson(int personIndex)
        {
            Person newPerson = people[personIndex] + people[personIndex].age;
            Console.Write(newPerson.ToString(1));
            Console.ReadKey();
        }
        public void newPeople()
        {
            people.Add(new Person("Daniel", "Fehrenbach", 23, "05/06/1992"));
            people.Add(new Person("Lindsay", "Taylor", 22, "04/30/1993"));
            people.Add(new Person("Vicki", "Fehrenbach", 55, "04/20/1961"));
            people.Add(new Person("Stan", "Marsh", 8, "05/06/1989"));
            people.Add(new Person("Eric", "Cartman", 8, "04/20/1989"));
            people.Add(new Person("Jesus", "Christ", 2016, "01/25/0"));
            people.Add(new Person("Santa", "Claus", 216, "01/25/1800"));
            people.Add(new Person("Alex", "Fehrenbach", 26, "05/27/1989"));
        }
        public void displayPeople()
        {
            int count = 0;
            foreach (Person person in people)
            {
                Console.Write("{0})", count);
                Console.WriteLine(person.ToString(2));
                count++;
            }
        }
        public int getPerson()
        {
            int personNum;
            Console.WriteLine("Please enter the number representing the person.");
            bool check = int.TryParse(Console.ReadLine(), out personNum);
            if (check) { return personNum; }
            else return getPerson();
        }
    }
}