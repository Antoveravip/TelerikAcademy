namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string otherInfo;

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Student's first name can't be empty or null!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Student's first name is too short! It should be at least 2 letters!");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Student's first name is too long! It should be maximum 50 letters!");
                }

                foreach (char symbol in value)
                {
                    if (char.IsLetter(symbol) || symbol == '-')
                    {
                        this.firstName = value;
                    }
                    else
	                {
                        throw new FormatException("Invalid first name! Allowed symbols are only letters and hyphen!");
	                }
                }                
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Student's last name can't be empty or null!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Student's last name is too short! It should be at least 2 letters!");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Student's last name is too long! It should be maximum 50 letters!");
                }

                foreach (char symbol in value)
                {
                    if (char.IsLetter(symbol) || symbol == '-')
                    {
                        this.lastName = value;
                    }
                    else
                    {
                        throw new FormatException("Invalid last name! Allowed symbols are only letters and hyphen!");
                    }
                }
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Provided student's info can't be empty or null!");
                }
                this.otherInfo = value;
            }
        }

        public Student()
        {
        }

        public Student(string firstName, string lastName, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = otherInfo;
        }

        private bool HaveBirthDateInfo(string otherInfo)
        {
            DateTime data;
            bool foundBirthDateInfo = DateTime.TryParse((this.otherInfo.Substring(this.otherInfo.Length - 10)), out data);

            return foundBirthDateInfo;
        }

        public DateTime GetBirthDate(string otherInfo)
        {
            DateTime birthDate;

            if (HaveBirthDateInfo(otherInfo))
            {
                birthDate = DateTime.Parse(otherInfo.Substring(otherInfo.Length - 10));
            }
            else
            {
                throw new ArgumentException("There is not valid birth data in this info!");
            }
                    
            return birthDate;
        }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate = GetBirthDate(OtherInfo);
            DateTime secondDate = GetBirthDate(other.OtherInfo);

            bool isOlder = firstDate < secondDate;

            return isOlder;
        }
    }
}