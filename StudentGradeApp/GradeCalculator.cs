namespace StudentGradeApp;

public class GradeCalculator
{
    public static double CalculatePercentage(double totalMarks, int numberOfSubjects)
    {
        if (numberOfSubjects <= 0)
        {
            throw new ArgumentException("Number of subjects must be greater than zero.", nameof(numberOfSubjects));
        }
        
        return totalMarks / numberOfSubjects;
    }
    
    public static string DetermineGrade(double percentage)
    {
        if (percentage >= 80)
        {
            return "A";
        }
        else if (percentage >= 50)
        {
            return "B";
        }
        else if (percentage >= 30)
        {
            return "C";
        }
        else
        {
            return "F";
        }
    }
    
    public static bool ValidateMarks(double marks)
    {
        return marks >= 0 && marks <= 100;
    }
}
