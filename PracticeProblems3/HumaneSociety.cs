using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class HumaneSociety
    {
        public HumaneSociety()
        {
            addAnimals();
        }
        public enum Dog { Labrador, SouthParkian, GermanSheppard, Chow };
        public enum Cat { White, Brown, Black };
        public enum Bird { Parakeet, Canary, Parrot };
        public enum Rabbit { Droopy, Hopster };
        List<Animals> animalList = new List<Animals>();
        public void displayAnimals()
        {
            foreach (Animals animal in animalList)
            {
                Console.WriteLine(animal);
            }
            Console.ReadKey();
        }
        public void addAnimals()
        {
            animalList.Add(new Animals("Poppy", Dog.Labrador, 4));
            animalList.Add(new Animals("Sparky", Dog.SouthParkian, 3));
            animalList.Add(new Animals("Mr.Kitty", Cat.Brown, 4));
            animalList.Add(new Animals("Flappy", Bird.Parakeet, 6));
            animalList.Add(new Animals("Bugs Bunny", Rabbit.Droopy, 3));
            animalList.Add(new Animals("KitKat", Cat.Black, 5));
            animalList.Add(new Animals("Tweetie", Bird.Canary, 50));
            animalList.Add(new Animals("Hopper", Rabbit.Hopster, 5));
            animalList.Add(new Animals("John Smith", Cat.White, 7));
            animalList.Add(new Animals("Killer", Dog.GermanSheppard, 4));
            animalList.Add(new Animals("Fluff", Dog.Chow, 5));
            animalList.Add(new Animals("Jack", Bird.Parrot, 6));
        }
    }
}
//-    Problem 2: The humane society needs a way to keep track of the different breeds of dogs, cats, rabbits, and birds that are housed. Use an enum to categorize the different breeds of the various animals. Make sure to print to the console the Name, Age and Breed of each animal.