namespace Fauna
{
    using System;

    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age)
            : base(name, age, true)
        {
        }

        public string AnimalSound()
        {
            return "purr";
        }
    }
}