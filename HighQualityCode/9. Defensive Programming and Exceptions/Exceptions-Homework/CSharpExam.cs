using System;

public class CSharpExam : Exam
{
    // According to logic in the original code, 0 and 100 are constants for min and max score!
    // Therefore set them az constant and refacturing the code and exeptions.
    private const int MIN_SCORE = 0;
    private const int MAX_SCORE = 100;

    public CSharpExam(int score)
    {
        if (score < MIN_SCORE)
        {
            throw new ArgumentOutOfRangeException("score",
                string.Format("The score can't be less than {0}!", MIN_SCORE));
        }

        if (score > MAX_SCORE)
        {
            throw new ArgumentOutOfRangeException("score",
                string.Format("The score can't be greater than {0}!", MAX_SCORE));
        }

        this.Score = score;
    }
    public int Score { get; private set; }

    public override ExamResult Check()
    {
        ExamResult result = new ExamResult(this.Score, MIN_SCORE, MAX_SCORE, "Exam results calculated by score.");

        return result;
    }
}