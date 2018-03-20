namespace CSharpLab.MethodOverriding
{
  public class Shape
  {
    public virtual string Draw()
    {
      return nameof(Shape);
    }
  }
}