using System;

namespace CSharpLab.Interface
{
  public class Student : IComparable<Student>
  {
    public Student(string name, string rollNumber)
    {
      this.name = name;
      this.rollNumber = rollNumber;
    }
    private string name;
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    private string rollNumber;
    public string RollNumber
    {
      get { return rollNumber; }
      set { rollNumber = value; }
    }

    public override string ToString() => $"{this.rollNumber} - {this.name}";

    public int CompareTo(Student other) => this.rollNumber.CompareTo(other.rollNumber);
  }
}