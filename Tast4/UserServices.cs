namespace Tast4;

public class UserServices
{
    List<User> users;
    public UserServices()
    {
        users = new List<User>();
    }
    public void AddUser(User user)
    {
        users.Add(user);
    }
    public string Login(string userName, string password)
    {
        double c = 0;
        foreach (var us in users)
        {
            if (userName == us.UserName && password == us.Password)
            {
                return $"Login successful! Welcome mr {us.FirstName} {us.LastName}";
                c++; ;
            }
        }
        if (c == 0)
        {
            return "Login Failed";
        }
        return null;
    }
}
