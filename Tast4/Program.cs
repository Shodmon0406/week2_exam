using Tast4;

List<User> users = new List<User>();
for (int i = 1; i <= 5; i++)
{
    User user = new User();
    System.Console.Write("Enter your name: ");
    user.FirstName = Console.ReadLine();
    System.Console.Write("Enter your surname: ");
    user.LastName = Console.ReadLine();
    System.Console.Write("Enter your username: ");
    user.UserName = Console.ReadLine();
    System.Console.Write("Enter your password: ");
    user.Password = Console.ReadLine();
    users.Add(user);
}
System.Console.WriteLine("---------------------------------------------------------------------");
while (true)
{
    double c = 0;
    System.Console.Write("Enter your username: ");
    string userName = Console.ReadLine();
    System.Console.Write("Enter your password: ");
    string password = Console.ReadLine();
    foreach (var us in users)
    {
        if (userName == us.UserName && password == us.Password)
        {
            System.Console.WriteLine(us.Login());
            c++; ;
        }
    }
    if (c == 0)
    {
        System.Console.WriteLine("Login Failed");
    }
}