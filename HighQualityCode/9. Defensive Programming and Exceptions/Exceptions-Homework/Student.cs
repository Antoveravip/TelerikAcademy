using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private string firstName;
    private string lastName;

    // In this class all properties have regular set - therefore I do all checks in the properties! 
    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {  
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

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
                throw new ArgumentNullException("firstName", 
                    "First name is not stored! The entered first name value is empty!");
            }

            if (value.Length <= 2)
            {
                throw new ArgumentOutOfRangeException("firstName", 
                    "Not correct first name! First name must be at least three characters!");
            }

            if (value.Length > 50)
            {
                throw new ArgumentOutOfRangeException("firstName", 
                    "Not correct first name! The first name must be a maximum of 50 characters!");
            }

            this.firstName = value;
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
                throw new ArgumentNullException("lastName", 
                    "Last name is not stored! The entered last name value is empty!");
            }

            if (value.Length <= 2)
            {
                throw new ArgumentOutOfRangeException("lastName", 
                    "Not correct last name! Last name must be at least three characters!");
            }

            if (value.Length > 50)
            {
                throw new ArgumentOutOfRangeException("lastName", 
                    "Not correct last name! The last name must be a maximum of 50 characters!");
            }

            this.lastName = value;
        }
    }

    public IList<Exam> Exams { get; set; }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("exam", 
                string.Format("There are no info about exams for a student {0} {1}!", 
                this.FirstName, this.LastName));
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentException("exam", 
                string.Format("There are no exams for a student {0} {1}!",
                this.FirstName, this.LastName));
        }

        IList<ExamResult> results = new List<ExamResult>();

        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        double averageExamResultInPercents = 0;

        if (this.Exams == null)
        {
            throw new ArgumentNullException("exam", 
                string.Format("Can't calculate average exam result! There are no info about exams for a student {0} {1}!",
                this.FirstName, this.LastName));
        }

        if (this.Exams.Count == 0)
        {
            return averageExamResultInPercents;
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();

        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        averageExamResultInPercents = examScore.Average();

        return averageExamResultInPercents;
    }
}