namespace CSharpTest.Domain.Model;

public class Employee : BaseModel
{
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }
}