namespace Laba10_V5;

public class QuadraticEquation : IQuadratic
{
    private double _a;
    private double _b;
    private double _c;

    public string X1 { get; private set; }
    public string X2 { get; private set; }

    public QuadraticEquation(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
        Discriminator();
        Roots();
    }

    private double Discriminator() =>
        Math.Pow(_b, 2) - 4 * _a * _c;

    private void Roots()
    {
        if (Discriminator() > 0)
        {
            X1 = ((-_b + Math.Sqrt(Discriminator())) / (2 * _a)).ToString();
            X2 = ((-_b - Math.Sqrt(Discriminator())) / (2 * _a)).ToString();
        }
        else if(Discriminator() < 0)
        {
            X1 = Convert.ToString($"{-_b} + {Math.Round(Math.Sqrt(Discriminator() * -1), 1)}i / {2 * _a}");
            X2 = Convert.ToString($"{-_b} - {Math.Round(Math.Sqrt(Discriminator() * -1), 1)}i / {2 * _a}");
        }
        
    }

    public override string ToString() =>
        $"x1 = {X1}\nx2 = {X2}";
}