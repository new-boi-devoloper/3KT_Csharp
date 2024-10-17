using System.Numerics;
using System.Reflection;

namespace _3KT_Csharp;

public class ForthPart<Vector2>
{
    public Vector2 Center { get; private set; }

    public virtual Vector2 MinPoint
    {
        get { return Center; }
    }

    public virtual Vector2 MaxPoint
    {
        get { return Center; }
    }

    public ForthPart(Vector2 center)
    {
        Center = center;
    }
}

public class CircleChildForthPart<TRadius> : ForthPart<Vector2>
{
    public TRadius Radius { get; private set; }

    public double Area
    {
        get
        {
            var radius = Convert.ToDouble(Radius);
            return Math.PI * radius * radius;
        }
    }

    public CircleChildForthPart(Vector2 center, TRadius radius) : base(center)
    {
        Radius = radius;
    }

    public void SetRadius(TRadius newRadius)
    {
        Radius = newRadius;
    }
}

public class RectangleChildFifthClass<TWidth, THeight> : ForthPart<Vector2>
{
    public TWidth Width { get; private set; }
    public THeight Height { get; private set; }

    public RectangleChildFifthClass(Vector2 center, TWidth width, THeight height) : base(center)
    {
        Width = width;
        Height = height;
    }

    public override Vector2 MaxPoint
    {
        get
        {
            double width = Convert.ToDouble(Width);
            double height = Convert.ToDouble(Height);
            return new Vector2(Center.X - (float)(width / 2), Center.Y - (float)(height / 2));
        }
    }

    public override Vector2 MinPoint
    {
        get
        {
            double width = Convert.ToDouble(Width);
            double height = Convert.ToDouble(Height);
            return new Vector2(Center.X + (float)(width / 2), Center.Y + (float)(height / 2));
        }
    }
}