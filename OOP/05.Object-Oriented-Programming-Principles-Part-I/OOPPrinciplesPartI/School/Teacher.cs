namespace School
{
    using System;
    using System.Collections.Generic;

    public class Teacher :Person
    {
        // --- FIELDS --- //
        private List<Discipline> disciplines;

        // --- PROPERTIES --- //
        public List<Discipline> Disciplines
        {
            get
            {
                if (this.disciplines.Count == 0)
                {
                    throw new ArgumentNullException("There is no such discipline!");
                }
                return this.disciplines;
            }
        }

        // --- CONSTRUCTORS --- //
        public Teacher(string firstName, string lastName)
            :base(firstName, lastName, null)
        { 
        }

        public Teacher(string firstName, string lastName, List<Discipline> disciplines)
            : this(firstName, lastName, null, disciplines)
        { 
        }

        public Teacher(string firstName, string lastName, string comments, List<Discipline> disciplines)
            : base(firstName, lastName, comments)
        {
            this.disciplines = disciplines;
        }

        // --- METHODS --- //
        public void AddDiscipline(Discipline discipline)
        {
            if (disciplines.Contains(discipline))
            {
                throw new ArgumentException("Such discipline already exists!");
            }
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            if (disciplines.Contains(discipline))
            {
                this.disciplines.Remove(discipline);
            }
            else
            {
                throw new ArgumentNullException("There is no such discipline!");
            }            
        }
    }
}