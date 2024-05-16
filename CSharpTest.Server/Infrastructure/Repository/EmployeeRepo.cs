using CSharpTest.Domain.Model;

namespace CSharpTest.Infrastructure.Repository;

public class EmployeeRepo
{
    private static List<Employee> Storage = [];

    // TODO 01: add an employee to the list
    public Employee AddEmployee(Employee employee)
    {
        if (employee == null)
        {
            return null;
        }

        var existingEmployee = Storage.FirstOrDefault(e => e.Id == employee.Id);
        if (existingEmployee != null)
        {
            return existingEmployee;
        }
        
        Storage.Add(employee);

        return employee;
    }
    
    // TODO Bonus01: add multiple employees to the list
    public List<Employee> AddEmployees(List<Employee> employees)
    {
        foreach (var employee in employees)
        {
            AddEmployee(employee);
        }

        return employees;
    }

    // TODO 02: get all employees
    public List<Employee> GetEmployees()
    {
        return Storage;
    }

    // TODO 03: get an employee by id
    public Employee GetEmployee(int id)
    {
        return Storage.FirstOrDefault(e => e.Id == id);
    }
    
    // TODO 04: change the salary of an employee
    public Employee ChangeSalary(int id, int newSalary)
    {
        var emloyee = GetEmployee(id);
        if (emloyee == null)
        {
            return null;
        }

        emloyee.Salary = newSalary;

        return emloyee;
    }

    // TODO 05: retrieves the names of employees in the given department whose salary is above given number, ordered by name (use LINQ query)
    public List<Employee> GetEmployeesByDepartmentAndSalary(string department, int salary) => [];
}