using System;

// Interface for employee
public interface IEmployee
{
    string GetEmployeeName();
    string GetEmployeeID();
    double GetSalary();
}

// Interface for department
public interface IDepartment
{
    string GetDepartmentName();
    string GetHOP();
}

// Employee class implementing both interfaces
public class Employee : IEmployee, IDepartment
{
    private string name;
    private string id;
    private double salary;
    private string departmentName;
    private string hop;

    public Employee(string name, string id, double salary, string departmentName, string hop)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
        this.departmentName = departmentName;
        this.hop = hop;
    }

    // Implementing IEmployee interface
    public string GetEmployeeName()
    {
        return name;
    }

    public string GetEmployeeID()
    {
        return id;
    }

    public double GetSalary()
    {
        return salary;
    }
     
    // Implementing IDepartment interface
    public string GetDepartmentName()
    {
        return departmentName;
    }

    public string GetHOP()
    {
        return hop;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object
        Employee employee = new Employee("John Doe", "E1234", 50000, "IT", "Jane Smith");

        // Display employee information
        Console.WriteLine("Employee Name: " + employee.GetEmployeeName());
        Console.WriteLine("Employee ID: " + employee.GetEmployeeID());
        Console.WriteLine("Salary: " + employee.GetSalary());
        Console.WriteLine("Department: " + employee.GetDepartmentName());
        Console.WriteLine("HOP: " + employee.GetHOP());
    }
}
