namespace Lab09;

public class Circle : AbstractGraphic2D
{
    public int CenterX { get; set; }
    public int CenterY { get; set; }
    public int Radius{ get; set; }
    
    public override decimal LowerBoundX => CenterX - Radius;

    public override decimal UpperBoundX => CenterX + Radius;

    public override decimal LowerBoundY => CenterY - Radius;

    public override decimal UpperBoundY => CenterY + Radius;

    public Circle(int x, int y, int radius)
    {
        CenterX = x;
        CenterY = y;
        Radius = radius;
    }

    public override bool ContainsPoint(decimal x, decimal y)
    {
        // using the equation (x-h)^2 + (y-k)^2 <= r^2
        decimal dx = x - CenterX;
        decimal dy = y - CenterY;
        return (dx * dx) + (dy * dy) <= Radius * Radius;
    }
}