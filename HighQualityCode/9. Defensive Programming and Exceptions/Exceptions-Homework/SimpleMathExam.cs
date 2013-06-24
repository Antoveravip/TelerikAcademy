using System;

public class SimpleMathExam : Exam
{ 
    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0)
        {
            throw new ArgumentOutOfRangeException("problemSolved", "The solved problems can't be less than zero!");
        }

        // Here 10 is little as magic number - don't know all the program requirements. 
        // If this number is changing values is good to be parameter!
        if (problemsSolved > 10)
        {
            throw new ArgumentOutOfRangeException("problemSolved", "The solved problems can't be greater than 10!");
        }

        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved { get; private set; }

    public override ExamResult Check()
    {
        ExamResult result = null;

        if (ProblemsSolved == 0)
        {
            result = new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            result = new ExamResult(4, 2, 6, "Average result: nothing done.");
        }
        else if (ProblemsSolved == 2)
        {
            result = new ExamResult(6, 2, 6, "Average result: nothing done.");
        }
        else
	    {
            throw new ArgumentOutOfRangeException("ExanResult", "Invalid number of problems solved!");
	    }

        return result;
    }
}