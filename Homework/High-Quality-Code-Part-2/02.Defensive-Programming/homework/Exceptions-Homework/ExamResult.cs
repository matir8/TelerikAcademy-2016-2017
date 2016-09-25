using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("Grade must be positive number.");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("MinGrade must be positive number.");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("MaxGrade must be larger than MinGrade.");
        }
        if (string.IsNullOrEmpty(comments))
        {
            throw new ArgumentNullException("Comments can not be empty");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
