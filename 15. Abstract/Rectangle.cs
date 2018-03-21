namespace CSharpLab.Abstract
{
  public class Rectangle : Shape
  {
    public Rectangle(double height, double width)
    {
      this.height = height;
      this.width = width;
    }

    private double height, width;
    public double Height => height;
    public double Width => width;
    
    public override double Area() => height * width;
  }
}