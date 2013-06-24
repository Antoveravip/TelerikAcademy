namespace School
{
    using System;
    using System.Collections.Generic;

    public static class School
    {
        // --- FIELDS --- //
        private static string schoolID;
        private static List<Class> classes;
        private static List<Discipline> disciplines;
        private static List<Teacher> teachers;
        private static List<Student> students;

        // --- PROPERTIES --- //
        public static string SchoolID
        {
            get { return schoolID; }
            set { schoolID = value; }
        }

        public static List<Class> Classes
        {
            get { return classes; }
            set { classes = value; }
        }

        public static List<Discipline> Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }

        public static List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }

        public static List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public static void AddClass(Class newClass)
        {
            if (classes.Contains(newClass))
            {
                throw new ArgumentException("Such class already exists!");
            }
            classes.Add(newClass);
        }

        public static void RemoveClass(Class oldClass)
        {
            if (classes.Contains(oldClass))
            {
                classes.Remove(oldClass);
            }
            else
            {
                throw new ArgumentNullException("There is no such class!");
            }
        }

        static void Main()
        {

        }
    }
}