using System;

public class ExamResult
{
    // In this class all properties have private set - therefore I do all checks in the constructor! 
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("grade", "grade value must be positive number or zero!");
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("minGrade", "minGrade value must be positive number or zero!");
        }

        if (maxGrade < 0)
        {
            throw new ArgumentOutOfRangeException("maxGrade", "maxGrade value must be positive number or zero!");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("maxGrade", "maxGrade value must be bigger than minGrade value!");
        }

        if (minGrade > grade || grade > maxGrade)
        {
            throw new ArgumentOutOfRangeException("grade",
                string.Format("grade value must be in the range between {0} and {1}.", minGrade, maxGrade));
        }

        if (string.IsNullOrWhiteSpace(comments))
        {
            throw new ArgumentNullException("comments", "Comments can't be null, empty or white space!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
    
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }
}