namespace Lab09;

public class Circle : AbstractGraphic2D
{
    public int CenterX { get; set; }
    public int CenterY { get; set; }
    public int Radius{ get; set; }
    
    public override decimal LowerBoundX => -1;

    public override decimal UpperBoundX => -1;

    public override decimal LowerBoundY => -1;

    public override decimal UpperBoundY => -1;

    public Circle(int x, int y, int radius)
    {
        CenterX = x;
        CenterY = y;
        Radius = radius;
    }

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return false;
    }
}