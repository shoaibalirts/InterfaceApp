namespace InterfaceApp
{
    public interface IPerson
    {
        System.DateTime DateOfBirth { set; get; }
        int GetAge();
    }
}
