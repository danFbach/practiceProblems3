using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3
{
    public class HumaneSociety
    {
        enum animalTypes{dog, cat, birds, rabbits};
        List<Animals> animalList = new List<Animals>();
        public void addAnimals()
        {

            animalList.Add(new Animals("Poppy",0,"labrador",4));
            animalList.Add(new Animals("Sparky", 0, "South Parkian", 3));
            animalList.Add(new Animals("Flappy", 2, "Parakeet", 6));
            animalList.Add(new Animals("Bugs Bunny", 3, "Droopy Ears", 3));
            animalList.Add(new Animals("Tweetie", 2, "Canary", 50));
            animalList.Add(new Animals("Hopper", 3, "Super Hop", 5));
            animalList.Add(new Animals("Killer", 0, "German Sheppard", 4));
            animalList.Add(new Animals("Fluff", 0, "Chow Chow", 5));
            animalList.Add(new Animals("Jack", 2, "Parrot", 6));
        }
    }
}
//-    Problem 2: The humane society needs a way to keep track of the different breeds of dogs, cats, rabbits, and birds that are housed. Use an enum to categorize the different breeds of the various animals. Make sure to print to the console the Name, Age and Breed of each animal.