using System;
using HR;
namespace InterfaceApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Manager mgr1 = new Manager(102, "Allen", "New York", "Accounting");
            Console.WriteLine("Object of child class (Manager)");
            Console.WriteLine(mgr1.EmpId);
            Console.WriteLine(mgr1.EmpName);
            Console.WriteLine(mgr1.Location);
            Console.WriteLine(mgr1.DepartmentName);
            Console.WriteLine(mgr1.GetHealthInsuranceAmount());
            Console.WriteLine("-----------------------");

            SalesMan salesMan1 = new HR.SalesMan(103, "John", "Washington", "East");
            Console.WriteLine("Object of child class (SalesMan)");
            Console.WriteLine(salesMan1.EmpId);
            Console.WriteLine(salesMan1.EmpName);
            Console.WriteLine(salesMan1.Location);
            Console.WriteLine(salesMan1.DepartmentName);
            Console.WriteLine(salesMan1.GetHealthInsuranceAmount());
            Console.WriteLine("-----------------------");

            // Dynamic Polymorphism through interface (runtime polymorphism)
            IEmployee emp;
            emp = mgr1;
            Console.WriteLine(emp.GetHealthInsuranceAmount());
            Console.WriteLine("-----------------------");

            emp = salesMan1;
            Console.WriteLine(emp.GetHealthInsuranceAmount());
            Console.WriteLine("-----------------------");

            IPerson person = mgr1;
            person.DateOfBirth = System.Convert.ToDateTime("1983-06-08");
            Console.WriteLine(person.GetAge());

        }
    }
}
