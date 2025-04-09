namespace InterfaceApp
{
    public interface IEmployee
    {
        string GetHealthInsuranceAmount(); // bydefault is it public and abstract
        // auto-properties
        int EmpId { set; get; }
        string EmpName { set; get; }
        string Location { set; get; }

    }
}