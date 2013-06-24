namespace Fauna
{
    using System;
    using System.Collections.Generic;

    public abstract class Animal
    {
        // --- FIELDS --- //
        private string name;
        private int age;
        private bool isMale;

        // --- PROPERTIES --- //
        public string Name
        {
            get { return name; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name must be proper inputed. Can't be empty!");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            protected set
            {
                if (value <= 0) //No upper limit - there is representatives of the animal kingdom who are immortal!
                {
                    throw new ArgumentException("Age must be in proper range!");
                }
                age = value;
            }
        }

        public bool IsMale
        {
            get { return isMale; }
            protected set
            {
                isMale = value;
            }
        }

        // --- CONSTRUCTORS --- //
        protected Animal(string name, int age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }

        // --- METHODS --- //
        public override string ToString()
        {
            return String.Format("{0}: name = {1}, age = {2}, sex = {3}",
                this.GetType().Name, this.Name, this.Age, this.IsMale ? "male" : "female");
        }

        public static Type AnimalType(string sound)
        {
            switch (sound)
            {
                case "woof, woof": { return typeof(Dog); }
                case "ribbit, ribbit": { return typeof(Frog); }
                case "miaou": { return typeof(Kitten); }
                case "purr": { return typeof(Tomcat); }
                default: { return typeof(Animal); }
            }
        }
       
        public static decimal AverageAge(IEnumerable<Animal> data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("Not correct data!");
            }

            decimal sum = 0;
            long count = 0L;

            foreach (Animal animal in data)
            {
                sum += animal.Age;
                count++;
            }

            if (count == 0L)
            {
                throw new InvalidOperationException("Sequence of animals contains no elements.");
            }
            else
            {
                return sum / count;
            }
        }
    }
}