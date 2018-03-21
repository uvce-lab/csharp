namespace CSharpLab.MethodOverriding
{
  public class Shape
  {
    //Mark method as virtual so that it can be overriden in descendant classes
    public virtual string Draw()
    {
      return nameof(Shape);
    }
  }
}