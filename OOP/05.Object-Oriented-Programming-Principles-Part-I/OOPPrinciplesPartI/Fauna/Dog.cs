namespace Fauna
{
    using System;

    public class Dog : Animal, ISound
    {
        // --- CONSTRUCTORS --- //
        public Dog(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
        }

        // --- METHODS --- //
        public string AnimalSound()
        {
            return "woof, woof";
        }
    }
}