using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2LabLast.Animals
{
    public /* abstract */ class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public string MakeSound()
        {
            return this.Sound;
        }
    }

    //public class Bear : Animal, IAnimal
    //{
        
    //}

    //public class Eagle : Animal, IAnimal
    //{

    //}

    //public class Chicken : Animal, IAnimal
    //{

    //}

    public class AnimalUtility
    {
        public static void DoSomething(Animal newAnimal)
        {
            Console.WriteLine(newAnimal.Name);
            Console.WriteLine(newAnimal.Sound);
        }
    }
}
