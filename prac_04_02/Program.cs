using System;
using System.Collections;

namespace prac_04_02
{
  class Program
  {
    static void Main(string[] args)
    {
      Queue q = new Queue();
      q.Enqueue("One");
      q.Enqueue("Two");
      q.Enqueue("Three");
      q.Enqueue("Four");
      q.Enqueue("Five");
      while (q.Count>0)
      {
        object dlt = q.Dequeue();
        Console.WriteLine("From queue: {0}", dlt);
      }
      Stack stack = new Stack();
      stack.Push("A");
      stack.Push("B");
      stack.Push("F");
      stack.Push("Da");
      while (stack.Count > 0)
      {
        object obj = stack.Pop();
        Console.WriteLine("'From Stack: {0}", obj);
      }

    }
  }
}
