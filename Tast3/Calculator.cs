namespace Tast3;

public class Calculator
{
    double _a;
    double _b;
    public Calculator(double a, double b)
    {
        _a = a;
        _b = b;
    }

    public double Sum()
    {
        return _a + _b;
    }
    public double Subtract()
    {
        return _a - _b;
    }
    public double Multiplication()
    {
        return _a * _b;
    }
    public double Division()
    {
        return _a / _b;
    }
}
