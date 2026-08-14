using System;

class StudentUtility
{
    public static double CalculatePercentage(double obtainedMarks, double totalMarks)
    {
        return (obtainedMarks / totalMarks) * 100;
    }

    public static char CalculateGrade(double percentage)
    {
        if (percentage >= 90)
            return 'A';
        else if (percentage >= 80)
            return 'B';
        else if (percentage >= 70)
            return 'C';
        else if (percentage >= 60)
            return 'D';
        else
            return 'F';
    }

    public static double CalculateAttendancePercentage(int attendedClasses, int totalClasses)
    {
        return ((double)attendedClasses / totalClasses) * 100;
    }
}