namespace Fauna
{
    using System;

    public class Frog : Animal, ISound
    {
        // --- CONSTRUCTORS --- //
        public Frog(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
        }

        // --- METHODS --- //
        public string AnimalSound()
        {
            return "ribbit, ribbit";
        }
    }
}