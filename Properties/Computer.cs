using System;
using System.Text;
using System.Text.RegularExpressions;

using static CSharpLab.Properties.OperatingSystem;

namespace CSharpLab.Properties
{
  public class Computer
  {
    //Auto implemented property (no backing field)
    public string Name { get; set; }

    //Property with default value
    public OperatingSystem OperatingSystem { get; private set; } = Windows;

    //Read only property
    public string ProcessorManufacturer => "Intel";

    //Property with validation in setter
    public string _clockSpeed;
    public string ClockSpeed
    {
      get => _clockSpeed;
      set
      {
        if (Regex.Match(value, @"^([0-9]+)MHz$").Success)
          this._clockSpeed = value;
        else throw new Exception("Invalid clock speed value.");
      }
    }

    public override string ToString()
    {
      var rep = new StringBuilder();

      rep.AppendFormat(
$@"
Name: {this.Name}
Operating System: {this.OperatingSystem}
Processor Manufacturer: {this.ProcessorManufacturer}
Clock Speed: {this.ClockSpeed} 
");

      return rep.ToString();
    }
  }
}