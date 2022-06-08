// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
var obj = new Employee("Nadine","Finance");
//obj.Name = "angelique";
//obj.department = "IT";
obj.empgender = Employee.gender.Femmale;

Console.WriteLine(obj.getemp()+" "+obj.empgender);

public class Employee
{
  private string Name;
    private string department;
    public gender empgender;
    public Employee(string ename, string edepart)
    {
        this.Name = ename;
        this.department = edepart;
    }
    public string getemp()
    {
        return $"Name:{Name} \n Department:{department}";
    }
    public enum gender
    { 
        Femmale,
        male,
        others,
    }
}


