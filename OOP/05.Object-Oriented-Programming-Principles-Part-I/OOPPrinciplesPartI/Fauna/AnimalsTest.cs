namespace Fauna
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnimalsTest
    {
        static void Main()
        {
            //Creating arrays of different kinds of animals
            ISound[] animalsSounds = new ISound[]
            {
                new Dog("Sharo", 3, true),
                new Frog("Prince", 1, true),
                new Kitten("Little Miss", 1, false),
                new Dog("Richi", 1, true),
                new Frog("Pauper", 2, false),
                new Tomcat("Tom", 7),
                new Dog("Billy", 8, true),
                new Frog("Greeny", 3, false),
                new Kitten("Cleo", 1, false),
            };
            
            foreach (ISound animalSound in animalsSounds)
            {
                Console.WriteLine("{0} sound: {1}", Animal.AnimalType(animalSound.AnimalSound()), animalSound.AnimalSound());
            }

            //Creating arrays of different kinds of animals
            Animal[] animals = new Animal[]
            {
                new Dog("Sharo", 3, true),
                new Frog("Prince", 1, true),
                new Kitten("Little Miss", 1, false),
                new Dog("Richi", 1, true),
                new Frog("Pauper", 2, false),
                new Tomcat("Tom", 7),
                new Dog("Billy", 8, true),
                new Frog("Greeny", 3, false),
                new Kitten("Cleo", 1, false),
            };

            decimal averageAge = Animal.AverageAge(animals);
            Console.WriteLine("Average age: {0:F2}", averageAge);

            var averageAges = AverageAges(animals);
            foreach (var age in averageAges)
            {
                Console.WriteLine("Animal: {0}, Average Age: {1:F2}", age.Item1, age.Item2);
            }
        }

        //Calculating the average age of each kind of animal using a static method with LINQ
        private static IEnumerable<Tuple<string, double>> AverageAges(Animal[] animals)
        {
            var averageAges =
                from animal in animals
                group animal by animal.GetType() into animalType
                select new Tuple<string, double>(animalType.Key.Name, animalType.Average(a => a.Age));

            return averageAges;
        }
    }
}