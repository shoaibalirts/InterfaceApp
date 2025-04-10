using HR;
using static System.Console;
namespace InterfaceApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Manager mgr1 = new Manager(102, "Allen", "New York", "Accounting");
            WriteLine("Object of child class (Manager)");
            WriteLine(mgr1.EmpId);
            WriteLine(mgr1.EmpName);
            WriteLine(mgr1.Location);
            WriteLine(mgr1.DepartmentName);
            WriteLine(mgr1.GetHealthInsuranceAmount());
            WriteLine("-----------------------");

            SalesMan salesMan1 = new HR.SalesMan(103, "John", "Washington", "East");
            WriteLine("Object of child class (SalesMan)");
            WriteLine(salesMan1.EmpId);
            WriteLine(salesMan1.EmpName);
            WriteLine(salesMan1.Location);
            WriteLine(salesMan1.DepartmentName);
            WriteLine(salesMan1.GetHealthInsuranceAmount());
            WriteLine("-----------------------");

            // Dynamic Polymorphism through interface (runtime polymorphism)
            IEmployee emp;
            emp = mgr1;
            WriteLine(emp.GetHealthInsuranceAmount());
            WriteLine("-----------------------");

            emp = salesMan1;
            WriteLine(emp.GetHealthInsuranceAmount());
            WriteLine("-----------------------");

            IPerson person = mgr1;
            person.DateOfBirth = System.Convert.ToDateTime("1983-06-08");
            WriteLine(person.GetAge());

        }
    }
}
