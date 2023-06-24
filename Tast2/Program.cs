System.Console.Write("From = ");
int x = int.Parse(Console.ReadLine());
System.Console.Write("To = ");
int y = int.Parse(Console.ReadLine());
for (int i = x; i <= y; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        System.Console.WriteLine($"{i}x{j}={i * j}");
    }
    System.Console.WriteLine();
}