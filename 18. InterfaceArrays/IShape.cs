namespace CSharpLab.InterfaceArrays
{
  public interface IShape
  {
    void Input();
    double Area();
    double NumberOfPoints();
    string Name { get; }
  }
}