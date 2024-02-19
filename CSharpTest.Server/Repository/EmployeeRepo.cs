namespace CSharpTest.Repository;

public class EmployeeRepo
{
    public static List<Employee> Storage = [];

    // TODO 01: add an employee to the list
    public Employee AddEmployee(Employee e) => new();
    
    // TODO Bonus01: add multiple employees to the list

    // TODO 02: get all employees
    public List<Employee> GetEmployees() => [];

    // TODO 03: get an employee by id
    public Employee GetEmployee(int id) => new();
    
    // TODO 04: change the salary of an employee
    public Employee ChangeSalary(int id, int newSalary) => new();

    // TODO 05: retrieves the names of employees in the given department whose salary is above given number, ordered by name (use LINQ query)
    public List<Employee> GetEmployeesByDepartmentAndSalary(string department, int salary) => [];
}