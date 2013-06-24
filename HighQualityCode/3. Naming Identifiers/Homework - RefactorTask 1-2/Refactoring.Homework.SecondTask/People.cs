namespace Refactoring.Homework.SecondTask
{
    using System;

    // I try to keep the humorous kind of this code.
    public class People
    {
        public enum Gender
        {
            UltraBigBrother,
            CoolChick
        }

        public void CreatePerson(int magicalPersonNumber)
        {
            Person newHuman = new Person();
            newHuman.Age = magicalPersonNumber;

            if (magicalPersonNumber % 2 == 0)
            {
                newHuman.Name = "BigBrother";
                newHuman.Sex = Gender.UltraBigBrother;
            }
            else
            {
                newHuman.Name = "Chick";
                newHuman.Sex = Gender.CoolChick;
            }
        }

        public class Person
        {
            public Gender Sex { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}