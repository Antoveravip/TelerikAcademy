namespace Fauna
{
    using System;

    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
        }

        public string AnimalSound()
        {
            return "miaou";
        }
    }
}