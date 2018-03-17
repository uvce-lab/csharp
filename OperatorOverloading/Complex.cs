using System;

namespace CSharpLab.OperatorOverloading
{
  class Complex
  {
    private double _real, _imag;

    public double Real => _real;
    public double Imaginary => _imag;

    public Complex(double real, double imaginary)
    {
      this._real = real;
      this._imag = imaginary;
    }

    public override string ToString()
    {
      var sign = this._imag < 0 ? '-' : '+';
      var imagString = Math.Abs(this._imag);
      return $"{_real} {sign} {imagString}i";
    }
  }
}