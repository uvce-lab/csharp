namespace CSharpLab.MethodOverriding
{
  public class Triangle : Shape
  {
    //Use override keyword to override virtual methods from ancestor classes
    public override string Draw()
    {
      return nameof(Triangle);
    }
  }
}