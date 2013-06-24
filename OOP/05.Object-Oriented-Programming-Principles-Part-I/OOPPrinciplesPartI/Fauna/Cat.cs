namespace Fauna
{
    using System;

    public class Cat : Animal, ISound
    {
        // --- CONSTRUCTORS --- //
        protected Cat(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
        }

        // --- METHODS --- //
        public string AnimalSound()
        {
            return "meau";
        }
    }
}