using System;

class University
{
    public class Department
    {
        public string DepartmentName { get; set; }
        public string HODName { get; set; }
        public int FacultyMembers { get; set; }

        public Department(string departmentName, string hodName, int facultyMembers)
        {
            DepartmentName = departmentName;
            HODName = hodName;
            FacultyMembers = facultyMembers;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Department: " + DepartmentName);
            Console.WriteLine("HOD: " + HODName);
            Console.WriteLine("Faculty Members: " + FacultyMembers);
        }
    }
}