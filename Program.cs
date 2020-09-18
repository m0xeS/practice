using System;
using System.Text.RegularExpressions;

namespace prac03_01
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] numbers =
      {
        "8005553535", "(800)555-35-35","800-55-35-35"
      };
      foreach (string s in numbers)
      {
        string pattern = @"^\(?\d{3}\)?[\s\-]?\d{3}\-?\d{2}\-?\d{2}$";
        if (Regex.IsMatch(s, pattern))
        {
          Console.WriteLine(s +" телефон");
        }
        else
        {
          Console.WriteLine(s +" не телефон");
        }
      }
    }
  }
}
