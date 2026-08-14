using System;

sealed class EmployeePayroll
{
    double salary;

    public EmployeePayroll(double salary)
    {
        this.salary = salary;
    }

    public double CalculateSalary()
    {
        return salary;
    }

    public double CalculateTax()
    {
        return salary * 0.10;
    }

    public double CalculateNetSalary()
    {
        return salary - CalculateTax();
    }
}