namespace Figures;

public abstract class Figure
{
    public double X { get; set; }
    public double Y { get; set; }
    public double A { get; set; }
    public double B { get; set; }

    public abstract double Surface();
    public abstract double Perimeter();

    public virtual void Move(double x, double y)
    {
        this.X += x;
        this.Y += y;
    }
    public virtual void MoveToCoordinate(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public virtual void Scale(double num)
    {
        switch (num)
        {
            case > 0:
                this.A *= num;
                this.B *= num;
                break;
            case < 0:
                this.A /= num * -1;
                this.B /= num * -1;
                break;
            default:
                return;
        }
    }

    public abstract void Paint();

    public virtual string ToReturn()
    {
        return $"Figure - {this.GetType()}/nPosition X - {this.X}/nPosition Y - {this.Y}/nSide A - {this.A}/nSide B - {this.B}";
    }
}

public class Rectangle : Figure
{
    public override double Surface()
    {
        double surface = A * B;
        Console.WriteLine($"Surface: {surface}");
        return surface;
    }

    public override double Perimeter()
    {
        double perimeter = 2.0 * (A + B);
        Console.WriteLine($"Perimeter: {perimeter}");
        return perimeter;
    }

    public override void Paint()
    {
        throw new NotImplementedException();
    }
}

public class Square : Rectangle
{
    public new double B
    {
        get => this.A;
        set => this.A = value;
    }
}

public class CrosshatchedRectangle : Rectangle
{
    public override void Paint()
    {
        throw new NotImplementedException();
    }
} 

public class RectangularCuboid : Figure
{
    public double Height { get; set; }
    
    public override double Surface()
    {
        double surface = (Height * A + Height * B + A * B);
        Console.WriteLine($"Surface: {surface}");
        return surface;
    }

    public override double Perimeter()
    {
        double perimeter = 2.0 * (A + B + Height);
        Console.WriteLine("Perimeter: ");
        return perimeter;
    }

    public override void Scale(double num)
    {
        switch (num)
        {
            case > 0:
                this.A *= num;
                this.B *= num;
                this.Height *= num;
                break;
            case < 0:
                this.A /= num * -1;
                this.B /= num * -1;
                this.Height /= num * -1;
                break;
            default:
                return;
        }
    }
    
    public override void Paint()
    {
        throw new NotImplementedException();
    }
}

public class Cube : RectangularCuboid
{
    public new double B
    {
        get => this.A;
        set => this.A = value;
    }
    public new double Height
    {
        get => this.A;
        set => this.A = value;
    }
    
    public override void Scale(double num)
    {
        switch (num)
        {
            case > 0:
                this.A *= num;
                this.B *= num;
                this.Height *= num;
                break;
            case < 0:
                this.A /= num * -1;
                this.B /= num * -1;
                this.Height /= num * -1;
                break;
            default:
                return;
        }
    }
}

public class RectangularPiramide : Figure
{
    public double Height;
    public double Sx;

    public override void Scale(double num)
    {
        switch (num)
        {
            case > 0:
                this.A *= num;
                this.B *= num;
                this.Height *= num;
                break;
            case < 0:
                this.A /= num * -1;
                this.B /= num * -1;
                this.Height /= num * -1;
                break;
            default:
                return;
        }
    }
    
    public override double Surface()
    {
        double triangleHeight = Math.Sqrt((this.B * this.B - this.A * this.A)/4);
        double surface = triangleHeight * this.A;
        Console.WriteLine($"Surface: {surface}");
        return surface;
    }

    public override double Perimeter()
    {
        double perimeter = 3 * this.B + 2 * this.A;
        Console.WriteLine($"Perimeter: {perimeter}");
        return perimeter;
    }

    public override void Paint()
    {
        throw new NotImplementedException();
    }
}

public class Picture
{
    public double X { get; set; }
    public double Y { get; set; }
    public List<Figure> figure;
}

























class Program
{
    static void Main(string[] args)
    {
    }
}