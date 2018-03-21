using System;
using System.Collections.Generic;

namespace CSharpLab.Stack
{
  class Stack<T>
  {
    private List<T> _data;
    private int _count;

    public int Count => this._count;

    public Stack()
    {
      this._data = new List<T>();
    }

    public void Push(T item)
    {
      //Add the item to the stack
      _data.Add(item);

      //Increment counter
      _count += 1;
    }

    public T Pop()
    {
      if (_count == 0) throw new Exception("Underflow Exception: Cannot pop items from an empty stack.");

      var poppedItem = _data[_count - 1];

      //Remove the item from the stack
      _data.RemoveAt(_count - 1);

      //Decrement counter
      _count -= 1;
      return poppedItem;
    }

    public override string ToString()
    {
      var representation = "[";
      foreach(var item in _data) {
        representation = $"{representation} '{item}'";
      }

      return $"{representation} ] <- TOP";
    }
  }
}