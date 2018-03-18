namespace CSharpLab.Matrix
{
  class Matrix
  {
    private double[,] _data;
    private double _row, _col;

    public  double Rows => _row;
    public double Columns => _col;

    public Matrix(int row, int column)
    {
      this._row = row;
      this._col = column;
      this._data = new double[row, column];
    }
  }
}