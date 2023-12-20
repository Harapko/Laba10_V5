namespace Laba10_V5;

public class QuadraticEquation
{
    private double _a;
    private double _b;
    private double _c;

    public double X1 { get; private set; }
    public double X2 { get; private set; }

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
        X1 = (-_b + Math.Sqrt(Discriminator())) / (2 * _a);
        X2 = (-_b - Math.Sqrt(Discriminator())) / (2 * _a);
    }

    public override string ToString() =>
        $"x1 = {Math.Round(X1, 1)}\nx2 = {Math.Round(X2, 1)}";
}