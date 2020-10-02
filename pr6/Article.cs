using System;
using System.Collections.Generic;
using System.Text;

namespace pr6
{
  class Article
  {
    public string Name { get; set; }
    public double Rating { get; set; }
    public Person Person_inf { get; set; } 
    public Article(string name, int rating, Person person_inf)
    {
      Name = name;
      Rating = rating;
      Person_inf = person_inf;
    }
    public Article()
    {
      Name = "DefName";
      Rating = 5.0;
      Person_inf.Name = "DefName";
      Person_inf.Surname = "DefSurname";
      Person_inf.BirthDate = DateTime.Now;
      public override string ToString()
    {
      return Name + ": " + Rating + " " + Person_inf.Name + " " + Person_inf.Surname + " " + Person_inf.BirthDate.ToString("dd/MM/yyyy");
    }
  }
  }
}
