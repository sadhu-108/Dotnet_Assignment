using System;

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public int Semester { get; set; }

    public override bool Equals(object obj)
    {
        Student other = obj as Student;

        if (other == null)
            return false;

        return RollNumber == other.RollNumber &&
               Name == other.Name &&
               Course == other.Course &&
               Semester == other.Semester;
    }

    public override int GetHashCode()
    {
        return RollNumber.GetHashCode() ^
               Name.GetHashCode() ^
               Course.GetHashCode() ^
               Semester.GetHashCode();
    }
}