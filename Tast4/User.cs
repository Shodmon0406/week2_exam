namespace Tast4;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string GetInfo()
    {
        return $"{FirstName} {LastName} {UserName} {Password}";
    }
}
