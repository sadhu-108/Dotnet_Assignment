using System;
using System.Collections.Generic;

class Repository<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public T Get(int index)
    {
        return items[index];
    }

    public int Count()
    {
        return items.Count;
    }
}

class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }

    public Employee(int employeeId, string name)
    {
        EmployeeId = employeeId;
        Name = name;
    }
}