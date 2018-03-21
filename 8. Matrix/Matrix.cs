using System;
using System.Linq;

namespace CSharpLab.Matrix
{
  class Matrix
  {
    private double[,] _data;
    private uint _row, _col;

    public uint Rows => _row;
    public uint Columns => _col;

    public Matrix(uint row, uint column, double[,] data)
    {
      this._row = row;
      this._col = column;
      this._data = data;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
      if (a.Columns != b.Rows)
        throw new InvalidOperationException("Matrices are incompatible for multiplication.");

      var result = new double[a.Rows, b.Columns];
      for (int i = 0; i < a.Rows; ++i)
      {
        for (int j = 0; j < b.Columns; ++j)
        {
          result[i, j] = 0;
          for (int k = 0; k < a.Columns; ++k)
            result[i, j] += a._data[i, k] * b._data[k, j];
        }
      }

      return new Matrix(a.Rows, b.Columns, result);
    }

    public override string ToString()
    {
      var rep = "";
      for (int i = 0; i < this.Rows; ++i)
      {
        for (int j = 0; j < this.Columns; ++j)
        {
          rep += $"{_data[i, j]} ";
        }
        rep += $"{Environment.NewLine}";
      }
      return rep;
    }
  }
}