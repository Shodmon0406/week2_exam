
using Tast3;

while (true)
{
    System.Console.Write("The first number is: ");
    double a = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("The operation is: ");
    char c = Convert.ToChar(Console.ReadLine());
    System.Console.Write("The last number is: ");
    double b = Convert.ToDouble(Console.ReadLine());
    Calculator calculator = new Calculator(a, b);
    double d;
    if (c == '+')
    {
        d = calculator.Sum();
    }
    else if (c == '-')
    {
        d = calculator.Subtract();
    }
    else if (c == '*')
    {
        d = calculator.Multiplication();
    }
    else if (c == '/')
    {
        d = calculator.Division();
    }
    else 
    {
        System.Console.WriteLine("Eror");
        return 0;
    }
    System.Console.WriteLine($"{a} {c} {b} = {d}");
}